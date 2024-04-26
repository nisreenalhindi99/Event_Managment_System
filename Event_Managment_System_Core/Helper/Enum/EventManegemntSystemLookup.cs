using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Managment_System_Core.Helper.Enum
{
    public class EventManegemntSystemLookup
    {
        public enum PaymentMethod
        {
            PayPal = 101,
            Visa = 102,
            Cash = 103,
            Wallet = 106
        }


        public enum UserType
        {
            Admin,
            Stuff,
            Student
        }

        public enum Status
        {
            Canceled,
            Perparing,
            Pending,
            Completed,
            Rejected
        }

    }
}

