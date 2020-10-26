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
        /// <param name="parameter">Имя величины</param>
        /// <returns>Физическую величину</returns>
        public static double CheckNegativValue(double physicalQuantity,
            string parameter)
        {
            if (physicalQuantity < 0)
            {
                throw new ArgumentOutOfRangeException
                    (parameter, " -  quantity cannot be negative! Check it out!");
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
        /// <param name="parameter">Имя величины</param>
        /// <returns>Физическую величину</returns>
        public static double CheckInfinity(double physicalQuantity, 
            string parameter)
        {
            if (physicalQuantity == 0)
            {
                throw new ArgumentOutOfRangeException(parameter,
                    parameter + " cannot be zero!");
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
        /// <param name="parameter">Имя величины</param>
        /// <returns>Физическую величину</returns>
        public static double CheckTemperature(double temperature,
            string parameter)
        {
            if (temperature <= MINTEMPERATURE)
            {
                throw new ArgumentOutOfRangeException
                    (parameter, parameter + " - Less temperature " +
                    "not in degrees! Check it out!");
            }
            else
            {
                return temperature;
            }
        }
    }
}
