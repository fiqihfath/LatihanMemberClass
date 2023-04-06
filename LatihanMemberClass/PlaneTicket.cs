using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    public class PlaneTicket
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int Cost { get; set; }
        public string Currency { get; set; }

        public void PrintSummary()
        {
            Console.WriteLine("Origin : {0}", Origin);
            Console.WriteLine("Destination : {0}", Destination);
            Console.WriteLine("Cost : {0} {1}", Cost, Currency);
            if (Currency == "USD") {
                Console.WriteLine("Convert to rupiah : {0}", Cost * 15000);
            }else if(Currency == "IDR")
            {
                Console.WriteLine("Convert to dolar : {0}", Cost / 15000);
            }
        }

      
    }
}
