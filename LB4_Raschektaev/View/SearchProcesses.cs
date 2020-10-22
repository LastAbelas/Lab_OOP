using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class SearchProcesses : Form
    {
        /// <summary>
        /// Лист процессов
        /// </summary>
        private BindingList<ProcessBase> _process;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public SearchProcesses(BindingList<ProcessBase> process)
        {
            InitializeComponent();

            _process = process;

        }

        /// <summary>
        /// Отфильтрованный список
        /// </summary>
        private BindingList<ProcessBase> _processeFilter
            = new BindingList<ProcessBase>();


        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_Load(object sender, EventArgs e)
        {
            MethodsForAllForms.LoadGrid(
                dataGridViewProcess, _processeFilter);

            SearchByName.Checked = true;
        }

        /// <summary>
        /// Искать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchProcesscs_Load(object sender, EventArgs e)
        {
            StartSearch();
        }

        /// <summary>
        /// Поиск
        /// </summary>
        private void StartSearch()
        {
            _processeFilter.Clear();

            if (SearchByName.Checked)
            {
                StartSearchName();
            }
            else if (SearchEqualWork.Checked)
            {
                StartSearchWorkEqual();
            }
            else if (SearchLessWork.Checked)
            {
                StartSearchAWorkLess();
            }
            else if (SearchGreaterWork.Checked)
            {
                StartSearchWorkGreater();
            }

        }

        /// <summary>
        /// Поиск по имени
        /// </summary>
        private void StartSearchName()
        {
            try
            {
                foreach (var row in _process)
                {
                    if (row.NameProcess == textBoxParameter.Text)
                    {
                        _processeFilter.Add(row);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception}\nEnter the string!");
            }
        }

        /// <summary>
        /// Поиск равно
        /// </summary>
        private void StartSearchWorkEqual()
        {
            try
            {
                foreach (var row in _process)
                {
                    if (row.Work <=
                        1.05 * Convert.ToDouble(textBoxParameter.Text) &
                        row.Work >=
                        0.95 * Convert.ToDouble(textBoxParameter.Text))
                    {
                        _processeFilter.Add(row);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception}\nEnter the string!");
            }
        }

        /// <summary>
        /// Поиск меньше
        /// </summary>
        private void StartSearchAWorkLess()
        {
            try
            {
                foreach (var row in _process)
                {
                    if (row.Work > Convert.ToDouble(textBoxParameter.Text))
                    {
                        _processeFilter.Add(row);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception}\nEnter the string!");
            }
        }

        /// <summary>
        /// Поиск больше
        /// </summary>
        private void StartSearchWorkGreater()
        {
            try
            {
                foreach (var row in _process)
                {
                    if (row.Work < Convert.ToDouble(textBoxParameter.Text))
                    {
                        _processeFilter.Add(row);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception}\nEnter the string!");
            }
        }

        private void SearchALL_Click(object sender, EventArgs e)
        {
            StartSearch();
        }
    }
}
