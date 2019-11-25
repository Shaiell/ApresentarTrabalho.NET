using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;
using Microsoft.AspNetCore.Identity;

namespace OrdemDeServico2.Controllers
{
    public class OrdemDeServicoController : Controller
    {
        private readonly PessoaDAO pDAO;
        private readonly CategoriaDAO cDAO;
        private readonly OrdemDeServicoDAO oDAO;
        private readonly EstoqueDAO eDAO;
        private readonly UserManager<UsuarioLogado> userManager;
        private readonly SignInManager<UsuarioLogado> signInManager;

        public OrdemDeServicoController(PessoaDAO pessoaDAO, CategoriaDAO categoriaDAO, OrdemDeServicoDAO ordemDeServicoDAO, EstoqueDAO estoqueDAO, UserManager<UsuarioLogado> u, SignInManager<UsuarioLogado> s)
        {
            pDAO = pessoaDAO;
            cDAO = categoriaDAO;
            oDAO = ordemDeServicoDAO;
            eDAO = estoqueDAO;
            userManager = u;
            signInManager = s;
        }

        public IActionResult Index()
        {
            Pessoa p = pDAO.BuscarPessoaPorCpf(userManager.GetUserName(User));
            ViewBag.Aprovadas = oDAO.ListarOsLiberadasPorPessoa(p);
            ViewBag.Reprovadas = oDAO.ListarOsReprovadasPorPessoa(p);
            return View(oDAO.ListarOsALiberarPorPessoa(p));
        }

        public IActionResult IndexAdmim()
        {
            Pessoa p = pDAO.BuscarPessoaPorCpf(userManager.GetUserName(User));
            ViewBag.Aprovadas = oDAO.ListarOsLiberadasTodos();
            ViewBag.Reprovadas = oDAO.ListarOsReprovadasTodos();
            return View(oDAO.ListarOsALiberarTodos());
        }


