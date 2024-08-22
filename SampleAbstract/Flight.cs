using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAbstract
{
   abstract class Flight
    {
        public int FlightNo { get; set; }
        public string FlightName { get; set; }

        public void FlightDetails()
        {
            Console.WriteLine($"FlightNo:{FlightNo}, FlightName:{FlightName}");
        }
        public abstract void FareDetails();
    }
    
}
