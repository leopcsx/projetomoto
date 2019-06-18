using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMoto.Data.Entities
{
    public class Contratada
    {
        public int ContratadaId { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public virtual IEnumerable<Motorista> Motoristas { get; set; }
    }
}
