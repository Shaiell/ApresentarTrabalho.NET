using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;
using Microsoft.AspNetCore.Authorization;

namespace OrdemDeServico2.Controllers
{
    [Authorize]
    public class EstoqueController : Controller
    {
        private readonly EstoqueDAO eDAO;
        private readonly CategoriaDAO cDAO;
        private readonly ProdutoDAO pDAO;

        public EstoqueController(EstoqueDAO estoqueDAO, CategoriaDAO categoriaDAO, ProdutoDAO produtoDAO)
        {
            eDAO = estoqueDAO;
            cDAO = categoriaDAO;
            pDAO = produtoDAO;
        }

        // GET: Estoque
        public IActionResult Index(int drpCategorias)
        {
            if (drpCategorias != 0)
            {
                ViewBag.Categorias = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
                ViewBag.DataHora = DateTime.Now;
                ViewBag.Entrada = eDAO.BuscarEstoqueEntrdaPorCategoria(drpCategorias);
                ViewBag.Saida = eDAO.BuscarEstoquesaidaPorCategoria(drpCategorias);
                return View();
            }
            ViewBag.Categorias = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
            ViewBag.DataHora = DateTime.Now;
            ViewBag.Entrada = eDAO.BuscarTodaListaDeEntrada();
            ViewBag.Saida = eDAO.BuscarTodaListaDeSaida();
            return View();
        }



        // GET: Estoque/Create ///verificar cadastro de usuario professor.
        public IActionResult Create()
        {
            Estoque estoque = new Estoque();

            if (TempData.Get<Categoria>("Categoria") != null) {
                Categoria cat = TempData.Get<Categoria>("Categoria");

                SelectList categorias = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
                var marcado = categorias.FirstOrDefault(x => x.Value == cat.CategoriaId.ToString()).Selected = true;
                ViewBag.Categorias = categorias;

                ViewBag.Produtos = new SelectList(pDAO.BuscarPorCategoria(cat.CategoriaId), "ProdutoId", "Nome");

            }
            else { 
            ViewBag.Categorias  = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
            }

            return View(estoque);
 

            }


        [HttpPost]
        public IActionResult Create(Estoque estoque, int drpProduto, int drpCategorias)
        {
            if (drpCategorias != 0)
            {
                SelectList categorias = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
                var marcado = categorias.FirstOrDefault(x => x.Value == drpCategorias.ToString()).Selected = true;
                ViewBag.Categorias = categorias;
                if (drpCategorias != 0)
                {
                    if (drpProduto != 0)
                    {
                        SelectList produtos = new SelectList(pDAO.BuscarPorCategoria(drpCategorias), "ProdutoId", "Nome");
                        var marcadop = produtos.FirstOrDefault(x => x.Value == drpProduto.ToString()).Selected = true;
                        ViewBag.Produtos = produtos;
                    
                        Produto produto = pDAO.BuscarPorId(drpProduto);
                        estoque.Produto = produto;

                        if (estoque.Quantidade > 0)
                        {
                            if (!estoque.Lote.Equals("")) { 

                                Estoque estoqueAux = new EstoqueEntrada();
                                int quant = estoque.Quantidade;
                                for (int x = 0; x < quant; x++)
                                {
                                    estoqueAux.Produto = estoque.Produto;
                                    estoqueAux.Lote = estoque.Lote;
                                    estoqueAux.Quantidade = 1;
                                    eDAO.Cadastrar(estoqueAux);
                                    estoqueAux = new EstoqueEntrada();
                                }
                                return RedirectToAction("Index");
                            }
                            else
                            {
                                return View(estoque);
                            }
                        }
                        else
                        {
                            return View(estoque);
                        }

                    }
                    else
                    {
                        return View(estoque);
                    }
                }
            }
            else
            {
                ViewBag.Categorias = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
            }
            return View(estoque);
        }

        [HttpPost]
        public IActionResult BuscarCategoria(int drpCategorias)
        {

             
                TempData.Put("Categoria", cDAO.BuscarPorId(drpCategorias));
                return RedirectToAction(nameof(Create));

        }


        // GET: Estoque/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                eDAO.ExcluirEstoque(id);
            }
            else
            {
                //Direcionar para uma pagina de erro.
            }
            return RedirectToAction("Index");
        }


    }
}
