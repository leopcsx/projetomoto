using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoMoto.MVC.Models
{
    public class ContratadaViewModel
    {
        [Key]
        public int ContratadaId { get; set; }
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        public string Cnpj { get; set; }

        public virtual IEnumerable<MotoristaViewModel> Motoristas { get; set; }
    }
}