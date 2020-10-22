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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProcesses));
            this.Parameters = new System.Windows.Forms.Label();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.SearchALL = new System.Windows.Forms.Button();
            this.SearchGreaterWork = new System.Windows.Forms.RadioButton();
            this.SearchLessWork = new System.Windows.Forms.RadioButton();
            this.SearchEqualWork = new System.Windows.Forms.RadioButton();
            this.SearchByName = new System.Windows.Forms.RadioButton();
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
            // SearchALL
            // 
            this.SearchALL.BackColor = System.Drawing.Color.Black;
            this.SearchALL.Location = new System.Drawing.Point(19, 336);
            this.SearchALL.Name = "SearchALL";
            this.SearchALL.Size = new System.Drawing.Size(239, 23);
            this.SearchALL.TabIndex = 13;
            this.SearchALL.Text = "SEARCH";
            this.SearchALL.UseVisualStyleBackColor = false;
            this.SearchALL.Click += new System.EventHandler(this.SearchALL_Click);
            // 
            // SearchGreaterWork
            // 
            this.SearchGreaterWork.AutoSize = true;
            this.SearchGreaterWork.Location = new System.Drawing.Point(138, 232);
            this.SearchGreaterWork.Name = "SearchGreaterWork";
            this.SearchGreaterWork.Size = new System.Drawing.Size(120, 17);
            this.SearchGreaterWork.TabIndex = 12;
            this.SearchGreaterWork.TabStop = true;
            this.SearchGreaterWork.Text = "SearchGreaterWork";
            this.SearchGreaterWork.UseVisualStyleBackColor = true;
            // 
            // SearchLessWork
            // 
            this.SearchLessWork.AutoSize = true;
            this.SearchLessWork.Location = new System.Drawing.Point(138, 197);
            this.SearchLessWork.Name = "SearchLessWork";
            this.SearchLessWork.Size = new System.Drawing.Size(107, 17);
            this.SearchLessWork.TabIndex = 11;
            this.SearchLessWork.TabStop = true;
            this.SearchLessWork.Text = "SearchLessWork";
            this.SearchLessWork.UseVisualStyleBackColor = true;
            // 
            // SearchEqualWork
            // 
            this.SearchEqualWork.AutoSize = true;
            this.SearchEqualWork.Location = new System.Drawing.Point(18, 229);
            this.SearchEqualWork.Name = "SearchEqualWork";
            this.SearchEqualWork.Size = new System.Drawing.Size(98, 30);
            this.SearchEqualWork.TabIndex = 10;
            this.SearchEqualWork.TabStop = true;
            this.SearchEqualWork.Text = "SearchRoughly\r\nEqualWork";
            this.SearchEqualWork.UseVisualStyleBackColor = true;
            // 
            // SearchByName
            // 
            this.SearchByName.AutoSize = true;
            this.SearchByName.Location = new System.Drawing.Point(18, 197);
            this.SearchByName.Name = "SearchByName";
            this.SearchByName.Size = new System.Drawing.Size(99, 17);
            this.SearchByName.TabIndex = 9;
            this.SearchByName.TabStop = true;
            this.SearchByName.Text = "SearchByName";
            this.SearchByName.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProcess
            // 
            this.dataGridViewProcess.AllowUserToAddRows = false;
            this.dataGridViewProcess.AllowUserToDeleteRows = false;
            this.dataGridViewProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcess.Location = new System.Drawing.Point(18, 12);
            this.dataGridViewProcess.Name = "dataGridViewProcess";
            this.dataGridViewProcess.ReadOnly = true;
            this.dataGridViewProcess.RowHeadersVisible = false;
            this.dataGridViewProcess.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewProcess.TabIndex = 8;
            // 
            // SearchProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.Parameters);
            this.Controls.Add(this.textBoxParameter);
            this.Controls.Add(this.SearchALL);
            this.Controls.Add(this.SearchGreaterWork);
            this.Controls.Add(this.SearchLessWork);
            this.Controls.Add(this.SearchEqualWork);
            this.Controls.Add(this.SearchByName);
            this.Controls.Add(this.dataGridViewProcess);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button SearchALL;
        private System.Windows.Forms.RadioButton SearchGreaterWork;
        private System.Windows.Forms.RadioButton SearchLessWork;
        private System.Windows.Forms.RadioButton SearchEqualWork;
        private System.Windows.Forms.RadioButton SearchByName;
        private System.Windows.Forms.DataGridView dataGridViewProcess;
    }
}