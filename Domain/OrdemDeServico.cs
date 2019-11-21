using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    [Table("OrdensDeServico")]
    public class OrdemDeServico
    {
        [Key]
        public int OrdemId { get; set; }
        public Pessoa Funcionario { get; set; }
        public Pessoa Cliente { get; set; }
        public Estoque Processador { get; set; }
        public Estoque PlacaMae { get; set; }
        public Estoque Memoria { get; set; }
        public Estoque PlacaVideo { get; set; }
        public Estoque Hd { get; set; }
        public Estoque Ssd { get; set; }
        public bool Aprovado { get; set; }
        public DateTime? InicioProducao { get; set; }
        public DateTime? TerminoProducao { get; set; }

        public OrdemDeServico()
        {

        }

    }
}

