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
    public class BookingEntityConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Bookings");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            // FK
            builder.HasOne(x => x.Carts)
                .WithOne(x => x.Bookings)
                .HasForeignKey<Cart>(x => x.Id)
                .IsRequired();

         


            // Default Constraints
            builder.Property(x => x.DiscountAmount).HasDefaultValue(0);
            builder.Property(x => x.CreationDateTime).HasDefaultValue(DateTime.Now);

            // Required Properties
            builder.Property(x => x.Title).IsRequired(true);
            builder.Property(x => x.Price).IsRequired(true);
            builder.Property(x => x.Tax).IsRequired(true);
            builder.Property(x => x.TotalPrice).IsRequired(true);

            builder.Property(x => x.PaymentMethod).IsRequired(true);
        }
    }
}
