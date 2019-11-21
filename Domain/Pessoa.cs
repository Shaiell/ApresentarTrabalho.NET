using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "*Campo Obrigatorio")]
        public string Nome { get; set; }

        [Display(Name = "Cpf:")]
        [Required(ErrorMessage = "*Campo Obrigatorio")]
        public string Cpf { get; set; }

        [Display(Name = "Telefone:")]
        [Required(ErrorMessage = "*Campo Obrigatorio")]
        public string Telefone { get; set; }
        public DateTime CriadoEm { get; set; }

        [Display(Name = "Sexo:")]
        [Required(ErrorMessage = "*Campo Obrigatorio")]
        public string Sexo { get; set; }


        public Endereco Endereco { get; set; }

        [Display(Name = "E-mail:")]
        [Required(ErrorMessage = "*Campo Obrigatorio")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Senha:")]
        [Required(ErrorMessage = "*Campo Obrigatorio")]
        public string Senha { get; set; }

        [Display(Name = "Confirmação da senha:")]
        [Required(ErrorMessage = "*Campo Obrigatorio")]
        [NotMapped]
        [Compare("Senha", ErrorMessage = "Os campos não coincidem!")]
        public string ConfirmacaoSenha { get; set; }


        public Pessoa()
        {

        }
    }
}
