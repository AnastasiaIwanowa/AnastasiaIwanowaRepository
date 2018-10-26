using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamArrays
{
    class ActionsArrays
    {
        /// <summary>
        /// количество строк
        /// </summary>
        public int n;
        /// <summary>
        /// количество столбцов
        /// </summary>
        public int m;
        /// <summary>
        /// первый массив
        /// </summary>
        public float[,] a;
        /// <summary>
        /// второй массив
        /// </summary>
        public float[,] b;
        /// <summary>
        /// результирующий массив
        /// </summary>
        public float[,] c;

        /// <summary>
        /// 
        /// </summary>
        public void executeActions()
        {
            Console.WriteLine("Введите число строк");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите первый массив");
            float[,] a = new float[n, m];
            a =inputArray(n, m);
            outputArray(a);

            Console.WriteLine("Введите второй массив");
            float[,] b = new float[n, m];
            b = inputArray(n, m);
            outputArray(b);

            Console.WriteLine("Результирующий массив");
            float[,] c = new float[n, m];
            AddArrays addArrays = new AddArrays();
            c = addArrays.addArr(a, b, n, m);
            outputArray(c);

            Console.ReadKey();
        }

        public float[,] inputArray(int n, int m)
        {
            float[,] arr = new float[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("a[{0}][{1}]=", i + 1, j + 1);
                    arr[i, j] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return arr;
        }

        public void outputArray(float[,] arr)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(String.Format("{0,3}", arr[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
