using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Проверки
    /// </summary>
    public static class Checker
    {
        /// <summary>
        /// Минимальная температура
        /// </summary>
        const double MINTEMPERATURE = -273;

        /// <summary>
        /// Проверка для всегда положительных величин
        /// </summary>
        /// <param name="physicalQuantity">Физическая величина</param>
        /// <returns>Физическую величину</returns>
        public static double CheckNegativValue(double physicalQuantity)
        {
            if (physicalQuantity < 0)
            {
                throw new ArgumentOutOfRangeException
                    ("Величина не может быть отрицательной! Проверьте!");
            }
            else
            {
                return physicalQuantity;
            }
        }
        /// <summary>
        /// Защита от нуля в знаменателе
        /// </summary>
        /// <param name="physicalQuantity">Физическая величина</param>
        /// <returns>Физическую величину</returns>
        public static double CheckInfinity(double physicalQuantity)
        {
            if (physicalQuantity == 0)
            {
                throw new ArgumentOutOfRangeException
                    ("Необходима бесконечная работа! Проверте!");
            }
            else
            {
                return physicalQuantity;
            }
        }

        /// <summary>
        /// Защита от неправильной температуры
        /// </summary>
        /// <param name="temperature">Физическая величина</param>
        /// <returns>Физическую величину</returns>
        public static double CheckTemperature(double temperature)
        {
            if (temperature <= MINTEMPERATURE)
            {
                throw new ArgumentOutOfRangeException
                    ("Меньше температуры в градусах нет! Проверте!");
            }
            else
            {
                return temperature;
            }
        }
    }
}
