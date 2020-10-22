using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.ComponentModel;
using System.Drawing;

namespace View
{
    /// <summary>
    /// Методы для GUI
    /// </summary>
    public static class MethodsForAllForms
    {
        /// <summary>
        /// Заполнение DataGridView
        /// </summary>
        /// <param name="dataGridView">таблица</param>
        /// <param name="bindingList">лист фигур</param>
        public static void LoadGrid(DataGridView dataGridView,
            BindingList<IProcessBase> bindingList)
        {
            dataGridView.ScrollBars = ScrollBars.None;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSize = false;

            dataGridView.DataSource = bindingList;

            var columns = new DataGridViewColumn[3]
            {
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NameProcess",
                    Name = "Name Process"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Work",
                    Name = "Work"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ParameteresToOutput",
                    Name = "Parametere"
                }
            };

            dataGridView.Columns.AddRange(columns);
        }

        /// <summary>
        /// Вспомогательный метод определения изменения ширины формы
        /// </summary>
        /// <param name="dataGridView">таблица</param>
        /// <returns>изменение</returns>
        public static int FallPointsSearch(DataGridView dataGridView)
        {
            int fallPoints = 0;
            foreach (DataGridViewColumn r in dataGridView.Columns)
            {
                fallPoints += r.Width;
            }
            return fallPoints;
        }

    }
}
