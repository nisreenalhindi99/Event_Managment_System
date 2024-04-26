using Event_Managment_System_Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Managment_System_Core.Models.EntityConfiguration
{
    public class CartEntityConfiguration : IEntityTypeConfiguration<Cart>
    {
 

        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");

            //primary key 
            builder.HasKey(x => x.Id); // adding primary key 
            builder.Property(x => x.Id).UseIdentityColumn(); // applaying auto increment      

            //check 
            builder.ToTable(x => x.HasCheckConstraint("CH_Cart_AddingDate", "CreatedDate >= sysdatetime()"));
            builder.Property(x => x.Status).IsRequired(true);

            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreationDateTime).HasDefaultValue(DateTime.Now);
        }
    }
}
