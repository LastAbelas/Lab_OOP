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
        /// Поиск
        /// </summary>
        private void StartSearch()
        {
            _processeFilter.Clear();
            try
            {
                textBoxParameter.Text = textBoxParameter.Text.Replace(".", ",");
                if (SearchEqualWorkLabel.Checked)
                {
                    foreach (var row in _process)
                    {
                        //TODO: Переделать на равно - исправил и исправил дубли
                        if (row.Work == Convert.ToDouble(textBoxParameter.Text))
                        {
                            _processeFilter.Add(row);
                        }
                    }
                }
                else if (SearchLessWorkLabel.Checked)
                {
                    foreach (var row in _process)
                    {
                        if (row.Work < Convert.ToDouble(textBoxParameter.Text))
                        {
                            _processeFilter.Add(row);
                        }
                    }
                }
                else if (SearchGreaterWorkLabel.Checked)
                {
                    foreach (var row in _process)
                    {
                        if (row.Work > Convert.ToDouble(textBoxParameter.Text))
                        {
                            _processeFilter.Add(row);
                        }
                    }
                }
                else if (SearchByNameLabel.Checked)
                {
                    foreach (var row in _process)
                    {
                        if (row.NameProcess.ToString() == textBoxParameter.Text)
                        {
                            _processeFilter.Add(row);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Enter the right format for seaching!");
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
    }
}
