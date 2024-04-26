using Event_Managment_System_Core.Models.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Managment_System_Core.Models.EntityConfiguration
{
    public class VolunteringworkshopEntityConfiguration : IEntityTypeConfiguration<Volunteering_workshops>
    {
        public void Configure(EntityTypeBuilder<Volunteering_workshops> builder)
        {
            builder.ToTable("Voluntering_workshops");
            //primary key 
            builder.HasKey(x => x.Id); // adding primary key 
            builder.Property(x => x.Id).UseIdentityColumn(); // applaying auto increment
            //  null constraint (Optional)
            builder.Property(x => x.Description).IsRequired(true);
            builder.Property(x => x.Price).IsRequired(false);

            //set fixed size for string property 
            builder.Property(x => x.Name).HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(150);

            //check 

           
            builder.ToTable(x => x.HasCheckConstraint("CH_Item__Description", "LEN(Description) >0 "));

         
           
        }
    }
}


