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
    /// <summary>
    /// Форма добавления процессов
    /// </summary>
    public partial class AddProceses : Form
    {
        /// <summary>
        /// Лист 
        /// </summary>
        private BindingList<IProcessBase> _process;

        /// <summary>
        /// Выбранный процесс
        /// </summary>
        private IProcessBase _classprocess;

        /// <summary>
        /// Иниицаилизация процессов
        /// </summary>
        public AddProceses(BindingList<IProcessBase> process)
        {
            InitializeComponent();
            _process = process;
            _exceptionList = new List<string>();

        }

        /// <summary>
        /// Поле для хранения списка сообщений исключений
        /// </summary>
        private List<string> _exceptionList;

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProceses_Load(object sender, EventArgs e)
        {
            TypeProcessComboBox.Items.Add(ProcessName.IsothermalProcess);
            TypeProcessComboBox.Items.Add(ProcessName.AdiabaticProcess);
            TypeProcessComboBox.Items.Add(ProcessName.IsobaricProcess);
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Раскрытие элемента TypeCalcComboBox и раскрытие полей ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypeProcess_SelectionChangeCommitted(object sender, EventArgs e)
        {
            labelResult.Visible = true;
            textBoxResult.Visible = true;
            buttonCalculateWork.Visible = true;
            switch (TypeProcessComboBox.SelectedItem)
            {
                case ProcessName.AdiabaticProcess:
                {
                    _classprocess = new AdiabaticProcess();
                    labelPressure.Visible = true;
                    maskedTextBoxPressure.Visible = true;
                    maskedTextBoxHeatCapacityRatio.Visible = true;
                    labelHeatCapacityRatio.Visible = true;
                    InitialVolumeLabel.Visible = true;
                    InitialVolumeTextBox.Visible = true;
                    labelFinalVolume.Visible = true;
                    maskedTextBoxFinalVolume.Visible = true;
                    labelGasMass.Visible = false;
                    maskedTextBoxGasMass.Visible = false;
                    labelMolarMass.Visible = false;
                    maskedTextBoxMolarMass.Visible = false;
                    labelTemperature.Visible = false;
                    maskedTextBoxlabelTemperature.Visible = false;
                    labelInitialTemperature.Visible = false;
                    labelFinalTemperature.Visible = false;
                    maskedTextBoxInitialTemperature.Visible = false;
                    maskedTextBoxFinalTemperature.Visible = false;
                    break;
                }
                case ProcessName.IsobaricProcess:
                {
                    _classprocess = new IsobaricProcess();
                    labelInitialTemperature.Visible = true;
                    labelFinalTemperature.Visible = true;
                    maskedTextBoxInitialTemperature.Visible = true;
                    maskedTextBoxFinalTemperature.Visible = true;
                    labelGasMass.Visible = true;
                    maskedTextBoxGasMass.Visible = true;
                    labelMolarMass.Visible = true;
                    maskedTextBoxMolarMass.Visible = true;
                    labelPressure.Visible = false;
                    maskedTextBoxPressure.Visible = false;
                    maskedTextBoxHeatCapacityRatio.Visible = false;
                    labelHeatCapacityRatio.Visible = false;
                    InitialVolumeLabel.Visible = false;
                    InitialVolumeTextBox.Visible = false;
                    labelFinalVolume.Visible = false;
                    maskedTextBoxFinalVolume.Visible = false;
                    labelTemperature.Visible = false;
                    maskedTextBoxlabelTemperature.Visible = false;
                    break;
                }
                case ProcessName.IsothermalProcess:
                {
                    _classprocess = new IsothermalProcess();
                    labelGasMass.Visible = true;
                    maskedTextBoxGasMass.Visible = true;
                    labelMolarMass.Visible = true;
                    maskedTextBoxMolarMass.Visible = true;
                    InitialVolumeLabel.Visible = true;
                    InitialVolumeTextBox.Visible = true;
                    labelFinalVolume.Visible = true;
                    maskedTextBoxFinalVolume.Visible = true;
                    labelTemperature.Visible = true;
                    maskedTextBoxlabelTemperature.Visible = true;
                    labelInitialTemperature.Visible = false;
                    labelFinalTemperature.Visible = false;
                    maskedTextBoxInitialTemperature.Visible = false;
                    maskedTextBoxFinalTemperature.Visible = false; ;
                    maskedTextBoxHeatCapacityRatio.Visible = false;
                    labelHeatCapacityRatio.Visible = false;
                    labelPressure.Visible = false;
                    maskedTextBoxPressure.Visible = false;
                    break;
                }
            }
         }

        /// <summary>
        /// Добавление процесса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProceses_Click(object sender, EventArgs e)
        {
            if (_classprocess == null)
            {
                MessageBox.Show(
                    $"Add Data, Please");
            }
            else if (textBoxResult.Text == String.Empty)
            {
                MessageBox.Show($"Calculate Work!");
            }
            else
            {
                _process.Add(_classprocess);
            }
            this.Close();
        }

        /// <summary>
        /// Валидация
        /// </summary>
        /// <param name="value"></param>
        /// <param name="nameOfTextBox"></param>
        private double CheckStringNullOrEmpty(string value, string nameOfTextBox)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new FormatException($"{nameOfTextBox}"+
                    " - field is empty!");
            }
            else
            {
                return Convert.ToDouble(value);
            }
        }

        /// <summary>
        /// Расчет работы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculateWork_Click(object sender, EventArgs e)
        {
            switch (_classprocess.NameProcess)
            {
                case ProcessName.IsobaricProcess:
                {
                    _classprocess = AddIsobaricWork();
                    ShowException(_exceptionList);
                    break;
                }
                case ProcessName.IsothermalProcess:
                {
                    _classprocess = AddIsothermalWork();
                    ShowException(_exceptionList);
                    break;
                }
                case ProcessName.AdiabaticProcess:
                {
                    _classprocess = AddAdiabaticlWork();
                    ShowException(_exceptionList);
                    break;
                }
            }
            if (double.IsNaN(_classprocess.Work)
                || double.IsInfinity(_classprocess.Work))
            {
                textBoxResult.Text = "Incorrect data! Check it out!";
                AddProcessButton.Visible = false;
            }
            else
            {
                textBoxResult.Text = $"{_classprocess.Work}";
                AddProcessButton.Visible = true;
            }
        }

        /// <summary>
        /// Установить значение свойствам объекта класса 
        /// </summary>
        /// <param name="action">Делегат Action</param>
        private void SetValue(Action action)
        {
            try
            {
                action.Invoke();
                return;
            }
            catch (Exception exception)
            {
                if (exception is ArgumentException ||
                    exception is FormatException)
                {
                    _exceptionList.Add(exception.Message);
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Добавить параметры Изобарного процесса
        /// </summary>
        private IProcessBase AddIsobaricWork()
        {
            //TODO: RSDN? - исправил
            var classProcess = new IsobaricProcess();
            var actions = new List<Action>()
                {
                new Action(() =>
                {
                    classProcess.InitialTemperature =
                    CheckStringNullOrEmpty
                    (maskedTextBoxInitialTemperature.Text,
                    "Initial Temperature");
                }),
                new Action(() =>
                {
                    classProcess.FinalTemperature =
                    CheckStringNullOrEmpty
                    (maskedTextBoxFinalTemperature.Text,
                    "Final Temperature");
                }),
                new Action(() =>
                {
                    classProcess.GasMass =
                    CheckStringNullOrEmpty(maskedTextBoxGasMass.Text,
                    "Gas Mass");
                }),
                new Action(() =>
                {
                    classProcess.MolarMass =
                    CheckStringNullOrEmpty(maskedTextBoxMolarMass.Text,
                    "Molar Mass");
                }),
            };
            actions.ForEach(SetValue);
            return classProcess;
        }

        /// <summary>
        /// Добавить параметры Изобарного процесса
        /// </summary>
        private IProcessBase AddIsothermalWork()
        {
            var classProcess = new IsothermalProcess();
            var actions = new List<Action>()
                {
                    () =>
                    {
                        classProcess.GasMass =
                        CheckStringNullOrEmpty(maskedTextBoxGasMass.Text,
                            "Gas Mass");
                    },
                    () =>
                    {
                        classProcess.Temperature =
                            CheckStringNullOrEmpty(maskedTextBoxlabelTemperature.Text,
                                "Temperature");
                    },
                    () =>
                    {
                        classProcess.InitialVolume =
                            CheckStringNullOrEmpty(InitialVolumeTextBox.Text,
                                "Initial Volume");
                    },
                    () =>
                    {
                        classProcess.FinalVolume =
                            CheckStringNullOrEmpty(maskedTextBoxFinalVolume.Text,
                                "Final Volume");
                    },
                    () =>
                    {
                        classProcess.MolarMass =
                            CheckStringNullOrEmpty(maskedTextBoxMolarMass.Text,
                                "Molar Mass");
                    },
            };
            actions.ForEach(SetValue);
            return classProcess;
        }

        /// <summary>
        /// Добавить параметры Изобарного процесса
        /// </summary>
        private IProcessBase AddAdiabaticlWork()
        {
            //TODO: RSDN - исправил
            var classProcess = new AdiabaticProcess();
            var actions = new List<Action>()
                {
                () =>
                {
                    classProcess.InitialVolume =
                        CheckStringNullOrEmpty(InitialVolumeTextBox.Text,
                            "Initial Volume");
                },
                new Action(() =>
                {
                    classProcess.FinalVolume =
                    CheckStringNullOrEmpty(maskedTextBoxFinalVolume.Text,
                    "Final Volume");
                }),
                new Action(() =>
                {
                    classProcess.Pressure =
                    CheckStringNullOrEmpty(maskedTextBoxPressure.Text,
                    "Pressure");
                }),
                new Action(() =>
                {
                    classProcess.HeatCapacityRatio =
                    CheckStringNullOrEmpty(maskedTextBoxHeatCapacityRatio.Text,
                    "Heat Capacity Ratio");
                }),
            };
            actions.ForEach(SetValue);
            return classProcess;
        }

        /// <summary>
        /// Показать список исключений
        /// </summary>
        /// <param name="exceptionList">Список сообщений исключений</param>
        private void ShowException(List<string> exceptionList)
        {
            if (exceptionList.Any())
            {
                MessageBox.Show(string.Join("\n",
                    exceptionList.ToArray()));
            }
            exceptionList.Clear();
        }
    }
}
