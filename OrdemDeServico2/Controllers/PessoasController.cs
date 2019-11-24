using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;
using System.Net;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;

namespace OrdemDeServico2.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoaDAO pDAO;
        private readonly UserManager<UsuarioLogado> userManager;
        private readonly SignInManager<UsuarioLogado> signInManager;

        public PessoasController(PessoaDAO pessoaDAO, UserManager<UsuarioLogado> u, SignInManager<UsuarioLogado> s)
        {
            pDAO = pessoaDAO;
            userManager = u;
            signInManager = s;
        }

        // GET: Pessoas
        public IActionResult Index()
        {
            ViewBag.Pessoa = pDAO.BuscarPessoaPorCpf(userManager.GetUserName(User));
            return View(pDAO.ListarTodos());
        }

       
        // GET: Pessoas/Create
        public IActionResult Create()
        {
            Pessoa p = new Pessoa();
            if (TempData["Endereco"] != null)
            {
                string resultado = TempData["Endereco"].ToString();
                Endereco endereco =
                    JsonConvert.DeserializeObject<Endereco>
                    (resultado);
                p.Endereco = endereco;
            }
            return View(p);
            
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult> Create( Pessoa pessoa, string nivel)
        {
            if(nivel == null)
            {
                nivel = "Funcionario";
            }

            if (ModelState.IsValid)
            {
                //Criar um objeto do usuario logado e passar obrigatoriamente email e username
                UsuarioLogado userLogado = new UsuarioLogado
                {
                    Email = pessoa.Email,
                    UserName = pessoa.Cpf
                };
                //Cadastra o usuario na tabela do Identity
                IdentityResult result = await userManager.CreateAsync(userLogado, pessoa.Senha);
                //Testa o resultado do cadastro
                if (result.Succeeded)
                {
                   

                    if (nivel.Equals("Administrador"))
                    {
                        Funcionario p1 = new Funcionario();
                        p1.Nome = pessoa.Nome;
                        p1.Endereco = pessoa.Endereco;
                        p1.Email = pessoa.Email;
                        p1.Cpf = pessoa.Cpf;
                        p1.Senha = pessoa.Senha;
                        p1.ConfirmacaoSenha = pessoa.ConfirmacaoSenha;
                        p1.Sexo = pessoa.Sexo;
                        p1.Telefone = pessoa.Telefone;
                        p1.Acesso = "Administrador";
                        if (pDAO.CadastrarAdministrador(p1)) {

                            //Logar usuario no sistema
                            await signInManager.SignInAsync(userLogado, isPersistent: false);
                            return RedirectToAction("Index", "Estoque");
                        }
                        else {
                            ModelState.AddModelError("", "Cpf já Cadastrado");
                        }

                    }
                    else
                    {
                        Cliente p1 = new Cliente();
                        p1.Nome = pessoa.Nome;
                        p1.Endereco = pessoa.Endereco;
                        p1.Email = pessoa.Email;
                        p1.Cpf = pessoa.Cpf;
                        p1.Senha = pessoa.Senha;
                        p1.ConfirmacaoSenha = pessoa.ConfirmacaoSenha;
                        p1.Sexo = pessoa.Sexo;
                        p1.Telefone = pessoa.Telefone;
                        p1.Acesso = "Funcionario";
                        if (pDAO.CadastrarFuncionario(p1))
                        {
                            //Logar usuario no sistema
                            await signInManager.SignInAsync(userLogado, isPersistent: false);
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Cpf já Cadastrado");
                        }
                    }
                }
                AdicionarErros(result);

               
            }
            return View(pessoa);
        }

        private void AdicionarErros(IdentityResult result)
        {
            foreach (var erro in result.Errors)
            {
                ModelState.AddModelError("", erro.Description);
            }
        }

       

        [HttpPost]
        public IActionResult BuscarCep(Pessoa p)
        {
            string url = "https://api.postmon.com.br/v1/cep/" +
                p.Endereco.Cep;
            WebClient client = new WebClient();
            TempData["Endereco"] = client.DownloadString(url);

            return RedirectToAction(nameof(Create));
        }

        public async Task<IActionResult> Logout()
        {
            signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Pessoa p)
        {
            var result = await signInManager.PasswordSignInAsync(p.Cpf, p.Senha, true, lockoutOnFailure: false);
            if (result.Succeeded)
            {

                Pessoa usuario = pDAO.BuscarPessoaPorCpf(p.Cpf);

                if(usuario.Acesso.Equals("Administrador")) { 
                    return RedirectToAction("Index", "Produto");
                }
                else
                {
                    return RedirectToAction("Index", "OrdemDeServico");
                }
            }

            ModelState.AddModelError("", "Falha no login");
            return View();
            
        }
    }
}
