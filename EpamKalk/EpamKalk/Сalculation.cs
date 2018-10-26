using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamKalk
{
    class Сalculation
    {
        /// <summary>
        /// первое число
        /// </summary>
        public float a;
        /// <summary>
        /// второе число
        /// </summary>
        public float b;
        /// <summary>
        /// результат вычисления
        /// </summary>
        public float c;

        /// <summary>
        /// Сложить
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float add(float a, float b)
        {
            return c = a + b;
        }
        /// <summary>
        /// Вычесть
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float sub(float a, float b)
        {
            return c = a - b;
        }
        /// <summary>
        /// Умножить
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float mult(float a, float b)
        {
            return c = a * b;
        }
        /// <summary>
        /// Разделить
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public float div(float a, float b)
        {
            return c = a / b;
        }
    }
}
