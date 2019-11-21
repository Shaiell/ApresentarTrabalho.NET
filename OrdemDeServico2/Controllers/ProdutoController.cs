﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;

namespace OrdemDeServico2.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO pDAO;
        private readonly CategoriaDAO cDAO;

        public ProdutoController(ProdutoDAO produtoDAO, CategoriaDAO categoriaDAO)
        {
            pDAO = produtoDAO;
            cDAO = categoriaDAO;
        }
        
        public IActionResult Index(int drpCategorias)
        {
            if(drpCategorias != 0) { 
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
            ViewBag.Categorias = new SelectList(cDAO.ListarTodos(), "CategoriaId", "Nome");
            return View(pDAO.BuscarPorId(id));
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
                pDAO.ExcluirProduto(id);
            }
            else
            {
                //Direcionar para uma pagina de erro.
            }
            return RedirectToAction("Index");
        }

        

    }
}