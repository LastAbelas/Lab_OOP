using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс описывающий работу адиабатного процесса
    /// </summary>
    [Serializable]
    public class AdiabaticProcess : IProcessBase
    {
        #region Поля физических велечин

        /// <summary>
        /// Начальный объем
        /// </summary>
        private double _initialVolume;

        /// <summary>
        /// Конечный объем
        /// </summary>
        private double _finalVolume;

        /// <summary>
        /// Давление
        /// </summary>
        private double _pressure;


        #endregion

        #region Свойства Физических велечин

        /// <summary>
        /// Свойство начального объема
        /// </summary>
        public double InitialVolume
        {
            get
            {
                return _initialVolume;
            }
            set
            {
                _initialVolume = Checker.CheckNegativValue(value,
                    nameof(InitialVolume));
                _initialVolume = Checker.CheckInfinity(value,
                    nameof(InitialVolume));
            }
        }

        /// <summary>
        /// Свойство конечного объема
        /// </summary>
        public double FinalVolume
        {
            get
            {
                return _finalVolume;
            }
            set
            {
                _finalVolume = Checker.CheckNegativValue(value, 
                    nameof(FinalVolume));
                _finalVolume = Checker.CheckInfinity(value, 
                    nameof(FinalVolume));
            }
        }

        /// <summary>
        /// Свойство давления
        /// </summary>
        public double Pressure
        {
            get
            {
                return _pressure;
            }
            set
            {
                _pressure = Checker.CheckInfinity(value,
                    nameof(Pressure));
                _pressure = Checker.CheckNegativValue(value,
                    nameof(Pressure));
            }
        }

        /// <summary>
        /// Показатель адиабаты
        /// </summary>
        private double _heatCapacityRatio;

        /// <summary>
        /// Свойство Показателя адиабаты
        /// </summary>
        public double HeatCapacityRatio
        {
            get
            {
                return _heatCapacityRatio;
            }
            set
            {
                _heatCapacityRatio = CheckAdiabatic(value,
                    nameof(HeatCapacityRatio));
            }
        }

        /// <summary>
        /// Проверка показатели адиабаты
        /// </summary>
        /// <param name="heatCapacityRatio">Показатель адиабаты</param>
        /// <param name="paramName">Имя параметра</param>
        /// <returns>Показатель адиабаты</returns>
        /// TODO: XML - решено
        public static double CheckAdiabatic(double heatCapacityRatio,
            string paramName)
        {
            if (heatCapacityRatio < 0)
            {
                throw new ArgumentOutOfRangeException
                (paramName, paramName + " - quantity cannot be negative!" +
                " Check!");
            }
            else if (heatCapacityRatio < 1)
            {
                throw new ArgumentOutOfRangeException
                (paramName, paramName + " - value cannot be less than 1!" +
                " Check!");
            }
            else if (heatCapacityRatio == 1)
            {
                throw new ArgumentOutOfRangeException
                    (paramName, paramName + "- Endless work required!" +
                    " Check!");
            }
            else if (heatCapacityRatio > 2)
            {
                throw new ArgumentOutOfRangeException
                    (paramName, paramName + " - value cannot be more than 2!" +
                    " Check!");
            }
            else
            {
                return heatCapacityRatio;
            }
        }

        /// <summary>
        /// Лист значений физических велечин
        /// </summary>
        public List<double> ValuesParameteres
        {
            set
            {
                var buffer = value;
                InitialVolume = buffer[0];
                FinalVolume = buffer[1];
                Pressure = buffer[2];
                HeatCapacityRatio = buffer[3];
            }
        }

        /// <summary>
        /// Свойство параметров для расчете
        /// </summary>
        public Dictionary<double, string> ProcessDictionary
        {
            get
            {
                var bufferProcess = new Dictionary<double, string>
                {
                    {1, "Initial Volume"}, 
                    {2, "Final Volume"}, 
                    {3, "Pressure"}, 
                    {4, "Heat Capacity Ratio"}
                };
                return bufferProcess;
            }
        }

        /// <summary>
        /// Свойство работы адиабаты
        /// </summary>
        public double Work =>
            Math.Abs(Math.Round((Pressure * InitialVolume)
                                / (HeatCapacityRatio - 1) *
                                (1 - (Math.Pow(InitialVolume, (HeatCapacityRatio - 1)) /
                                      Math.Pow(FinalVolume, (HeatCapacityRatio - 1))))));

        /// <summary>
        /// Имя
        /// </summary>
        public ProcessName NameProcess
        {
            get => ProcessName.AdiabaticProcess;
        }

        /// <summary>
        /// Физические велечины
        /// </summary>
        public List<string> NamesParameteres
        {
            get
            {
                var buffer = new List<string>
                {
                    "InitialVolume", 
                    "FinalVolume", 
                    "Pressure", 
                    "HeatCapacityRatio"
                };
                return buffer;
            }
        }
        /// <summary>
        /// Вывод физических велечин
        /// </summary>
        public string ParameteresToOutput
        {
            get
            {
                string buffer = $"InitialVolume = {InitialVolume}, "+
                    $"FinalVolume = {FinalVolume}, "+
                    $"Pressure = {Pressure}, "+
                    $"HeatCapacityRatio = {HeatCapacityRatio}";
                return buffer;
            }
        }
        #endregion
    }
}
