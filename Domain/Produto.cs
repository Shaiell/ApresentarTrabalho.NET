using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Display(Name = "Produto:")]
        [Required(ErrorMessage = "*Campo Obrigatorio.")]
        [MaxLength(50, ErrorMessage = "*No maximo 50 characters.")]
        public String Nome { get; set; }

        [Display(Name = "Preço:")]
        [Required(ErrorMessage = "*Campo Obrigatorio.")]
        public double? Preco { get; set; }
        public Categoria Categoria { get; set; }
    }
}
