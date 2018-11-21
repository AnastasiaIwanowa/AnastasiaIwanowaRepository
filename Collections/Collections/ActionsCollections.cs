using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    [Info("Класс, в котором выполняются действия с коллекциями: создание списка, его сортировка по параметру и вывод отсортированнного списка")]
    public class ActionsCollections
    {
        /// <summary>
        /// год выпуска воздушного транспорта, который будет вводить с клавитуры
        /// </summary>
        public int year;

        public void Execute()
        {
            Console.WriteLine("Введите год выпуска");
            try
            {
                year = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Год выпуска может быть только числом!");
                Console.WriteLine("");
            }

            //Создание объектов воздущного транспорта
            AirTransport airTransport1 = new AirTransport("ТУ-123", 123, 459, year, 80, 300);
            AirTransport airTransport2 = new AirTransport("ТУ-456", 987, 456, 2005, 87, 300);
            AirTransport airTransport3 = new AirTransport("ТУ-789", 533, 450, 2005, 88, 340);

            //Создание объектов водного транспорта
            WaterTransport waterTransport1 = new WaterTransport("Avrora", 345, 567, 1936, true);
            WaterTransport waterTransport2 = new WaterTransport("Аляска", 200, 567, 1944, false);
            WaterTransport waterTransport3 = new WaterTransport("Клеймор", 832, 567, 2000, true);

            //Создание объектов наземного транспорта
            GroundTransport groundTransport1 = new GroundTransport("Tesla", 831, 593, 2018, 4, 102);
            GroundTransport groundTransport2 = new GroundTransport("Acura", 432, 666, 2010, 4, 102);
            GroundTransport groundTransport3 = new GroundTransport("Audi", 947, 999, 2011, 4, 100);

            //Создание списка воздущного транспорта
            List<AirTransport> airTransports = new List<AirTransport>();
            if (year > 0)
            {
                airTransports.Add(airTransport1);
            }
            airTransports.Add(airTransport2);
            airTransports.Add(airTransport3);

            //Сортировка списка воздущного транспорта по весу
            airTransports.Sort(delegate (AirTransport a1, AirTransport a2) { return a1.weight.CompareTo(a2.weight); });

            //Вывод отсортированного списка 
            foreach (AirTransport item in airTransports)
                Console.WriteLine($"{ item.model} {item.weight} {item.maxSpeed} {item.yearIssue} {item.wingspan} {item.loadCapacity}");
            Console.WriteLine("");

            //Создание списка водного транспорта
            List<WaterTransport> waterTransports = new List<WaterTransport>();
            waterTransports.Add(waterTransport1);
            waterTransports.Add(waterTransport2);
            waterTransports.Add(waterTransport3);

            //Сортировка списка воздущного транспорта по году выпуска
            waterTransports.Sort(delegate (WaterTransport w1, WaterTransport w2) { return w1.yearIssue.CompareTo(w2.yearIssue); });

            //Вывод отсортированного списка 
            foreach (WaterTransport item in waterTransports)
                Console.WriteLine($"{ item.model} {item.weight} {item.maxSpeed} {item.yearIssue} {item.anchor}");
            Console.WriteLine("");

            //Создание списка наземного транспорта
            List<GroundTransport> groundTransports = new List<GroundTransport>();
            groundTransports.Add(groundTransport1);
            groundTransports.Add(groundTransport2);
            groundTransports.Add(groundTransport3);

            //Сортировка списка наземного транспорта по максимальной скорости
            groundTransports.Sort(delegate (GroundTransport g1, GroundTransport g2) { return g1.maxSpeed.CompareTo(g2.maxSpeed); });

            //Вывод отсортированного списка 
            foreach (GroundTransport item in groundTransports)
                Console.WriteLine($"{ item.model} {item.weight} {item.maxSpeed} {item.yearIssue} {item.countWheels} {item.power}");

            Console.ReadKey();
        }
    }
}
