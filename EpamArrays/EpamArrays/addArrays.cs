using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamArrays
{
    class AddArrays
    {
        /// <summary>
        /// сложение массивов
        /// </summary>
        /// <param name="a">1 массив</param>
        /// <param name="b">2 массив</param>
        /// <returns>результирующий массив</returns>
        
        public float[,] addArr(float[,] a, float[,] b, int n, int m)
        {
            float[,] c = new float[n, m];
            for (int i=0; i<n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            return c;
        }
    }
}
