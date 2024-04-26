
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Managment_System_Core.Models.SharedEntity
{
    public class ParentEntity
    {
        public int Id { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreationDateTime { get; set; }


    }
}
