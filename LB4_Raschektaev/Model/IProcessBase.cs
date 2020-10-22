using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Базовый класс Процессов
    /// </summary>
    public interface IProcessBase
    {
        /// <summary>
        /// Название процессов
        /// </summary>
        public ProcessName NameProcess { get; }

        /// <summary>
        /// Термодинамическая работа
        /// </summary>
        public double Work { get; }

        /// <summary>
        /// Словарь типов исходных данных
        /// </summary>
        public Dictionary<double, string> ProcessDictionary { get; }

        /// <summary>
        /// Параметры физических велечин
        /// </summary>
        public string ParameteresToOutput { get; }

        /// <summary>
        /// Значения физических велечин
        /// </summary>
        public List<double> ValuesParameteres { set; }
    }
}
