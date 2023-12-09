
namespace Tyuiu.GunbinNA.Sprint6.Task3.V9
{
    partial class FormMain_GNA
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
            this.groupBoxTask_GNA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GNA = new System.Windows.Forms.TextBox();
            this.buttonDone_GNA = new System.Windows.Forms.Button();
            this.buttonInfo_GNA = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_GNA = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_GNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_GNA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_GNA
            // 
            this.groupBoxTask_GNA.Controls.Add(this.dataGridViewMatrix_GNA);
            this.groupBoxTask_GNA.Controls.Add(this.textBoxTask_GNA);
            this.groupBoxTask_GNA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_GNA.Name = "groupBoxTask_GNA";
            this.groupBoxTask_GNA.Size = new System.Drawing.Size(965, 463);
            this.groupBoxTask_GNA.TabIndex = 0;
            this.groupBoxTask_GNA.TabStop = false;
            this.groupBoxTask_GNA.Text = "Условие";
            // 
            // textBoxTask_GNA
            // 
            this.textBoxTask_GNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_GNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GNA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTask_GNA.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_GNA.Multiline = true;
            this.textBoxTask_GNA.Name = "textBoxTask_GNA";
            this.textBoxTask_GNA.ReadOnly = true;
            this.textBoxTask_GNA.Size = new System.Drawing.Size(559, 431);
            this.textBoxTask_GNA.TabIndex = 0;
            this.textBoxTask_GNA.Text = "Дан массив 5 на 5 элементов\r\n-14, 25, 26, 18, 17  \r\n28, 10, 6, -2, 4 \r\n30, 25, -3" +
    ", 11, -10  \r\n11, 32, -5, -20, 25 \r\n2, -18, 11, 8, -20 \r\nВыполнить сортировку по " +
    "возрастанию в пятом столбце";
            // 
            // buttonDone_GNA
            // 
            this.buttonDone_GNA.Location = new System.Drawing.Point(985, 26);
            this.buttonDone_GNA.Name = "buttonDone_GNA";
            this.buttonDone_GNA.Size = new System.Drawing.Size(106, 365);
            this.buttonDone_GNA.TabIndex = 1;
            this.buttonDone_GNA.Text = "Выполнить";
            this.buttonDone_GNA.UseVisualStyleBackColor = true;
            this.buttonDone_GNA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonInfo_GNA
            // 
            this.buttonInfo_GNA.Location = new System.Drawing.Point(985, 397);
            this.buttonInfo_GNA.Name = "buttonInfo_GNA";
            this.buttonInfo_GNA.Size = new System.Drawing.Size(106, 73);
            this.buttonInfo_GNA.TabIndex = 1;
            this.buttonInfo_GNA.Text = "?";
            this.buttonInfo_GNA.UseVisualStyleBackColor = true;
            this.buttonInfo_GNA.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // dataGridViewMatrix_GNA
            // 
            this.dataGridViewMatrix_GNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_GNA.Location = new System.Drawing.Point(582, 26);
            this.dataGridViewMatrix_GNA.Name = "dataGridViewMatrix_GNA";
            this.dataGridViewMatrix_GNA.RowHeadersVisible = false;
            this.dataGridViewMatrix_GNA.RowHeadersWidth = 62;
            this.dataGridViewMatrix_GNA.RowTemplate.Height = 28;
            this.dataGridViewMatrix_GNA.Size = new System.Drawing.Size(377, 342);
            this.dataGridViewMatrix_GNA.TabIndex = 1;
            // 
            // FormMain_GNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 488);
            this.Controls.Add(this.buttonInfo_GNA);
            this.Controls.Add(this.buttonDone_GNA);
            this.Controls.Add(this.groupBoxTask_GNA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_GNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 9 | Гунбин Н. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_GNA.ResumeLayout(false);
            this.groupBoxTask_GNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_GNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_GNA;
        private System.Windows.Forms.TextBox textBoxTask_GNA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_GNA;
        private System.Windows.Forms.Button buttonDone_GNA;
        private System.Windows.Forms.Button buttonInfo_GNA;
    }
}

