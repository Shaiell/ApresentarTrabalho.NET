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


        public EstoqueSaida Processador { get; set; }

        public EstoqueSaida PlacaMae { get; set; }

        public EstoqueSaida Memoria { get; set; }

        public EstoqueSaida PlacaVideo { get; set; }

        public EstoqueSaida Hd { get; set; }

        public EstoqueSaida Ssd { get; set; }

        public bool Aprovado { get; set; }
        public bool Negado { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatorio.")]
        public DateTime? InicioProducao { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatorio.")]
        public DateTime? TerminoProducao { get; set; }
        public DateTime? Rejeicao { get; set; }

        public OrdemDeServico()
        {

        }

    }
}

