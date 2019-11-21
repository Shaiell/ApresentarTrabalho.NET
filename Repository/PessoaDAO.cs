using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class PessoaDAO : IRepository<Pessoa>
    {

        private readonly Context ctx;

        public PessoaDAO(Context context)
        {
            ctx = context;
        }

        public Pessoa BuscarPorId(int? id)
        {
            return ctx.Pessoas.Find(id);
        }

        public bool Cadastrar(Pessoa objeto)
        {
            if (BuscarPessoaPorNome(objeto) == null)
            {
                ctx.Pessoas.Add(objeto);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public Pessoa BuscarPessoaPorNome(Pessoa p)
        {
            return ctx.Pessoas.FirstOrDefault(x => x.Cpf.Equals(p.Cpf));
        }

        public List<Pessoa> ListarTodos()
        {
            return ctx.Pessoas.ToList();
        }

        public void AlterarPessoa(Pessoa p)
        {
            ctx.Update(p);
            ctx.SaveChanges();
        }

        public void ExcluirPessoa(int? id)
        {
            ctx.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }
    }
}
