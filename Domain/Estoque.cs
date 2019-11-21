using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Estoques")]
    public class Estoque
    {
        [Key]
        public int EstoqueId { get; set; }

        [Required(ErrorMessage = "*Campo Obrigatorio")]
        public Produto Produto { get; set; }

        [Required(ErrorMessage ="*Campo Obrigatorio")]
        [Range(1,1000, ErrorMessage = "*A quantidade permitida deve estar entre 1 e 1000.")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "*Campo Obrigatorio")]
        [MinLength(5, ErrorMessage = "*No minimo 5 characters.")]
        [MaxLength(50, ErrorMessage = "*No maximo 50 characters.")]
        public string Lote { get; set; }

        public DateTime DataEntrada { get; set; }

        public Estoque()
        {

        }
    }
}
