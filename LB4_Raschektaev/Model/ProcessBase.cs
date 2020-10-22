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
    public interface ProcessBase
    {
        /// <summary>
        /// Название процессов
        /// </summary>
        public string NameProcess { get; }

        /// <summary>
        /// Термодинамическая работа
        /// </summary>
        public double Work { get; }

        /// <summary>
        /// Словарь типов исходных данных
        /// </summary>
        public Dictionary<double, string> ProcessDictionary { get; }

        /// <summary>
        /// Тип исходных данных
        /// </summary>
        public string TypeProcess { set; }

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
