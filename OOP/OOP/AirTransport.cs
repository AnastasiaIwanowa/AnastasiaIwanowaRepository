using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class AirTransport:Transport
    {
        /// <summary>
        /// размах крыльев
        /// </summary>
        public float wingspan;
        /// <summary>
        /// грузоподъемность
        /// </summary>
        public float loadCapacity;

        public AirTransport(string model, float weight, float maxSpeed, int yearIssue, float wingspan, float loadCapacity):base(model, weight, maxSpeed, yearIssue)
        {
            this.wingspan = wingspan;
            this.loadCapacity = loadCapacity;
        }

        /// <summary>
        /// вычисление стоимости
        /// </summary>
        /// <returns></returns>
        /// 
        public override float CalculateCost()
        {
            return maxSpeed * wingspan * loadCapacity / 100;
        }
    }
}
