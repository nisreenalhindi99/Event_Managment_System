using Event_Managment_System_Core.Models.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Managment_System_Core.Models.Entity
{
    public class Event:ParentEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public virtual User Users { get; set; }
        public virtual List<Booking> Bookings { get; set; }
        public virtual List<CartItem> CartItems { get; set; }
    }
}
