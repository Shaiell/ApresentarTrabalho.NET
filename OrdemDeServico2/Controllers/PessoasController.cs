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

namespace OrdemDeServico2.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoaDAO pDAO;

        public PessoasController(PessoaDAO pessoaDAO)
        {
            pDAO = pessoaDAO;
        }

        // GET: Pessoas
        public IActionResult Index()
        {
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
        public IActionResult Create( Pessoa pessoa, string nivel)
        {
            if (ModelState.IsValid)
            {
                if (nivel.Equals("n1")) {
                    Pessoa p1 = new Cliente();
                    p1 = pessoa;
                    pDAO.Cadastrar(p1);
                    return RedirectToAction("Index");
                    
                }else if (nivel.Equals("n2"))
                {
                    Pessoa p1 = new Funcionario();
                    p1 = pessoa;
                    pDAO.Cadastrar(p1);
                    return RedirectToAction("Index");
                }
            }
            return View(pessoa);
        }

        // GET: Pessoas/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoa = pDAO.BuscarPorId(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            return View(pessoa);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Pessoa pessoa)
        {
            if (id != pessoa.PessoaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
               
                pDAO.AlterarPessoa(pessoa);
                return RedirectToAction(nameof(Index));
            }          
                           
            return View(pessoa);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            pDAO.ExcluirPessoa(id);
            return RedirectToAction(nameof(Index));
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
    }
}
