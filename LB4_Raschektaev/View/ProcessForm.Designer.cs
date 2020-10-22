namespace View
{
    partial class ProcessForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewProcessesWork = new System.Windows.Forms.DataGridView();
            this.RemoveProcessButton = new System.Windows.Forms.Button();
            this.AddProcessButton = new System.Windows.Forms.Button();
            this.FindProcessButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.RandomProcessButton = new System.Windows.Forms.Button();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessesWork)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewProcessesWork);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process List";
            // 
            // dataGridViewProcessesWork
            // 
            this.dataGridViewProcessesWork.AllowUserToAddRows = false;
            this.dataGridViewProcessesWork.AllowUserToDeleteRows = false;
            this.dataGridViewProcessesWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProcessesWork.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewProcessesWork.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProcessesWork.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewProcessesWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProcessesWork.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProcessesWork.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProcessesWork.EnableHeadersVisualStyles = false;
            this.dataGridViewProcessesWork.GridColor = System.Drawing.Color.Black;
            this.dataGridViewProcessesWork.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewProcessesWork.Name = "dataGridViewProcessesWork";
            this.dataGridViewProcessesWork.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProcessesWork.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProcessesWork.RowHeadersVisible = false;
            this.dataGridViewProcessesWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcessesWork.Size = new System.Drawing.Size(293, 189);
            this.dataGridViewProcessesWork.TabIndex = 0;
            this.dataGridViewProcessesWork.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcessesWork_CellContentClick);
            // 
            // RemoveProcessButton
            // 
            this.RemoveProcessButton.BackColor = System.Drawing.Color.Black;
            this.RemoveProcessButton.ForeColor = System.Drawing.Color.White;
            this.RemoveProcessButton.Location = new System.Drawing.Point(24, 310);
            this.RemoveProcessButton.Name = "RemoveProcessButton";
            this.RemoveProcessButton.Size = new System.Drawing.Size(143, 25);
            this.RemoveProcessButton.TabIndex = 2;
            this.RemoveProcessButton.Text = "Remove Process";
            this.RemoveProcessButton.UseVisualStyleBackColor = false;
            this.RemoveProcessButton.Click += new System.EventHandler(this.Delete_Click);
            // 
            // AddProcessButton
            // 
            this.AddProcessButton.BackColor = System.Drawing.Color.Black;
            this.AddProcessButton.ForeColor = System.Drawing.Color.White;
            this.AddProcessButton.Location = new System.Drawing.Point(24, 278);
            this.AddProcessButton.Name = "AddProcessButton";
            this.AddProcessButton.Size = new System.Drawing.Size(143, 26);
            this.AddProcessButton.TabIndex = 3;
            this.AddProcessButton.Text = "Add Process";
            this.AddProcessButton.UseVisualStyleBackColor = false;
            this.AddProcessButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // FindProcessButton
            // 
            this.FindProcessButton.BackColor = System.Drawing.Color.Black;
            this.FindProcessButton.ForeColor = System.Drawing.Color.White;
            this.FindProcessButton.Location = new System.Drawing.Point(24, 341);
            this.FindProcessButton.Name = "FindProcessButton";
            this.FindProcessButton.Size = new System.Drawing.Size(143, 25);
            this.FindProcessButton.TabIndex = 5;
            this.FindProcessButton.Text = "Find Process";
            this.FindProcessButton.UseVisualStyleBackColor = false;
            this.FindProcessButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Black;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(173, 279);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 40);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Processes";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Black;
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.Location = new System.Drawing.Point(173, 326);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(150, 40);
            this.LoadButton.TabIndex = 7;
            this.LoadButton.Text = "Load Processes";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.Load_Click);
            // 
            // RandomProcessButton
            // 
            this.RandomProcessButton.BackColor = System.Drawing.Color.Black;
            this.RandomProcessButton.ForeColor = System.Drawing.Color.White;
            this.RandomProcessButton.Location = new System.Drawing.Point(24, 18);
            this.RandomProcessButton.Name = "RandomProcessButton";
            this.RandomProcessButton.Size = new System.Drawing.Size(299, 27);
            this.RandomProcessButton.TabIndex = 12;
            this.RandomProcessButton.Text = "RandomProcess";
            this.RandomProcessButton.UseVisualStyleBackColor = false;
            this.RandomProcessButton.Click += new System.EventHandler(this.Random_Click);
            // 
            // ResizeButton
            // 
            this.ResizeButton.BackColor = System.Drawing.Color.Black;
            this.ResizeButton.ForeColor = System.Drawing.Color.White;
            this.ResizeButton.Location = new System.Drawing.Point(24, 372);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(299, 27);
            this.ResizeButton.TabIndex = 13;
            this.ResizeButton.Text = "Resize";
            this.ResizeButton.UseVisualStyleBackColor = false;
            this.ResizeButton.Click += new System.EventHandler(this.Resize_Click);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(352, 418);
            this.Controls.Add(this.ResizeButton);
            this.Controls.Add(this.RandomProcessButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FindProcessButton);
            this.Controls.Add(this.AddProcessButton);
            this.Controls.Add(this.RemoveProcessButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcessForm";
            this.Load += new System.EventHandler(this.ProcessForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessesWork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewProcessesWork;
        private System.Windows.Forms.Button RemoveProcessButton;
        private System.Windows.Forms.Button AddProcessButton;
        private System.Windows.Forms.Button FindProcessButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button RandomProcessButton;
        private System.Windows.Forms.Button ResizeButton;
    }
}

