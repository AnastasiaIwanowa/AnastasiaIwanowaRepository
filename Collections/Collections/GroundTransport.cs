using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class GroundTransport:Transport
    {
        /// <summary>
        /// количество колес
        /// </summary>
        public int countWheels;
        /// <summary>
        /// мощность
        /// </summary>
        public float power;

        public GroundTransport(string model, float weight, float maxSpeed, int yearIssue, int countWheels, float power) : base(model, weight, maxSpeed, yearIssue)
        {
            this.countWheels = countWheels;
            this.power = power;
        }

        /// <summary>
        /// вычисление стоимости
        /// </summary>
        /// <returns></returns>
        public override float CalculateCost()
        {
            return power * countWheels * 2.6f;
        }
    }
}
