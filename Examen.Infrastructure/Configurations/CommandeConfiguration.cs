using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class CommandeConfiguration : IEntityTypeConfiguration<Commande>
    {
        public void Configure(EntityTypeBuilder<Commande> builder)
        {
            builder.HasOne(x => x.livreur)
                .WithMany(x => x.Commandes)
                .HasForeignKey(x => x.LivreurFK);


  
        }
    }
}
