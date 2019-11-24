using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class OrdemDeServicoDAO
    {
        private readonly Context ctx;

        public OrdemDeServicoDAO(Context context)
        {
            ctx = context;
        }
        public  void CadastrarOs(OrdemDeServico o)
        {
            ctx.OrdemsDeServico.Add(o);
            ctx.SaveChanges();
        }

        public  OrdemDeServico listarOrdemPorCliente(Pessoa c)
        {

            return ctx.OrdemsDeServico.FirstOrDefault(x => x.Cliente.Cpf.Equals(c.Cpf));

        }

        public  OrdemDeServico listarOrdemPorFuncionario(Pessoa f)
        {

            return ctx.OrdemsDeServico.Include("Funcionario").FirstOrDefault(x => x.Funcionario.Cpf.Equals(f.Cpf));

        }

        public  List<OrdemDeServico> ListarTodasAsOrdens()
        {
            return ctx.OrdemsDeServico.Include(x =>x.Cliente).Include(x=> x.Hd.Produto).ToList();
        }

        public  List<OrdemDeServico> ListarOsALiberarPorPessoa(Pessoa c)
        {
            return ctx.OrdemsDeServico.Where(x => x.Aprovado.Equals(false) && x.Cliente.Cpf == c.Cpf).Include(x => x.Processador.Produto)
                .Include(x => x.PlacaMae.Produto).Include(x => x.Memoria.Produto).Include(x => x.PlacaVideo.Produto)
                .Include(x => x.Hd.Produto).Include(x => x.Ssd.Produto).Include(x => x.Funcionario).Include(x => x.Cliente).ToList();

        }

        public List<OrdemDeServico> ListarOsLiberadasPorPessoa(Pessoa c)
        {
            return ctx.OrdemsDeServico.Where(x => x.Aprovado.Equals(true) && x.Cliente.Cpf == c.Cpf).Include(x => x.Processador.Produto)
                .Include(x => x.PlacaMae.Produto).Include(x => x.Memoria.Produto).Include(x => x.PlacaVideo.Produto)
                .Include(x => x.Hd.Produto).Include(x => x.Ssd.Produto).Include(x => x.Funcionario).Include(x => x.Cliente).ToList();

        }

        public List<OrdemDeServico> ListarOsALiberarTodos()
        {
            return ctx.OrdemsDeServico.Where(x => x.Aprovado.Equals(false)).Include(x => x.Processador.Produto)
                .Include(x => x.PlacaMae.Produto).Include(x => x.Memoria.Produto).Include(x => x.PlacaVideo.Produto)
                .Include(x => x.Hd.Produto).Include(x => x.Ssd.Produto).Include(x => x.Funcionario).Include(x => x.Cliente).ToList();

        }

        public  List<OrdemDeServico> ListarOsLiberadasTodos()
        {
            return ctx.OrdemsDeServico.Where(x => x.Aprovado.Equals(true)).Include(x => x.Processador.Produto)
                .Include(x => x.PlacaMae.Produto).Include(x => x.Memoria.Produto).Include(x => x.PlacaVideo.Produto)
                .Include(x => x.Hd.Produto).Include(x => x.Ssd.Produto).Include(x => x.Funcionario).Include(x => x.Cliente).ToList();

        }

        public  void LiberarOrdemServico(OrdemDeServico o)
        {
            ctx.Entry(o).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
