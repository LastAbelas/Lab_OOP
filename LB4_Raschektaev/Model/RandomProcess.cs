using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Создание случайного процесса
    /// </summary>
    public static class RandomProcess
    {
        /// <summary>
        /// Поле рандома
        /// </summary>
        private static Random _random = new Random();

        public static ProcessBase ExploreProcess()
        {
            ProcessBase process = new AdiabaticProcess();

            int typeProcess = _random.Next(0, 3);

            if (typeProcess == 0)
            {
                process = new IsobaricProcess();
                process.TypeProcess = "IsobaricProcess";
                List<double> buffer = new List<double>();
                buffer.Add(_random.Next(1, 100));
                buffer.Add(_random.Next(1, 100));
                buffer.Add(_random.Next(1, 100));
                buffer.Add(_random.Next(1, 100));
                process.ValuesParameteres = buffer;
            }

            if (typeProcess == 1)
            {
                process = new IsothermalProcess();
                process.TypeProcess = "IsothermalProcess";
                List<double> buffer = new List<double>();
                buffer.Add(_random.Next(1, 100));
                buffer.Add(_random.Next(1, 100));
                buffer.Add(_random.Next(1, 100));
                buffer.Add(_random.Next(1, 100));
                buffer.Add(_random.Next(1, 100));
                process.ValuesParameteres = buffer;
            }

            if (typeProcess == 2)
            {
                process = new AdiabaticProcess();
                process.TypeProcess = "AdiabaticProcess";
                List<double> buffer = new List<double>();
                buffer.Add(_random.Next(1, 100));
                buffer.Add(_random.Next(1, 100));
                buffer.Add(_random.Next(1, 100));
                buffer.Add(1.5);
                process.ValuesParameteres = buffer;
            }

            return process;

        }
    }
}
