using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Transport
    {
        /// <summary>
        /// модель
        /// </summary>
        public string model;
        /// <summary>
        /// вес
        /// </summary>
        public float weight;
        /// <summary>
        /// максимальная скорость
        /// </summary>
        public float maxSpeed;
        /// <summary>
        /// год выпуска
        /// </summary>
        public int yearIssue;
        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="model"></param>
        /// <param name="weight"></param>
        /// <param name="maxSpeed"></param>
        /// <param name="yearIssue"></param>
        protected Transport(string model, float weight, float maxSpeed, int yearIssue)
        {
            this.model = model;
            this.weight = weight;
            this.maxSpeed = maxSpeed;
            this.yearIssue = yearIssue;
        }

        /// <summary>
        /// вычисление стоимости
        /// </summary>
        /// <returns></returns>
        abstract public float CalculateCost();

    }
}
