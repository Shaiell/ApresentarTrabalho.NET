using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ProdutoDAO : IRepository<Produto>
    {
        private readonly Context ctx;

        public ProdutoDAO(Context context)
        {
            ctx = context;
        }
        public Produto BuscarPorId(int? id)
        {
            return ctx.Produtos.Find(id);
        }

        public List<Produto>BuscarPorCategoria(int idCat)
        {
            return ctx.Produtos.Include("Categoria").Where(x => x.Categoria.CategoriaId == idCat).ToList();
        }

        public bool Cadastrar(Produto p)
        {
            if (BuscarProdutoPorNome(p) == null)
            {
                ctx.Produtos.Add(p);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public Produto BuscarProdutoPorNome(Produto p)
        {
            return ctx.Produtos.FirstOrDefault(x => x.Nome.Equals(p.Nome));
        }

        public List<Produto> ListarTodos()
        {
            return ctx.Produtos.Include("Categoria").ToList();
        }

        public void AlterarProduto(Produto p)
        {
            ctx.Update(p);
            ctx.SaveChanges();
        }

        public void ExcluirProduto(int? id)
        {
            ctx.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }
    }
}
