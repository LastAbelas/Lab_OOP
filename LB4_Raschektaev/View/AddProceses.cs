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
        /// Список классов процесса
        /// </summary>
        public List<string> _processItemsList;

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
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProceses_Load(object sender, EventArgs e)
        {
            _processItemsList = new List<string>();
            //TODO: убрать нафик - убрал нафиг
            TypeProcessComboBox.Items.Add(ProcessName.AdiabaticProcess);
            TypeProcessComboBox.Items.Add(ProcessName.IsobaricProcess);
            TypeProcessComboBox.Items.Add(ProcessName.IsothermalProcess);
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
            buttonFindWork.Visible = true;
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
                    labelInitialTemperature.Visible = true;
                    labelFinalTemperature.Visible = true;
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
                MessageBox.Show($"Find Work");
            }
            else
            {
                _process.Add(_classprocess);
            }
            this.Close();
        }

        /// <summary>
        /// Расчет площади
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFindWork_Click(object sender, EventArgs e)
        {
            List<double> _calcBuffer = new List<double>();
            switch(_classprocess.NameProcess)
            {
                //TODO: - исправил
                case ProcessName.IsobaricProcess:
                {
                    _calcBuffer.Add(Convert.ToDouble(maskedTextBoxInitialTemperature.Text));
                    _calcBuffer.Add(Convert.ToDouble(maskedTextBoxFinalTemperature.Text));
                    _calcBuffer.Add(Convert.ToDouble(maskedTextBoxGasMass.Text));
                    _calcBuffer.Add(Convert.ToDouble(maskedTextBoxMolarMass.Text));
                    break;
                }
                case ProcessName.IsothermalProcess:
                {
                    _calcBuffer.Add(Convert.ToDouble(maskedTextBoxGasMass.Text));
                    _calcBuffer.Add(Convert.ToDouble(maskedTextBoxlabelTemperature.Text));
                    _calcBuffer.Add(Convert.ToDouble(InitialVolumeTextBox.Text));
                    _calcBuffer.Add(Convert.ToDouble(maskedTextBoxFinalVolume.Text));
                    _calcBuffer.Add(Convert.ToDouble(maskedTextBoxMolarMass.Text));
                    break;      
                }
                 case ProcessName.AdiabaticProcess:
                {
                    _calcBuffer.Add(Convert.ToDouble(InitialVolumeTextBox.Text));
                    _calcBuffer.Add(Convert.ToDouble(maskedTextBoxFinalVolume.Text));
                    _calcBuffer.Add(Convert.ToDouble(maskedTextBoxPressure.Text));
                    _calcBuffer.Add(Convert.ToDouble(maskedTextBoxHeatCapacityRatio.Text));
                    break;
                }
            }
            // передача введенных параметров в расчетный класс
            try
            {
                _classprocess.ValuesParameteres = _calcBuffer;
            }
            catch (ArgumentOutOfRangeException exception)
            {
                if (exception is ArgumentOutOfRangeException)
                {
                    MessageBox.Show(exception.Message);
                }      
            }
            catch (ArithmeticException exception)
            {
                if (exception is ArithmeticException)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            // вывод результатов в текстбокс
            textBoxResult.Text = $"{_classprocess.Work}";
            AddProcessButton.Visible = true;
        }
    }


}
