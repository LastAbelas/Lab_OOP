using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс описывающий работу изотермического процесса
    /// </summary>
    [Serializable]
    public class IsothermalProcess : ProcessBase
    {
        /// <summary>
        /// Начальный объем
        /// </summary>
        private double _initialVolume;

        /// <summary>
        /// Конечный объем
        /// </summary>
        private double _finalVolume;

        /// <summary>
        /// Универсальная гаовая постоянная
        /// </summary>
        public const double GASCONSTANT = 8.314;

        /// <summary>
        /// масса газа
        /// </summary>
        private double _gasMass;

        /// <summary>
        /// молярная масса
        /// </summary>
        private double _molarMass;

        /// <summary>
        /// Поле типа процесса 
        /// </summary>
        private string _typeProcesses;

        /// <summary>
        /// Свойство вида процесса
        /// </summary>
        public string TypeProcess
        {
            set => _typeProcesses = value;
        }

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
        /// свойство массы газа
        /// </summary>
        public double GasMass
        {
            get
            {
                return _gasMass;
            }
            set
            {
                _gasMass = Checker.CheckNegativValue(value);
            }
        }

        /// <summary>
        /// свойство молярной массы
        /// </summary>
        public double MolarMass
        {
            get
            {
                return _molarMass;
            }
            set
            {
                _molarMass = Checker.CheckNegativValue(value);
            }
        }

        /// <summary>
        ///  температура
        /// </summary>
        private double _temperature;

        /// <summary>
        /// Свойство температуры
        /// </summary>
        public double Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = Checker.CheckTemperature(value);
            }
        }
        /// <summary>
        /// Расчет работы изотермы
        /// </summary>
        public double Work
        {
            get
            {
                return Math.Abs((GasMass * GASCONSTANT * Temperature *
                                 Math.Log(FinalVolume / InitialVolume))
                                 / MolarMass);
            }
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string NameProcess
        {
            get => "IsothermalProcess";
        }

        /// <summary>
        /// Свойство параметров для расчете
        /// </summary>
        public Dictionary<double, string> ProcessDictionary
        {
            get
            {
                var bufferProcess = new Dictionary<double, string>();
                bufferProcess.Add(1, "Gas Mass");
                bufferProcess.Add(2, "Temperature");
                bufferProcess.Add(3, "Initial Volume");
                bufferProcess.Add(4, "Final Volume");
                bufferProcess.Add(5, "Molar Mass");
                return bufferProcess;
            }
        }

        /// <summary>
        /// Физические велечины
        /// </summary>
        public List<string> NamesParameteres
        {
            get
            {
                var buffer = new List<string>();
                buffer.Add("GasMass");
                buffer.Add("Temperature");
                buffer.Add("InitialVolume");
                buffer.Add("FinalVolume");
                buffer.Add("MolarMass");
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
                GasMass = buffer[0];
                Temperature = buffer[1];
                InitialVolume = buffer[2];
                FinalVolume = buffer[3];
                MolarMass = buffer[4];
            }
        }

        /// <summary>
        /// Вывод физических велечин
        /// </summary>
        public string ParameteresToOutput
        {
            get
            {
                string buffer = $"GasMass = {GasMass}"+
                    $"Temperature = {Temperature}"+
                    $"InitialVolume = {InitialVolume}"+
                    $"FinalVolume = {FinalVolume}"+ 
                    $"MolarMass = {MolarMass}";
                return buffer;
            }
        }
    }
}
