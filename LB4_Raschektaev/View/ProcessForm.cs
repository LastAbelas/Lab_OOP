using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Model;


namespace View
{
    public partial class ProcessForm : Form
    {
        /// <summary>
        /// Главная форма
        /// </summary>
        public ProcessForm()
        {
            InitializeComponent();
            dataGridViewProcessesWork.ScrollBars = ScrollBars.None;
            dataGridViewProcessesWork.MouseWheel 
                += new MouseEventHandler(DataGridView1_MouseWheel);

            #if !DEBUG
            Random.Visible = false;
            #endif
        }

        /// <summary>
        /// Загрузка данный при открытии формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessForm_Load(object sender, EventArgs e)
        {
            MethodsForAllForms.LoadGrid(dataGridViewProcessesWork, _process);
        }

        /// <summary>
        /// Основной лист процессов
        /// </summary>
        private static BindingList<ProcessBase> _process =
            new BindingList<ProcessBase>();

        private void dataGridViewProcessesWork_CellContentClick
            (object sender, DataGridViewCellEventArgs e)
        {
            
        }

        /// <summary>
        /// Сохранение файла процессов
        /// </summary>
        private void Save_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "processeswork" +
                    "(*.pro)|*.pro|All files (*.*)|*.*";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Title = "Save Processes Information";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var formatter = new BinaryFormatter();
                var fileSave = saveFileDialog.FileName;
                using (var fileStream = new FileStream(
                    fileSave, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fileStream, _process);
                    MessageBox.Show("File saved!");
                }
            }
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            MethodsForAllForms.LoadGrid(dataGridViewProcessesWork, _process);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Загрузка файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "pro файлы (*.pro)|*.pro*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Title = "Load Processes Information";
            var forbinary = new BinaryFormatter();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (Path.GetExtension(filePath) == ".pro")
                {
                    try
                    {
                        using (var fileStream = new FileStream(
                            filePath, FileMode.OpenOrCreate))
                        {
                            var newprocess = (BindingList<ProcessBase>)
                                forbinary.Deserialize(fileStream);

                            _process.Clear();

                            foreach (var process in newprocess)
                            {
                                _process.Add(process);
                            }

                            MessageBox.Show("file uploaded successfully!");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("File is corrupted, unable to load!");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect file format!");
                }
            }
        }

        /// <summary>
        /// Фокус на листе
        /// </summary>
        private void DataGridView1_MouseEnter(object sender, EventArgs e)
        {
            dataGridViewProcessesWork.Focus();
        }

        /// <summary>
        /// Прокрутка мыши по листе
        /// </summary>
        private void DataGridView1_MouseWheel(object sender, MouseEventArgs e)
        {
            int currentIndex = this.dataGridViewProcessesWork.FirstDisplayedScrollingRowIndex;
            int scrollLines = SystemInformation.MouseWheelScrollLines;

            if (e.Delta > 0)
            {
                this.dataGridViewProcessesWork.FirstDisplayedScrollingRowIndex = 
                    Math.Max(0, currentIndex - scrollLines);
            }
            else if (e.Delta < 0)
            {
                if (this.dataGridViewProcessesWork.Rows.Count >
                    (currentIndex + scrollLines))
                {
                    this.dataGridViewProcessesWork.FirstDisplayedScrollingRowIndex =
                        currentIndex + scrollLines;
                }   
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow processDelete in dataGridViewProcessesWork.SelectedRows)
            {
                dataGridViewProcessesWork.Rows.Remove(processDelete);
            }
        }

        /// <summary>
        /// Вызов кнопки рандома
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Random_Click(object sender, EventArgs e)
        {
            _process.Add(Model.RandomProcess.ExploreProcess());
        }

        /// <summary>
        /// Вызов формы добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Click(object sender, EventArgs e)
        {
            var process = new AddProceses(_process);
            process.ShowDialog();
        }

        /// <summary>
        /// Открытие формы поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var search = new SearchProcesses(_process);
            search.ShowDialog();
        }
    }
}
