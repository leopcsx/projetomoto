using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoMoto.MVC.Models
{
    public class MotoristaViewModel
    {
        [Key]
        public int MotoristaId { get; set; }

        public string Nome { get; set; }

        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Informe um email válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public int ContratadaId { get; set; }

        public virtual ContratadaViewModel Contratada { get; set; }
    }
}