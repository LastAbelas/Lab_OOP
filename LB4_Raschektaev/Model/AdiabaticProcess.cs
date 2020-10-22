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
    public class AdiabaticProcess : ProcessBase
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

        /// <summary>
        /// Поле способа определения работы
        /// </summary>
        private string _typeProcess;

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
                _initialVolume = Checker.CheckNegativValue(value);
                _initialVolume = Checker.CheckInfinity(value);
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
                _finalVolume = Checker.CheckNegativValue(value);
                _finalVolume = Checker.CheckInfinity(value);
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
                _pressure = Checker.CheckNegativValue(value);
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
                _heatCapacityRatio = CheckAdiabatic(value);
            }
        }

        /// <summary>
        /// Проверка показатели адиабаты
        /// </summary>
        /// <param name="heatCapacityRatio">Показатель адиабаты</param>
        /// <returns>Показатель адиабаты</returns>
        public static double CheckAdiabatic(double heatCapacityRatio)
        {
            if (heatCapacityRatio < 0)
            {
                throw new ArgumentOutOfRangeException
                    ("Величина не может быть отрицательной! Проверьте!");
            }
            else if (heatCapacityRatio < 1)
            {
                throw new ArgumentOutOfRangeException
                    ("Величина не может быть меньше 1! Проверьте!");
            }
            else if (heatCapacityRatio == 1)
            {
                throw new ArgumentOutOfRangeException
                    ("Необходима бесконечная работа! Проверьте!");
            }
            else if (heatCapacityRatio > 2)
            {
                throw new ArgumentOutOfRangeException
                    ("Величина не может быть больше 2! Проверьте!");
            }
            else
            {
                //TODO: Скобочки
                return heatCapacityRatio;
            }
        }

        /// <summary>
        /// Свойство параметров для расчете
        /// </summary>
        public Dictionary<double, string> ProcessDictionary
        {
            get
            {
                var bufferProcess = new Dictionary<double, string>();
                bufferProcess.Add(1, "Initial Volume");
                bufferProcess.Add(2, "Final Volume");
                bufferProcess.Add(3, "Pressure");
                bufferProcess.Add(4, "Heat Capacity Ratio");
                return bufferProcess;
            }
        }

        /// <summary>
        /// Свойство работы адиабаты
        /// </summary>
        public double Work
        {
            get
            {
                return Math.Abs((Pressure * InitialVolume) / (HeatCapacityRatio - 1) *
                    (1 - (Math.Pow(InitialVolume, (HeatCapacityRatio - 1)) /
                    Math.Pow(FinalVolume, (HeatCapacityRatio - 1)))));
            }
        }

        /// <summary>
        /// Свойство параметр способ расчета
        /// </summary>
        public string TypeProcess
        {
            set => _typeProcess = value;
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string NameProcess
        {
            get => "AdiabaticProcess";
        }

        /// <summary>
        /// Физические велечины
        /// </summary>
        public List<string> NamesParameteres
        {
            get
            {
                var buffer = new List<string>();
                buffer.Add("InitialVolume");
                buffer.Add("FinalVolume");
                buffer.Add("Pressure");
                buffer.Add("HeatCapacityRatio");
                return buffer;
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
        /// Вывод физических велечин
        /// </summary>
        public string ParameteresToOutput
        {
            get
            {
                string buffer = $"InitialVolume = {InitialVolume}"+
                    $"FinalVolume = {FinalVolume}"+
                    $"Pressure = {Pressure}"+
                    $"HeatCapacityRatio = {HeatCapacityRatio}";
                return buffer;
            }
        }
        #endregion
    }
}
