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
    //[Authorize(Roles ="ADM")]
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO pDAO;
        private readonly CategoriaDAO cDAO;
        private readonly EstoqueDAO eDAO;
        private string erro;

        public ProdutoController(ProdutoDAO produtoDAO, CategoriaDAO categoriaDAO, EstoqueDAO estoqueDAO)
        {
            pDAO = produtoDAO;
            cDAO = categoriaDAO;
            eDAO = estoqueDAO;
        }
        
        public IActionResult Index(int drpCategorias)
        {
            
            if (TempData.Get<string>("Erro") != null)
            {
                ViewBag.Erro = erro = TempData.Get<string>("Erro");
            }
            else
            {
                ViewBag.Erro = erro = "";
            }

            if (drpCategorias != 0) { 
            ViewBag.Categorias = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
            ViewBag.DataHora = DateTime.Now;
            return View(pDAO.BuscarPorCategoria(drpCategorias));
            }
            ViewBag.Categorias = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
            ViewBag.DataHora = DateTime.Now;           
            return View(pDAO.ListarTodos());



        }


        // GET: Produto/Create
        public IActionResult Create()
        {
            ViewBag.Categorias = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
            return View();
        }


        [HttpPost]
        public IActionResult Create(Produto produto, int drpCategorias)
        {
            ViewBag.Categorias = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
            if (ModelState.IsValid)
            {
                produto.Categoria = cDAO.BuscarPorId(drpCategorias);

                if (pDAO.Cadastrar(produto))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Este produto ja existe");
                    return View(produto);
                }
            }
            return View(produto);
        }


        public IActionResult Edit(int? id)
        {
            Produto produto = pDAO.BuscarPorId(id);
            SelectList categorias = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
            var marcado = categorias.FirstOrDefault(x => x.Value == produto.Categoria.CategoriaId.ToString()).Selected = true;
            ViewBag.Categorias = categorias;
            
            return View(produto);
        }


        [HttpPost]
        public IActionResult Edit( Produto produto, int drpCategorias)
        {
            Categoria cat = cDAO.BuscarPorId(drpCategorias);
            produto.Categoria = cat;
            pDAO.AlterarProduto(produto);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Produto p = pDAO.BuscarPorId(id);
                if(eDAO.BuscarEstoquePorIdProduto(p.ProdutoId) ==null) {
                    pDAO.ExcluirProduto(id);
                }
                else
                {
                    TempData.Put("Erro", "Este produto não pode ser excluido pois existe um item no estoque");
                    return RedirectToAction("Index");
                }

            }
            else
            {
                //Direcionar para uma pagina de erro.
            }
            return RedirectToAction("Index");
        }

        

    }
}
