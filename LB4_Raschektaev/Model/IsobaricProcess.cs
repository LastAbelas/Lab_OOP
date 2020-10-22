using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс описывающий работу изобарного процесса
    /// </summary>
    [Serializable]
    public class IsobaricProcess : ProcessBase
    {
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
        /// начальная температура
        /// </summary>
        private double _initialTemperature;

        /// <summary>
        /// конечная температура
        /// </summary>
        private double _finalTemperature;

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
        /// Свойство Начальной температуры
        /// </summary>
        public double InitialTemperature
        {
            get
            {
                return _initialTemperature;
            }
            set
            {
                _initialTemperature = Checker.CheckTemperature(value);
            }
        }

        /// <summary>
        /// Свойство Конечной температуры
        /// </summary>
        public double FinalTemperature
        {
            get
            {
                return _finalTemperature;
            }
            set
            {
                _finalTemperature = Checker.CheckTemperature(value);
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
        /// Расчет работы изобары
        /// </summary>
        public double Work
        {
            get
            {
                return Math.Abs((GasMass * GASCONSTANT * (FinalTemperature -
                    InitialTemperature) / MolarMass));
            }
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string NameProcess
        {
            get => "IsobaricProcess";
        }

        /// <summary>
        /// Свойство параметров для расчете
        /// </summary>
        public Dictionary<double, string> ProcessDictionary
        {
            get
            {
                var bufferProcess = new Dictionary<double, string>();
                bufferProcess.Add(1, "Initial Temperature");
                bufferProcess.Add(2, "Final Temperature");
                bufferProcess.Add(3, "Gas Mass");
                bufferProcess.Add(4, "Molar Mass");
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
                buffer.Add("InitialTemperature");
                buffer.Add("FinalTemperature");
                buffer.Add("GasMass");
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
                InitialTemperature = buffer[0];
                FinalTemperature = buffer[1];
                GasMass = buffer[2];
                MolarMass = buffer[3];
            }
        }

        /// <summary>
        /// Вывод физических велечин
        /// </summary>
        public string ParameteresToOutput
        {
            get
            {
                string buffer = $"InitialTemperature = {InitialTemperature}"+
                    $"FinalTemperature = {FinalTemperature}"
                    +$"GasMass = {GasMass}"+ $"MolarMass = {MolarMass}";
                return buffer;
            }
        }
    }
}
