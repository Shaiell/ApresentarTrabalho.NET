using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class EstoqueDAO : IRepository<Estoque>
    {
        private readonly Context ctx;
        public EstoqueDAO(Context context)
        {
            ctx = context;
        }

        public Estoque BuscarPorId(int? id)
        {
            return ctx.Estoques.Include("Produto").FirstOrDefault(x=> x.EstoqueId.Equals(id));
        }

        public bool Cadastrar(Estoque objeto)
        {
            ctx.Estoques.Add(objeto);
            ctx.SaveChanges();
            return true;
        }


        public List<Estoque> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public  List<EstoqueEntrada> BuscarEstoquePorCategoria(int IdCategoria)
        {
            return ctx.Estoques.AsNoTracking().OfType<EstoqueEntrada>().Include(x => x.Produto).Include(prod => prod.Produto.Categoria).Where(x => x.Produto.Categoria.CategoriaId == IdCategoria).OrderBy(x => x.DataEntrada).ToList();

        }

        public  Estoque BuscarEstoquePorIdProduto(int id)
        {
            return ctx.Estoques.Include("Produto").FirstOrDefault(x => x.Produto.ProdutoId.Equals(id));
        }

        public  List<EstoqueEntrada> BuscarEstoquePorCategoriaLote(Estoque e)
        {
            return ctx.Estoques.OfType<EstoqueEntrada>().Include(x => x.Produto).Include(prod => prod.Produto.Categoria).Where(x => x.Produto.Categoria.CategoriaId == e.Produto.Categoria.CategoriaId).Where(x => x.Lote == e.Lote).Where(x => x.Produto.Nome == e.Produto.Nome).OrderBy(x => x.DataEntrada).ToList();

        }

        public  List<EstoqueSaida> BuscarTodaListaDeSaida()
        {
            return ctx.Estoques.OfType<EstoqueSaida>().Include(x => x.Produto).Include(prod => prod.Produto.Categoria).OrderByDescending(x => x.DataSaida).ToList();

        }

        public List<EstoqueEntrada> BuscarTodaListaDeEntrada()
        {
            return ctx.Estoques.OfType<EstoqueEntrada>().Include(x => x.Produto).Include(prod => prod.Produto.Categoria).OrderByDescending(x => x.DataEntrada).ToList();

        }

        public  List<EstoqueSaida> BuscarListaDeSaidaPorID(int id)
        {
            return ctx.Estoques.OfType<EstoqueSaida>().Include(x => x.Produto).Include(prod => prod.Produto.Categoria).Where(x => x.OrdemDeServico == id).OrderByDescending(x => x.DataSaida).ToList();


        }

        public  List<EstoqueEntrada> ListaResumidacadastro(int IdCategoria)
        {
            List<EstoqueEntrada> estoquePorID = new List<EstoqueEntrada>();
            List<EstoqueEntrada> estoqueUnicos = new List<EstoqueEntrada>();
            estoquePorID = BuscarEstoquePorCategoria(IdCategoria);
            if (estoquePorID.Count != 0)
            {
                estoqueUnicos.Add(estoquePorID[0]);
            }
            bool add = true;

            for (int i = 0; i < estoquePorID.Count; i++)
            {
                for (int j = 0; j < estoqueUnicos.Count; j++)
                {
                    if (estoquePorID[i].Produto.Nome.Equals(estoqueUnicos[j].Produto.Nome))
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    estoqueUnicos.Add(estoquePorID[i]);
                }
                add = true;
            }
            return estoqueUnicos;
        }

        public  List<EstoqueEntrada> ListaResumida(int IdCategoria)
        {
            List<EstoqueEntrada> estoquePorID = new List<EstoqueEntrada>();
            List<EstoqueEntrada> estoqueUnicos = new List<EstoqueEntrada>();
            estoquePorID = BuscarEstoquePorCategoria(IdCategoria);
            if (estoquePorID.Count != 0)
            {
                estoqueUnicos.Add(estoquePorID[0]);
            }
            bool add = true;

            for (int i = 0; i < estoquePorID.Count; i++)
            {
                for (int j = 0; j < estoqueUnicos.Count; j++)
                {
                    if (estoquePorID[i].Lote.Equals(estoqueUnicos[j].Lote))
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                {
                    estoqueUnicos.Add(estoquePorID[i]);
                }
                add = true;
            }
            return estoqueUnicos;
        }

        public  List<EstoqueEntrada> ListaResumidaQuantidade(int IdCategoria)
        {
            List<EstoqueEntrada> estoquePorID = new List<EstoqueEntrada>();
            List<EstoqueEntrada> estoqueUnicos = new List<EstoqueEntrada>();
            estoqueUnicos = ListaResumida(IdCategoria);
            estoquePorID = BuscarEstoquePorCategoria(IdCategoria);



            for (int i = 0; i < estoqueUnicos.Count; i++)
            {
                estoqueUnicos[i].Quantidade = 0;
                for (int j = 0; j < estoquePorID.Count; j++)
                {
                    if (estoqueUnicos[i].Lote.Equals(estoquePorID[j].Lote))
                    {
                        estoqueUnicos[i].Quantidade += 1;
                    }
                }

            }
            return estoqueUnicos;
        }

        public  void ExcluirEstoque(int? id)
        {
            ctx.Remove(BuscarPorId(id));
            ctx.SaveChanges();
        }

        public  void AlterarEstoque(EstoqueSaida e)
        {
            ctx.Entry(e).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
