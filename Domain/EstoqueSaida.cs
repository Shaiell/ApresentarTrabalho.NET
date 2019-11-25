using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class EstoqueSaida : Estoque
    {
        public DateTime DataSaida { get; set; }
        public int OrdemDeServico { get; set; }
        public bool Ativo { get; set; }


        public EstoqueSaida()
        {
            this.DataSaida = DateTime.Now;
            this.Ativo = true;

        }
    }
}
