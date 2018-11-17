using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class WaterTransport:Transport
    {
        /// <summary>
        /// якорь
        /// </summary>
        public bool anchor;

        public WaterTransport(string model, float weight, float maxSpeed, int yearIssue, bool anchor) : base(model, weight, maxSpeed, yearIssue)
        {
            this.anchor = anchor;
        }

        /// <summary>
        /// вычисление стоимости
        /// </summary>
        /// <returns></returns>
        public override float CalculateCost()
        {
            if (anchor == true)
            {
                return maxSpeed * 10;
            }
            else
            {
                return maxSpeed * 2;
            }
        }
    }
}
