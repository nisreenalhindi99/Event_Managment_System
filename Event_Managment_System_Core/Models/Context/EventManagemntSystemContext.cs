using Event_Managment_System_Core.Models.Entity;
using Event_Managment_System_Core.Models.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Managment_System_Core.Models.Context
{
    public class EventManagemntSystemContext:DbContext
    {
        public EventManagemntSystemContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BookingEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CartEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CartItemEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EventEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new VolunteringworkshopEntityConfiguration());
            modelBuilder.ApplyConfiguration(new WorkshopEntityConfiguration());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Cart> carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Workshop> Workshops { get; set; }
        public virtual DbSet<Volunteering_workshops> Volunteering_workshopss { get; set; }

    }
}

