namespace SampleAbstract
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Flight ft = new FlightFare() { FlightNo = 11, FlightName = "AirIndia",durationinhrs=5,typedes="International" };
            ft.FlightDetails();
            ft.FareDetails();
        }
    }
}