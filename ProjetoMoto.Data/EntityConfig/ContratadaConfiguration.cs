using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoMoto.Data.Entities;

namespace ProjetoMoto.Data.EntityConfig
{
    public class ContratadaConfiguration : EntityTypeConfiguration<Contratada>
    {
        public ContratadaConfiguration()
        {
            HasKey(c => c.ContratadaId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Cnpj)
                .IsRequired()
                .HasMaxLength(11);

        }
    }
}
