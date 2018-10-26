using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamKalk
{
    class Сalculator
    {
        public string result;
        public void calculate()
        {
            do
            {
                Console.WriteLine("Введите первое число");
                string sa= Console.ReadLine();
                float a = float.Parse(sa);
                Console.WriteLine("Введите второе число");
                string sb = Console.ReadLine();
                float b = float.Parse(sb);
                Console.WriteLine("Введите номер операции");
                Console.WriteLine("1, если хотите сложить числа");
                Console.WriteLine("2, если хотите вычесть числа");
                Console.WriteLine("3, если хотите умножить числа");
                Console.WriteLine("4, если хотите разделить числа");
                string snumber = Console.ReadLine();
                int number = int.Parse(snumber);
                //int operations = 4;
                Сalculation сalculation = new Сalculation();
                switch (number)
                {
                    case 1:
                        //Сalculation сalculation = new Сalculation();
                        float cadd = сalculation.add(a, b);
                        Console.WriteLine("Результат сложения = {0}", cadd);
                        break;
                    case 2:
                        //Сalculation сalculation = new Сalculation();
                        float csub = сalculation.sub(a, b);
                        Console.WriteLine("Результат вычитания = {0}", csub);
                        break;
                    case 3:
                        float cmult = сalculation.mult(a, b);
                        Console.WriteLine("Результат умножения = {0}", cmult);
                        break;
                    case 4:
                        if (b == 0)
                        {
                            Console.WriteLine("Нельзя делить на 0!");
                        }
                        else
                        {
                            float cdiv = сalculation.div(a, b);
                            Console.WriteLine("Результат деления = {0}", cdiv);
                        }
                        break;
                    default:
                        Console.WriteLine("Неверная операция");
                        break;
                }
                Console.WriteLine("Сделать новый расчет или выйти? y/n?");
                result = Console.ReadLine();
            } while (result=="y");
        }
        
        
    }
}
