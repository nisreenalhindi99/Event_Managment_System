using Event_Managment_System_Core.Models.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Event_Managment_System_Core.Helper.Enum.EventManegemntSystemLookup;

namespace Event_Managment_System_Core.Models.Entity
{
    public class Booking:ParentEntity
    {

        public string Title { get; set; }
        public float Price { get; set; }
        public float Tax { get; set; }
        public float DiscountAmount { get; set; }
        public float TotalPrice { get; set; }
        public string ?PromoCode { get; set; }
     
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime BookDate { get; set; }
        public string TicketSerialNumber { get; set; }
  
        public virtual Cart Carts { get; set; }

        public virtual User Users { get; set; }

     
        public virtual Event? Events { get; set; }
     
        public virtual Workshop? Workshops { get; set; }
        public virtual Volunteering_workshops? Volunteering_Workshopss { get; set; }

    }

}
