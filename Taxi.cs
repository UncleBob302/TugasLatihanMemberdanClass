using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Taxi
    {
        // properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("DriverName; {0}", DriverName);
            Console.WriteLine("OnDuty; {0}", OnDuty);
            Console.WriteLine("NumPassenger; {0}", NumPassenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("Jono sedang menjemput penumpang");
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("Jono selesai mengantar penumpang");
        }


    }
}