        // GET: OrdemDeServico/Create
        public IActionResult Create()
        {
            ViewBag.Processador = new SelectList(eDAO.ListaResumidaQuantidade(1), "EstoqueId", "Produto.Nome");
            ViewBag.PlacaMae = new SelectList(eDAO.ListaResumidaQuantidade(2), "EstoqueId", "Produto.Nome");
            ViewBag.Memoria = new SelectList(eDAO.ListaResumidaQuantidade(3), "EstoqueId", "Produto.Nome");
            ViewBag.PlacaVideo = new SelectList(eDAO.ListaResumidaQuantidade(4), "EstoqueId", "Produto.Nome");
            ViewBag.Hd = new SelectList(eDAO.ListaResumidaQuantidade(5), "EstoqueId", "Produto.Nome");
            ViewBag.Ssd = new SelectList(eDAO.ListaResumidaQuantidade(6), "EstoqueId", "Produto.Nome");

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(OrdemDeServico ordemDeServico, int drpProcessador, int drpPlacaMae, int drpMemoria, int drpPlacaVideo, int drpHd, int drSsd)
        {
            Estoque estoqueEntrada ;
            EstoqueSaida estoqueSaida;

            if (drpProcessador != 0)
            {
                if (drpPlacaMae != 0)
                {
                    if (drpMemoria != 0)
                    {
                        if (drpPlacaVideo != 0)
                        {
                            if (drpHd != 0)
                            {
                                if (drSsd != 0)
                                {
                                    Pessoa p = pDAO.BuscarPessoaPorCpf(userManager.GetUserName(User));
                                    Pessoa f = pDAO.BuscarPessoaPorCpf("123456789");
                                    if (ModelState.IsValid)
                                    {
                                        //Cadastrdo do processador
                                        estoqueEntrada = new EstoqueEntrada();
                                        estoqueSaida = new EstoqueSaida();
                                        estoqueEntrada = eDAO.BuscarPorId(drpProcessador);
                                        estoqueSaida.DataEntrada = estoqueEntrada.DataEntrada;
                                        estoqueSaida.Lote = estoqueEntrada.Lote;
                                        estoqueSaida.Produto = estoqueEntrada.Produto;
                                        estoqueSaida.Quantidade = estoqueEntrada.Quantidade;
                                        eDAO.Cadastrar(estoqueSaida);
                                        eDAO.ExcluirEstoque(estoqueEntrada.EstoqueId);
                                        ordemDeServico.Processador = estoqueSaida;

                                        //Cadastrdo do PlacaMae
                                        estoqueEntrada = new EstoqueEntrada();
                                        estoqueSaida = new EstoqueSaida();
                                        estoqueEntrada = eDAO.BuscarPorId(drpPlacaMae);
                                        estoqueSaida.DataEntrada = estoqueEntrada.DataEntrada;
                                        estoqueSaida.Lote = estoqueEntrada.Lote;
                                        estoqueSaida.Produto = estoqueEntrada.Produto;
                                        estoqueSaida.Quantidade = estoqueEntrada.Quantidade;
                                        eDAO.Cadastrar(estoqueSaida);
                                        eDAO.ExcluirEstoque(estoqueEntrada.EstoqueId);
                                        ordemDeServico.PlacaMae = estoqueSaida;

                                        //Cadastrdo do Memoria
                                        estoqueEntrada = new EstoqueEntrada();
                                        estoqueSaida = new EstoqueSaida();
                                        estoqueEntrada = eDAO.BuscarPorId(drpMemoria);
                                        estoqueSaida.DataEntrada = estoqueEntrada.DataEntrada;
                                        estoqueSaida.Lote = estoqueEntrada.Lote;
                                        estoqueSaida.Produto = estoqueEntrada.Produto;
                                        estoqueSaida.Quantidade = estoqueEntrada.Quantidade;
                                        eDAO.Cadastrar(estoqueSaida);
                                        eDAO.ExcluirEstoque(estoqueEntrada.EstoqueId);
                                        ordemDeServico.Memoria = estoqueSaida;

                                        //Cadastrdo do PlacaVideo
                                        estoqueEntrada = new EstoqueEntrada();
                                        estoqueSaida = new EstoqueSaida();
                                        estoqueEntrada = eDAO.BuscarPorId(drpPlacaVideo);
                                        estoqueSaida.DataEntrada = estoqueEntrada.DataEntrada;
                                        estoqueSaida.Lote = estoqueEntrada.Lote;
                                        estoqueSaida.Produto = estoqueEntrada.Produto;
                                        estoqueSaida.Quantidade = estoqueEntrada.Quantidade;
                                        eDAO.Cadastrar(estoqueSaida);
                                        eDAO.ExcluirEstoque(estoqueEntrada.EstoqueId);
                                        ordemDeServico.PlacaVideo = estoqueSaida;

                                        //Cadastrdo do Hd
                                        estoqueEntrada = new EstoqueEntrada();
                                        estoqueSaida = new EstoqueSaida();
                                        estoqueEntrada = eDAO.BuscarPorId(drpHd);
                                        estoqueSaida.DataEntrada = estoqueEntrada.DataEntrada;
                                        estoqueSaida.Lote = estoqueEntrada.Lote;
                                        estoqueSaida.Produto = estoqueEntrada.Produto;
                                        estoqueSaida.Quantidade = estoqueEntrada.Quantidade;
                                        eDAO.Cadastrar(estoqueSaida);
                                        eDAO.ExcluirEstoque(estoqueEntrada.EstoqueId);
                                        ordemDeServico.Hd = estoqueSaida;

                                        //Cadastrdo do Ssd
                                        estoqueEntrada = new EstoqueEntrada();
                                        estoqueSaida = new EstoqueSaida();
                                        estoqueEntrada = eDAO.BuscarPorId(drSsd);
                                        estoqueSaida.DataEntrada = estoqueEntrada.DataEntrada;
                                        estoqueSaida.Lote = estoqueEntrada.Lote;
                                        estoqueSaida.Produto = estoqueEntrada.Produto;
                                        estoqueSaida.Quantidade = estoqueEntrada.Quantidade;
                                        eDAO.Cadastrar(estoqueSaida);
                                        eDAO.ExcluirEstoque(estoqueEntrada.EstoqueId);
                                        ordemDeServico.Ssd = estoqueSaida;

                                        ordemDeServico.Cliente = p;
                                        ordemDeServico.Funcionario = f;
                                        ordemDeServico.Aprovado = false;
                                        ordemDeServico.Negado = false;
                                        oDAO.CadastrarOs(ordemDeServico);
                                        return RedirectToAction("Index", "OrdemDeServico");
                                    }
                                }
                                else { ModelState.AddModelError("", "Selecione um SSD"); }
                            }
                            else { ModelState.AddModelError("", "Selecione um HD"); }
                        }
                        else { ModelState.AddModelError("", "Selecione uma Placa de Video"); }
                    }
                    else { ModelState.AddModelError("", "Selecione uma Memoria"); }
                }
                else { ModelState.AddModelError("", "Selecione uma Placa Mãe"); }
            }
            else { ModelState.AddModelError("", "Selecione um Processador"); }

                

            if(drpProcessador != 0) { 
                SelectList processador = new SelectList(eDAO.ListaResumidaQuantidade(1), "EstoqueId", "Produto.Nome");
                var marcado = processador.FirstOrDefault(x => x.Value == drpProcessador.ToString()).Selected = true;
                ViewBag.Processador = processador;
            }
            else
            {
                ViewBag.Processador = new SelectList(eDAO.ListaResumidaQuantidade(1), "EstoqueId", "Produto.Nome");
            }

            if (drpPlacaMae != 0)
            {
                SelectList placaMae = new SelectList(eDAO.ListaResumidaQuantidade(2), "EstoqueId", "Produto.Nome");
                var marcado = placaMae.FirstOrDefault(x => x.Value == drpPlacaMae.ToString()).Selected = true;
                ViewBag.PlacaMae = placaMae;
            }
            else
            {
                ViewBag.PlacaMae = new SelectList(eDAO.ListaResumidaQuantidade(2), "EstoqueId", "Produto.Nome");
            }

            if (drpMemoria != 0)
            {
                SelectList memoria = new SelectList(eDAO.ListaResumidaQuantidade(3), "EstoqueId", "Produto.Nome");
                var marcado = memoria.FirstOrDefault(x => x.Value == drpMemoria.ToString()).Selected = true;
                ViewBag.Memoria = memoria;
            }
            else
            {
                ViewBag.Memoria = new SelectList(eDAO.ListaResumidaQuantidade(3), "EstoqueId", "Produto.Nome");
            }

            if (drpPlacaVideo != 0)
            {
                SelectList placaVideo = new SelectList(eDAO.ListaResumidaQuantidade(4), "EstoqueId", "Produto.Nome");
                var marcado = placaVideo.FirstOrDefault(x => x.Value == drpPlacaVideo.ToString()).Selected = true;
                ViewBag.PlacaVideo = placaVideo;
            }
            else
            {
                ViewBag.PlacaVideo = new SelectList(eDAO.ListaResumidaQuantidade(4), "EstoqueId", "Produto.Nome");
            }

            if (drpHd != 0)
            {
                SelectList hd = new SelectList(eDAO.ListaResumidaQuantidade(5), "EstoqueId", "Produto.Nome");
                var marcado = hd.FirstOrDefault(x => x.Value == drpHd.ToString()).Selected = true;
                ViewBag.Hd = hd;
            }
            else
            {
                ViewBag.Hd = new SelectList(eDAO.ListaResumidaQuantidade(5), "EstoqueId", "Produto.Nome");
            }

            if (drSsd != 0)
            {
                SelectList ssd = new SelectList(eDAO.ListaResumidaQuantidade(6), "EstoqueId", "Produto.Nome");
                var marcado = ssd.FirstOrDefault(x => x.Value == drSsd.ToString()).Selected = true;
                ViewBag.Ssd = ssd;
            }
            else
            {
                ViewBag.Ssd = new SelectList(eDAO.ListaResumidaQuantidade(6), "EstoqueId", "Produto.Nome");
            }
            return View(ordemDeServico);
        }

        
        public ActionResult Liberar (int id)
        {
            OrdemDeServico o = oDAO.buscarOrdemProId(id);
            Pessoa p = pDAO.BuscarPessoaPorCpf(userManager.GetUserName(User));
            o.Funcionario = p;
            o.Aprovado = true;
            o.Processador.OrdemDeServico = o.OrdemId;
            o.PlacaMae.OrdemDeServico = o.OrdemId;
            o.PlacaVideo.OrdemDeServico = o.OrdemId;
            o.Memoria.OrdemDeServico = o.OrdemId;
            o.Hd.OrdemDeServico = o.OrdemId;
            o.Ssd.OrdemDeServico = o.OrdemId;
            oDAO.AlterarOrdemServico(o);
            return RedirectToAction("IndexAdmim", "OrdemDeServico");
        }

        
        public ActionResult Reprovar(int id)
        {
            Estoque estoqueEntrada;

            OrdemDeServico o = oDAO.buscarOrdemProId(id);
            Pessoa p = pDAO.BuscarPessoaPorCpf(userManager.GetUserName(User));

            //Processador
            estoqueEntrada = new EstoqueEntrada();
            estoqueEntrada.DataEntrada = o.Processador.DataEntrada;
            estoqueEntrada.Lote = o.Processador.Lote;
            estoqueEntrada.Produto = o.Processador.Produto;
            estoqueEntrada.Quantidade = o.Processador.Quantidade;
            o.Processador.Ativo = false;
            eDAO.Cadastrar(estoqueEntrada);

            //Memoria
            estoqueEntrada = new EstoqueEntrada();
            estoqueEntrada.DataEntrada = o.Memoria.DataEntrada;
            estoqueEntrada.Lote = o.Memoria.Lote;
            estoqueEntrada.Produto = o.Memoria.Produto;
            estoqueEntrada.Quantidade = o.Memoria.Quantidade;
            o.Memoria.Ativo = false;
            eDAO.Cadastrar(estoqueEntrada);

            //Placa Mãe
            estoqueEntrada = new EstoqueEntrada();
            estoqueEntrada.DataEntrada = o.PlacaMae.DataEntrada;
            estoqueEntrada.Lote = o.PlacaMae.Lote;
            estoqueEntrada.Produto = o.PlacaMae.Produto;
            estoqueEntrada.Quantidade = o.PlacaMae.Quantidade;
            o.PlacaMae.Ativo = false;
            eDAO.Cadastrar(estoqueEntrada);

            //Placa Video
            estoqueEntrada = new EstoqueEntrada();
            estoqueEntrada.DataEntrada = o.PlacaVideo.DataEntrada;
            estoqueEntrada.Lote = o.PlacaVideo.Lote;
            estoqueEntrada.Produto = o.PlacaVideo.Produto;
            estoqueEntrada.Quantidade = o.PlacaVideo.Quantidade;
            o.PlacaVideo.Ativo = false;
            eDAO.Cadastrar(estoqueEntrada);

            //Placa hd
            estoqueEntrada = new EstoqueEntrada();
            estoqueEntrada.DataEntrada = o.Hd.DataEntrada;
            estoqueEntrada.Lote = o.Hd.Lote;
            estoqueEntrada.Produto = o.Hd.Produto;
            estoqueEntrada.Quantidade = o.Hd.Quantidade;
            o.Hd.Ativo = false;
            eDAO.Cadastrar(estoqueEntrada);

            //Placa ssd
            estoqueEntrada = new EstoqueEntrada();
            estoqueEntrada.DataEntrada = o.Ssd.DataEntrada;
            estoqueEntrada.Lote = o.Ssd.Lote;
            estoqueEntrada.Produto = o.Ssd.Produto;
            estoqueEntrada.Quantidade = o.Ssd.Quantidade;
            o.Ssd.Ativo = false;
            eDAO.Cadastrar(estoqueEntrada);

            
            o.Funcionario = p;
            o.Negado = true;
            o.Rejeicao = DateTime.Now;
            oDAO.AlterarOrdemServico(o);
            return RedirectToAction("IndexAdmim", "OrdemDeServico");
        }


    }
}
