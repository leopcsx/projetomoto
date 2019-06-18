using ProjetoMoto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMoto.Data.EntityConfig
{
    public class MotoristaConfiguration : EntityTypeConfiguration<Motorista>
    {
        public MotoristaConfiguration()
        {
            HasKey(m => m.MotoristaId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            Property(c => c.Email)
                .IsRequired();

            HasRequired(p => p.Contratada)
                .WithMany()
                .HasForeignKey(p => p.ContratadaId);

        }
    }
}
