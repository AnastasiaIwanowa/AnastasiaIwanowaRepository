using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            AirTransport airTransport = new AirTransport("ТУ-123", 123, 456, 2005, 80, 300);
            WaterTransport waterTransport = new WaterTransport("avrora", 345, 567, 1936, true);
            GroundTransport groundTransport = new GroundTransport("Tesla", 432, 666, 2018, 4, 102);

            Console.WriteLine(airTransport.CalculateCost());
            Console.WriteLine(waterTransport.CalculateCost());
            Console.WriteLine(groundTransport.CalculateCost());

            Console.ReadKey();
        }
    }
}
