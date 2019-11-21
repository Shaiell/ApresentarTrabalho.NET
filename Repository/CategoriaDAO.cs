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
            return ctx.Categorias.ToList();
        }
    }
}
