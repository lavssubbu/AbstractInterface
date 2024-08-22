using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAbstract
{
    internal class FlightFare : Flight
    {
        public decimal BasicFare { get; private set; }
        public int durationinhrs { get; set; }
        public string typedes { get; set; }
        public override void FareDetails()
        {
            if(durationinhrs > 4)
            {
                BasicFare = 8000;
            }
            else
            {
                BasicFare = 5000;
            }
            if(typedes.ToLower().Equals("international"))
            {
                BasicFare += 3000;
            }
            Console.WriteLine($"BasicFare:{BasicFare}");
        }
    }
}
