namespace View
{
    partial class SearchProcesses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProcesses));
            this.Parameters = new System.Windows.Forms.Label();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.SearchALLButton = new System.Windows.Forms.Button();
            this.SearchGreaterWorkLabel = new System.Windows.Forms.RadioButton();
            this.SearchLessWorkLabel = new System.Windows.Forms.RadioButton();
            this.SearchEqualWorkLabel = new System.Windows.Forms.RadioButton();
            this.SearchByNameLabel = new System.Windows.Forms.RadioButton();
            this.dataGridViewProcess = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // Parameters
            // 
            this.Parameters.AutoSize = true;
            this.Parameters.Location = new System.Drawing.Point(15, 264);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(55, 13);
            this.Parameters.TabIndex = 15;
            this.Parameters.Text = "Parameter";
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(18, 294);
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.Size = new System.Drawing.Size(239, 20);
            this.textBoxParameter.TabIndex = 14;
            // 
            // SearchALLButton
            // 
            this.SearchALLButton.BackColor = System.Drawing.Color.Black;
            this.SearchALLButton.Location = new System.Drawing.Point(19, 336);
            this.SearchALLButton.Name = "SearchALLButton";
            this.SearchALLButton.Size = new System.Drawing.Size(239, 23);
            this.SearchALLButton.TabIndex = 13;
            this.SearchALLButton.Text = "SEARCH";
            this.SearchALLButton.UseVisualStyleBackColor = false;
            this.SearchALLButton.Click += new System.EventHandler(this.SearchALL_Click);
            // 
            // SearchGreaterWorkLabel
            // 
            this.SearchGreaterWorkLabel.AutoSize = true;
            this.SearchGreaterWorkLabel.Location = new System.Drawing.Point(138, 232);
            this.SearchGreaterWorkLabel.Name = "SearchGreaterWorkLabel";
            this.SearchGreaterWorkLabel.Size = new System.Drawing.Size(120, 17);
            this.SearchGreaterWorkLabel.TabIndex = 12;
            this.SearchGreaterWorkLabel.TabStop = true;
            this.SearchGreaterWorkLabel.Text = "SearchGreaterWork";
            this.SearchGreaterWorkLabel.UseVisualStyleBackColor = true;
            // 
            // SearchLessWorkLabel
            // 
            this.SearchLessWorkLabel.AutoSize = true;
            this.SearchLessWorkLabel.Location = new System.Drawing.Point(138, 197);
            this.SearchLessWorkLabel.Name = "SearchLessWorkLabel";
            this.SearchLessWorkLabel.Size = new System.Drawing.Size(107, 17);
            this.SearchLessWorkLabel.TabIndex = 11;
            this.SearchLessWorkLabel.TabStop = true;
            this.SearchLessWorkLabel.Text = "SearchLessWork";
            this.SearchLessWorkLabel.UseVisualStyleBackColor = true;
            // 
            // SearchEqualWorkLabel
            // 
            this.SearchEqualWorkLabel.AutoSize = true;
            this.SearchEqualWorkLabel.Location = new System.Drawing.Point(18, 229);
            this.SearchEqualWorkLabel.Name = "SearchEqualWorkLabel";
            this.SearchEqualWorkLabel.Size = new System.Drawing.Size(98, 30);
            this.SearchEqualWorkLabel.TabIndex = 10;
            this.SearchEqualWorkLabel.TabStop = true;
            this.SearchEqualWorkLabel.Text = "SearchRoughly\r\nEqualWork";
            this.SearchEqualWorkLabel.UseVisualStyleBackColor = true;
            // 
            // SearchByNameLabel
            // 
            this.SearchByNameLabel.AutoSize = true;
            this.SearchByNameLabel.Location = new System.Drawing.Point(18, 197);
            this.SearchByNameLabel.Name = "SearchByNameLabel";
            this.SearchByNameLabel.Size = new System.Drawing.Size(99, 17);
            this.SearchByNameLabel.TabIndex = 9;
            this.SearchByNameLabel.TabStop = true;
            this.SearchByNameLabel.Text = "SearchByName";
            this.SearchByNameLabel.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProcess
            // 
            this.dataGridViewProcess.AllowUserToAddRows = false;
            this.dataGridViewProcess.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewProcess.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProcess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProcess.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProcess.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProcess.GridColor = System.Drawing.Color.White;
            this.dataGridViewProcess.Location = new System.Drawing.Point(18, 12);
            this.dataGridViewProcess.Name = "dataGridViewProcess";
            this.dataGridViewProcess.ReadOnly = true;
            this.dataGridViewProcess.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dataGridViewProcess.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProcess.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewProcess.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewProcess.TabIndex = 8;
            // 
            // SearchProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 377);
            this.Controls.Add(this.Parameters);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.SearchALLButton);
            this.Controls.Add(this.SearchGreaterWorkLabel);
            this.Controls.Add(this.SearchLessWorkLabel);
            this.Controls.Add(this.SearchEqualWorkLabel);
            this.Controls.Add(this.SearchByNameLabel);
            this.Controls.Add(this.dataGridViewProcess);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchProcesses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchProcesscs";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Parameters;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.Button SearchALLButton;
        private System.Windows.Forms.RadioButton SearchGreaterWorkLabel;
        private System.Windows.Forms.RadioButton SearchLessWorkLabel;
        private System.Windows.Forms.RadioButton SearchEqualWorkLabel;
        private System.Windows.Forms.RadioButton SearchByNameLabel;
        private System.Windows.Forms.DataGridView dataGridViewProcess;
    }
}