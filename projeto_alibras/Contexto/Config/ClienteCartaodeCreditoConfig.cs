using projeto_alibras.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_alibras.Contexto.Config
{
    internal class ClienteCartaodeCreditoConfig : EntityTypeConfiguration<ClienteCartaodeCredito>
    {
        public ClienteCartaoCreditoConfig()
        {
            ToTable("T_CLIENTECARTAOCREDITO");


            Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();

            Property(x => x.Status)
                .HasColumnName("Status")
                .IsRequired();

            Property(x => x.ClienteId)
                .HasColumnName("Cliente_id")
                .IsRequired();

            HasRequired(x => x.Cliente)
                .WithMany(x => x.CartaodeCreditos)
                .HasForeignKey(x => x.ClienteId);

        }
    }

}
