using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }

        [Display(Name = "Bairro:")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade:")]
        public string Cidade { get; set; }

        [Display(Name = "Rua:")]
        public string Logradouro { get; set; }

        [Display(Name = "Cep:")]
        public string Cep { get; set; }

        [Display(Name = "Estado:")]
        public string Estado { get; set; }
    }
}
