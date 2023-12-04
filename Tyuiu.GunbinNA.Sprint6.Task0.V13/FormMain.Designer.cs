
namespace Tyuiu.GunbinNA.Sprint6.Task0.V13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_GNA));
            this.groupBoxTask_GNA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormul_GNA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_GNA = new System.Windows.Forms.TextBox();
            this.groupBoxVars_GNA = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_GNA = new System.Windows.Forms.GroupBox();
            this.textBoxVarX_GNA = new System.Windows.Forms.TextBox();
            this.textBoxResult_GNA = new System.Windows.Forms.TextBox();
            this.labelResult_GNA = new System.Windows.Forms.Label();
            this.labelVarX_GNA = new System.Windows.Forms.Label();
            this.buttonDone_GNA = new System.Windows.Forms.Button();
            this.buttonInfo_GNA = new System.Windows.Forms.Button();
            this.groupBoxTask_GNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormul_GNA)).BeginInit();
            this.groupBoxVars_GNA.SuspendLayout();
            this.groupBoxResult_GNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_GNA
            // 
            this.groupBoxTask_GNA.Controls.Add(this.textBoxTask_GNA);
            this.groupBoxTask_GNA.Controls.Add(this.pictureBoxFormul_GNA);
            this.groupBoxTask_GNA.Location = new System.Drawing.Point(12, 27);
            this.groupBoxTask_GNA.Name = "groupBoxTask_GNA";
            this.groupBoxTask_GNA.Size = new System.Drawing.Size(776, 206);
            this.groupBoxTask_GNA.TabIndex = 0;
            this.groupBoxTask_GNA.TabStop = false;
            this.groupBoxTask_GNA.Text = "Условие";
            this.groupBoxTask_GNA.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBoxFormul_GNA
            // 
            this.pictureBoxFormul_GNA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormul_GNA.Image")));
            this.pictureBoxFormul_GNA.Location = new System.Drawing.Point(574, 25);
            this.pictureBoxFormul_GNA.Name = "pictureBoxFormul_GNA";
            this.pictureBoxFormul_GNA.Size = new System.Drawing.Size(196, 105);
            this.pictureBoxFormul_GNA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormul_GNA.TabIndex = 0;
            this.pictureBoxFormul_GNA.TabStop = false;
            this.pictureBoxFormul_GNA.Click += new System.EventHandler(this.pictureBoxTask_Click);
            // 
            // textBoxTask_GNA
            // 
            this.textBoxTask_GNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_GNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GNA.Location = new System.Drawing.Point(11, 25);
            this.textBoxTask_GNA.Multiline = true;
            this.textBoxTask_GNA.Name = "textBoxTask_GNA";
            this.textBoxTask_GNA.ReadOnly = true;
            this.textBoxTask_GNA.Size = new System.Drawing.Size(536, 156);
            this.textBoxTask_GNA.TabIndex = 1;
            this.textBoxTask_GNA.Text = "Вычислить значение выражение по формуле";
            this.textBoxTask_GNA.TextChanged += new System.EventHandler(this.textBoxTask_TextChanged);
            // 
            // groupBoxVars_GNA
            // 
            this.groupBoxVars_GNA.Controls.Add(this.labelVarX_GNA);
            this.groupBoxVars_GNA.Controls.Add(this.textBoxVarX_GNA);
            this.groupBoxVars_GNA.Location = new System.Drawing.Point(12, 246);
            this.groupBoxVars_GNA.Name = "groupBoxVars_GNA";
            this.groupBoxVars_GNA.Size = new System.Drawing.Size(409, 145);
            this.groupBoxVars_GNA.TabIndex = 1;
            this.groupBoxVars_GNA.TabStop = false;
            this.groupBoxVars_GNA.Text = "Ввод данных";
            // 
            // groupBoxResult_GNA
            // 
            this.groupBoxResult_GNA.Controls.Add(this.labelResult_GNA);
            this.groupBoxResult_GNA.Controls.Add(this.textBoxResult_GNA);
            this.groupBoxResult_GNA.Location = new System.Drawing.Point(446, 246);
            this.groupBoxResult_GNA.Name = "groupBoxResult_GNA";
            this.groupBoxResult_GNA.Size = new System.Drawing.Size(342, 145);
            this.groupBoxResult_GNA.TabIndex = 2;
            this.groupBoxResult_GNA.TabStop = false;
            this.groupBoxResult_GNA.Text = "Вывод данных";
            // 
            // textBoxVarX_GNA
            // 
            this.textBoxVarX_GNA.Location = new System.Drawing.Point(10, 71);
            this.textBoxVarX_GNA.Name = "textBoxVarX_GNA";
            this.textBoxVarX_GNA.Size = new System.Drawing.Size(122, 26);
            this.textBoxVarX_GNA.TabIndex = 0;
            this.textBoxVarX_GNA.TextChanged += new System.EventHandler(this.textBoxVarX_GNA_TextChanged);
            // 
            // textBoxResult_GNA
            // 
            this.textBoxResult_GNA.Location = new System.Drawing.Point(24, 71);
            this.textBoxResult_GNA.Name = "textBoxResult_GNA";
            this.textBoxResult_GNA.ReadOnly = true;
            this.textBoxResult_GNA.Size = new System.Drawing.Size(205, 26);
            this.textBoxResult_GNA.TabIndex = 0;
            // 
            // labelResult_GNA
            // 
            this.labelResult_GNA.AutoSize = true;
            this.labelResult_GNA.Location = new System.Drawing.Point(20, 48);
            this.labelResult_GNA.Name = "labelResult_GNA";
            this.labelResult_GNA.Size = new System.Drawing.Size(93, 20);
            this.labelResult_GNA.TabIndex = 1;
            this.labelResult_GNA.Text = "Результат:";
            // 
            // labelVarX_GNA
            // 
            this.labelVarX_GNA.AutoSize = true;
            this.labelVarX_GNA.Location = new System.Drawing.Point(9, 48);
            this.labelVarX_GNA.Name = "labelVarX_GNA";
            this.labelVarX_GNA.Size = new System.Drawing.Size(123, 20);
            this.labelVarX_GNA.TabIndex = 1;
            this.labelVarX_GNA.Text = "Переменная X:";
            // 
            // buttonDone_GNA
            // 
            this.buttonDone_GNA.Location = new System.Drawing.Point(586, 397);
            this.buttonDone_GNA.Name = "buttonDone_GNA";
            this.buttonDone_GNA.Size = new System.Drawing.Size(196, 40);
            this.buttonDone_GNA.TabIndex = 3;
            this.buttonDone_GNA.Text = "Выполнить";
            this.buttonDone_GNA.UseVisualStyleBackColor = true;
            this.buttonDone_GNA.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonInfo_GNA
            // 
            this.buttonInfo_GNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_GNA.Location = new System.Drawing.Point(536, 397);
            this.buttonInfo_GNA.Name = "buttonInfo_GNA";
            this.buttonInfo_GNA.Size = new System.Drawing.Size(44, 41);
            this.buttonInfo_GNA.TabIndex = 4;
            this.buttonInfo_GNA.Text = "?";
            this.buttonInfo_GNA.UseVisualStyleBackColor = true;
            this.buttonInfo_GNA.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // FormMain_GNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo_GNA);
            this.Controls.Add(this.buttonDone_GNA);
            this.Controls.Add(this.groupBoxResult_GNA);
            this.Controls.Add(this.groupBoxVars_GNA);
            this.Controls.Add(this.groupBoxTask_GNA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_GNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 13 | Гунбин Н. А.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTask_GNA.ResumeLayout(false);
            this.groupBoxTask_GNA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormul_GNA)).EndInit();
            this.groupBoxVars_GNA.ResumeLayout(false);
            this.groupBoxVars_GNA.PerformLayout();
            this.groupBoxResult_GNA.ResumeLayout(false);
            this.groupBoxResult_GNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_GNA;
        private System.Windows.Forms.PictureBox pictureBoxFormul_GNA;
        private System.Windows.Forms.TextBox textBoxTask_GNA;
        private System.Windows.Forms.GroupBox groupBoxVars_GNA;
        private System.Windows.Forms.Label labelVarX_GNA;
        private System.Windows.Forms.TextBox textBoxVarX_GNA;
        private System.Windows.Forms.GroupBox groupBoxResult_GNA;
        private System.Windows.Forms.Label labelResult_GNA;
        private System.Windows.Forms.TextBox textBoxResult_GNA;
        private System.Windows.Forms.Button buttonDone_GNA;
        private System.Windows.Forms.Button buttonInfo_GNA;
    }
}

