using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMoto.Data.Entities
{
    public class Motorista
    {
        public int MotoristaId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public int ContratadaId { get; set; }
        public virtual Contratada Contratada { get; set; }
    }
}
