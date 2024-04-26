using Event_Managment_System_Core.Models.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Managment_System_Core.Models.Entity
{
    public class CartItem:ParentEntity
    {
        public virtual Booking Bookings { get; set; }
        public string Note { get; set; } = string.Empty;
        public virtual Event Events { get; set; }
        public virtual Workshop Workshops { get; set; }
        public virtual Volunteering_workshops Volunteering_workshopss { get; set; }
    }
}
