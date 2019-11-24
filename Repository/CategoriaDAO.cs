using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class CategoriaDAO : IRepository<Categoria>
    {
        private readonly Context ctx;

        public CategoriaDAO(Context context)
        {
            ctx = context;
        }
        public Categoria BuscarPorId(int? id)
        {
            return ctx.Categorias.Find(id);
        }

        public bool Cadastrar(Categoria objeto)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> ListarTodos()
        {
            List<Categoria> teste = ctx.Categorias.ToList();
            if (teste.Count() > 0) { 
                return teste;
            }
            else
            {
                CadastrarCategorias();
                return ctx.Categorias.ToList();
            }
        }

        public void CadastrarCategorias()
        {
            Categoria cate;
            

                List<Categoria> cat = new List<Categoria>();
                cate = new Categoria();
                cate.Nome = "Processador";
                cat.Add(cate);
                cate = new Categoria();
                cate.Nome = "Placa Mãe";
                cat.Add(cate);
                cate = new Categoria();
                cate.Nome = "Memoria";
                cat.Add(cate);
                cate = new Categoria();
                cate.Nome = "Placa de Video";
                cat.Add(cate);
                cate = new Categoria();
                cate.Nome = "HD";
                cat.Add(cate);
                cate = new Categoria();
                cate.Nome = "SSD";
                cat.Add(cate);

                for (int i = 0; i < cat.Count; i++)
                {
                    ctx.Categorias.Add(cat[i]);
                    ctx.SaveChanges();
                }
            

        }
    }
}
