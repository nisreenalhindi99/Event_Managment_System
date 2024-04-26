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
    public class EventEntityConfiguration: IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");
            //primary key 
            builder.HasKey(x => x.Id); // adding primary key 
            builder.Property(x => x.Id).UseIdentityColumn(); // applaying auto increment
            //  null constraint (Optional)
            builder.Property(x => x.Description).IsRequired(true);

            //set fixed size for string property 
            builder.Property(x => x.Name).HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(150);

            //check 

            builder.ToTable(x => x.HasCheckConstraint("CH_Item__price", "LEN(Price) >0 "));
            builder.ToTable(x => x.HasCheckConstraint("CH_Item__Description", "LEN(Description) >0 "));

            //default 
            builder.Property(x => x.Price).HasDefaultValue(5);
        }
    }
}

