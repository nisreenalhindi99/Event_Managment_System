using Event_Managment_System_Core.Models.SharedEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Event_Managment_System_Core.Helper.Enum.EventManegemntSystemLookup;

namespace Event_Managment_System_Core.Models.Entity
{
    public class User:ParentEntity

    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public UserType UserType { get; set; }
        public virtual List<Booking> Booking { get; set; }
        public virtual List<Event> Events { get; set; }
        public virtual List<Volunteering_workshops> Volunteering_workshopss { get; set; }
        public virtual List<Workshop> Workshops { get; set; }
    }
}
