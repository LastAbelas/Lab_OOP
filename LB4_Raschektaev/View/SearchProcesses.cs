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
        private BindingList<IProcessBase> _process;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public SearchProcesses(BindingList<IProcessBase> process)
        {
            InitializeComponent();

            _process = process;

        }

        /// <summary>
        /// Отфильтрованный список
        /// </summary>
        private BindingList<IProcessBase> _processeFilter
            = new BindingList<IProcessBase>();


        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_Load(object sender, EventArgs e)
        {
            MethodsForAllForms.LoadGrid(
                dataGridViewProcess, _processeFilter);

            SearchByNameLabel.Checked = true;
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

            if (SearchByNameLabel.Checked)
            {
                StartSearchName();
            }
            else if (SearchEqualWorkLabel.Checked)
            {
                StartSearchWorkEqual();
            }
            else if (SearchLessWorkLabel.Checked)
            {
                StartSearchAWorkLess();
            }
            else if (SearchGreaterWorkLabel.Checked)
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
                    if (row.NameProcess.ToString() == textBoxParameter.Text)
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
            textBoxParameter.Text = textBoxParameter.Text.Replace(".", ",");
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
                MessageBox.Show($"{exception}\nEnter the number!");
            }
        }

        /// <summary>
        /// Поиск меньше
        /// </summary>
        private void StartSearchWorkGreater()
        {
            textBoxParameter.Text = textBoxParameter.Text.Replace(".", ",");
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
                MessageBox.Show($"{exception}\nEnter the number!");
            }
        }

        /// <summary>
        /// Поиск больше
        /// </summary>
        private void StartSearchAWorkLess()
        {
            textBoxParameter.Text = textBoxParameter.Text.Replace(".", ",");
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
                MessageBox.Show($"{exception}\nEnter the number!");
            }
        }

        /// <summary>
        ///  Кнопка поиск
        /// </summary>
        private void SearchALL_Click(object sender, EventArgs e)
        {
            if (textBoxParameter.Text == "")
            {
                MessageBox.Show("Please enter something");
            }
            else 
            {
                StartSearch();
            }
        }

        /// <summary>
        ///  Кнопка расширения формы
        /// </summary>
        private void Resize_Click(object sender, EventArgs e)
        {
            var fallPoint = MethodsForAllForms.FallPointsSearch(
                dataGridViewProcess);
            this.Width = 50 + fallPoint;
            int buffer = dataGridViewProcess.Width;
            dataGridViewProcess.Width = fallPoint;
            SearchALLButton.Width = SearchALLButton.Width +
                dataGridViewProcess.Width - buffer;
            ResizeButton.Width = ResizeButton.Width +
                dataGridViewProcess.Width - buffer;
            textBoxParameter.Width = textBoxParameter.Width +
                dataGridViewProcess.Width - buffer;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            fallPoint = 0;
        }
    }
}
