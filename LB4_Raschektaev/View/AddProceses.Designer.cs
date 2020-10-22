namespace View
{
    partial class AddProceses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProceses));
            this.InitialVolumeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFinalVolume = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxInitialTemperature = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFinalTemperature = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPressure = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxGasMass = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHeatCapacityRatio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxlabelTemperature = new System.Windows.Forms.MaskedTextBox();
            this.InitialVolumeLabel = new System.Windows.Forms.Label();
            this.labelFinalVolume = new System.Windows.Forms.Label();
            this.labelInitialTemperature = new System.Windows.Forms.Label();
            this.labelFinalTemperature = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelGasMass = new System.Windows.Forms.Label();
            this.labelHeatCapacityRatio = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.TypeProcess = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMolarMass = new System.Windows.Forms.Label();
            this.maskedTextBoxMolarMass = new System.Windows.Forms.MaskedTextBox();
            this.buttonFindWork = new System.Windows.Forms.Button();
            this.AddProcess = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InitialVolumeTextBox
            // 
            this.InitialVolumeTextBox.Location = new System.Drawing.Point(77, 93);
            this.InitialVolumeTextBox.Mask = "00000";
            this.InitialVolumeTextBox.Name = "InitialVolumeTextBox";
            this.InitialVolumeTextBox.Size = new System.Drawing.Size(100, 20);
            this.InitialVolumeTextBox.TabIndex = 0;
            this.InitialVolumeTextBox.ValidatingType = typeof(int);
            this.InitialVolumeTextBox.Visible = false;
            // 
            // maskedTextBoxFinalVolume
            // 
            this.maskedTextBoxFinalVolume.Location = new System.Drawing.Point(254, 93);
            this.maskedTextBoxFinalVolume.Mask = "00000";
            this.maskedTextBoxFinalVolume.Name = "maskedTextBoxFinalVolume";
            this.maskedTextBoxFinalVolume.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxFinalVolume.TabIndex = 1;
            this.maskedTextBoxFinalVolume.ValidatingType = typeof(int);
            this.maskedTextBoxFinalVolume.Visible = false;
            // 
            // maskedTextBoxInitialTemperature
            // 
            this.maskedTextBoxInitialTemperature.Location = new System.Drawing.Point(77, 93);
            this.maskedTextBoxInitialTemperature.Mask = "00000";
            this.maskedTextBoxInitialTemperature.Name = "maskedTextBoxInitialTemperature";
            this.maskedTextBoxInitialTemperature.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxInitialTemperature.TabIndex = 2;
            this.maskedTextBoxInitialTemperature.ValidatingType = typeof(int);
            this.maskedTextBoxInitialTemperature.Visible = false;
            // 
            // maskedTextBoxFinalTemperature
            // 
            this.maskedTextBoxFinalTemperature.Location = new System.Drawing.Point(254, 93);
            this.maskedTextBoxFinalTemperature.Mask = "00000";
            this.maskedTextBoxFinalTemperature.Name = "maskedTextBoxFinalTemperature";
            this.maskedTextBoxFinalTemperature.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxFinalTemperature.TabIndex = 3;
            this.maskedTextBoxFinalTemperature.ValidatingType = typeof(int);
            this.maskedTextBoxFinalTemperature.Visible = false;
            // 
            // maskedTextBoxPressure
            // 
            this.maskedTextBoxPressure.Location = new System.Drawing.Point(254, 156);
            this.maskedTextBoxPressure.Mask = "00000";
            this.maskedTextBoxPressure.Name = "maskedTextBoxPressure";
            this.maskedTextBoxPressure.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxPressure.TabIndex = 4;
            this.maskedTextBoxPressure.ValidatingType = typeof(int);
            this.maskedTextBoxPressure.Visible = false;
            // 
            // maskedTextBoxGasMass
            // 
            this.maskedTextBoxGasMass.Location = new System.Drawing.Point(80, 156);
            this.maskedTextBoxGasMass.Mask = "00000";
            this.maskedTextBoxGasMass.Name = "maskedTextBoxGasMass";
            this.maskedTextBoxGasMass.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxGasMass.TabIndex = 5;
            this.maskedTextBoxGasMass.ValidatingType = typeof(int);
            this.maskedTextBoxGasMass.Visible = false;
            // 
            // maskedTextBoxHeatCapacityRatio
            // 
            this.maskedTextBoxHeatCapacityRatio.Location = new System.Drawing.Point(80, 156);
            this.maskedTextBoxHeatCapacityRatio.Mask = "1.0000";
            this.maskedTextBoxHeatCapacityRatio.Name = "maskedTextBoxHeatCapacityRatio";
            this.maskedTextBoxHeatCapacityRatio.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxHeatCapacityRatio.TabIndex = 6;
            this.maskedTextBoxHeatCapacityRatio.Visible = false;
            // 
            // maskedTextBoxlabelTemperature
            // 
            this.maskedTextBoxlabelTemperature.Location = new System.Drawing.Point(80, 217);
            this.maskedTextBoxlabelTemperature.Mask = "00000";
            this.maskedTextBoxlabelTemperature.Name = "maskedTextBoxlabelTemperature";
            this.maskedTextBoxlabelTemperature.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxlabelTemperature.TabIndex = 7;
            this.maskedTextBoxlabelTemperature.ValidatingType = typeof(int);
            this.maskedTextBoxlabelTemperature.Visible = false;
            // 
            // InitialVolumeLabel
            // 
            this.InitialVolumeLabel.AutoSize = true;
            this.InitialVolumeLabel.Location = new System.Drawing.Point(77, 68);
            this.InitialVolumeLabel.Name = "InitialVolumeLabel";
            this.InitialVolumeLabel.Size = new System.Drawing.Size(66, 13);
            this.InitialVolumeLabel.TabIndex = 8;
            this.InitialVolumeLabel.Text = "InitialVolume";
            this.InitialVolumeLabel.Visible = false;
            // 
            // labelFinalVolume
            // 
            this.labelFinalVolume.AutoSize = true;
            this.labelFinalVolume.Location = new System.Drawing.Point(254, 68);
            this.labelFinalVolume.Name = "labelFinalVolume";
            this.labelFinalVolume.Size = new System.Drawing.Size(64, 13);
            this.labelFinalVolume.TabIndex = 9;
            this.labelFinalVolume.Text = "FinalVolume";
            this.labelFinalVolume.Visible = false;
            // 
            // labelInitialTemperature
            // 
            this.labelInitialTemperature.AutoSize = true;
            this.labelInitialTemperature.Location = new System.Drawing.Point(77, 68);
            this.labelInitialTemperature.Name = "labelInitialTemperature";
            this.labelInitialTemperature.Size = new System.Drawing.Size(91, 13);
            this.labelInitialTemperature.TabIndex = 10;
            this.labelInitialTemperature.Text = "InitialTemperature";
            this.labelInitialTemperature.Visible = false;
            // 
            // labelFinalTemperature
            // 
            this.labelFinalTemperature.AutoSize = true;
            this.labelFinalTemperature.Location = new System.Drawing.Point(254, 68);
            this.labelFinalTemperature.Name = "labelFinalTemperature";
            this.labelFinalTemperature.Size = new System.Drawing.Size(89, 13);
            this.labelFinalTemperature.TabIndex = 11;
            this.labelFinalTemperature.Text = "FinalTemperature";
            this.labelFinalTemperature.Visible = false;
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Location = new System.Drawing.Point(251, 140);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(48, 13);
            this.labelPressure.TabIndex = 12;
            this.labelPressure.Text = "Pressure";
            this.labelPressure.Visible = false;
            // 
            // labelGasMass
            // 
            this.labelGasMass.AutoSize = true;
            this.labelGasMass.Location = new System.Drawing.Point(80, 136);
            this.labelGasMass.Name = "labelGasMass";
            this.labelGasMass.Size = new System.Drawing.Size(51, 13);
            this.labelGasMass.TabIndex = 13;
            this.labelGasMass.Text = "GasMass";
            this.labelGasMass.Visible = false;
            // 
            // labelHeatCapacityRatio
            // 
            this.labelHeatCapacityRatio.AutoSize = true;
            this.labelHeatCapacityRatio.Location = new System.Drawing.Point(81, 136);
            this.labelHeatCapacityRatio.Name = "labelHeatCapacityRatio";
            this.labelHeatCapacityRatio.Size = new System.Drawing.Size(96, 13);
            this.labelHeatCapacityRatio.TabIndex = 14;
            this.labelHeatCapacityRatio.Text = "HeatCapacityRatio";
            this.labelHeatCapacityRatio.Visible = false;
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(80, 195);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(67, 13);
            this.labelTemperature.TabIndex = 15;
            this.labelTemperature.Text = "Temperature";
            this.labelTemperature.Visible = false;
            // 
            // TypeProcess
            // 
            this.TypeProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TypeProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeProcess.FormattingEnabled = true;
            this.TypeProcess.Location = new System.Drawing.Point(189, 18);
            this.TypeProcess.Name = "TypeProcess";
            this.TypeProcess.Size = new System.Drawing.Size(165, 21);
            this.TypeProcess.TabIndex = 16;
            this.TypeProcess.SelectedIndexChanged += new System.EventHandler(this.TypeProcess_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Select Process";
            // 
            // labelMolarMass
            // 
            this.labelMolarMass.AutoSize = true;
            this.labelMolarMass.Location = new System.Drawing.Point(251, 140);
            this.labelMolarMass.Name = "labelMolarMass";
            this.labelMolarMass.Size = new System.Drawing.Size(58, 13);
            this.labelMolarMass.TabIndex = 20;
            this.labelMolarMass.Text = "MolarMass";
            this.labelMolarMass.Visible = false;
            // 
            // maskedTextBoxMolarMass
            // 
            this.maskedTextBoxMolarMass.Location = new System.Drawing.Point(254, 156);
            this.maskedTextBoxMolarMass.Mask = "00000";
            this.maskedTextBoxMolarMass.Name = "maskedTextBoxMolarMass";
            this.maskedTextBoxMolarMass.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxMolarMass.TabIndex = 18;
            this.maskedTextBoxMolarMass.ValidatingType = typeof(int);
            this.maskedTextBoxMolarMass.Visible = false;
            // 
            // buttonFindWork
            // 
            this.buttonFindWork.BackColor = System.Drawing.Color.Black;
            this.buttonFindWork.ForeColor = System.Drawing.Color.White;
            this.buttonFindWork.Location = new System.Drawing.Point(254, 214);
            this.buttonFindWork.Name = "buttonFindWork";
            this.buttonFindWork.Size = new System.Drawing.Size(100, 23);
            this.buttonFindWork.TabIndex = 21;
            this.buttonFindWork.Text = "Find Work";
            this.buttonFindWork.UseVisualStyleBackColor = false;
            this.buttonFindWork.Visible = false;
            this.buttonFindWork.Click += new System.EventHandler(this.buttonFindWork_Click);
            // 
            // AddProcess
            // 
            this.AddProcess.BackColor = System.Drawing.Color.Black;
            this.AddProcess.ForeColor = System.Drawing.Color.White;
            this.AddProcess.Location = new System.Drawing.Point(80, 322);
            this.AddProcess.Name = "AddProcess";
            this.AddProcess.Size = new System.Drawing.Size(100, 28);
            this.AddProcess.TabIndex = 22;
            this.AddProcess.Text = "Add Process";
            this.AddProcess.UseVisualStyleBackColor = false;
            this.AddProcess.Visible = false;
            this.AddProcess.Click += new System.EventHandler(this.AddProceses_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(254, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 23;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(80, 260);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 24;
            this.labelResult.Text = "Result";
            this.labelResult.Visible = false;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(80, 276);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(274, 20);
            this.textBoxResult.TabIndex = 25;
            this.textBoxResult.Visible = false;
            // 
            // AddProceses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(421, 378);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AddProcess);
            this.Controls.Add(this.buttonFindWork);
            this.Controls.Add(this.labelMolarMass);
            this.Controls.Add(this.maskedTextBoxMolarMass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TypeProcess);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.labelHeatCapacityRatio);
            this.Controls.Add(this.labelGasMass);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelFinalTemperature);
            this.Controls.Add(this.labelInitialTemperature);
            this.Controls.Add(this.labelFinalVolume);
            this.Controls.Add(this.InitialVolumeLabel);
            this.Controls.Add(this.maskedTextBoxlabelTemperature);
            this.Controls.Add(this.maskedTextBoxHeatCapacityRatio);
            this.Controls.Add(this.maskedTextBoxGasMass);
            this.Controls.Add(this.maskedTextBoxPressure);
            this.Controls.Add(this.maskedTextBoxFinalTemperature);
            this.Controls.Add(this.maskedTextBoxInitialTemperature);
            this.Controls.Add(this.maskedTextBoxFinalVolume);
            this.Controls.Add(this.InitialVolumeTextBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddProceses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Proceses";
            this.Load += new System.EventHandler(this.AddProceses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox InitialVolumeTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFinalVolume;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInitialTemperature;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFinalTemperature;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPressure;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGasMass;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHeatCapacityRatio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxlabelTemperature;
        private System.Windows.Forms.Label InitialVolumeLabel;
        private System.Windows.Forms.Label labelFinalVolume;
        private System.Windows.Forms.Label labelInitialTemperature;
        private System.Windows.Forms.Label labelFinalTemperature;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelGasMass;
        private System.Windows.Forms.Label labelHeatCapacityRatio;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.ComboBox TypeProcess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonFindWork;
        private System.Windows.Forms.Button AddProcess;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelMolarMass;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMolarMass;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}