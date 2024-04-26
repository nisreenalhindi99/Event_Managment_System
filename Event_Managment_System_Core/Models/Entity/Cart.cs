using Event_Managment_System_Core.Models.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Event_Managment_System_Core.Helper.Enum.EventManegemntSystemLookup;

namespace Event_Managment_System_Core.Models.Entity
{
    public class Cart:ParentEntity

    {
        public Status Status { get; set; }
        public virtual User Users { get; set; }
        public virtual Booking Bookings { get; set; }
        public virtual List<CartItem> CartItems { get; set; }
    }
}
