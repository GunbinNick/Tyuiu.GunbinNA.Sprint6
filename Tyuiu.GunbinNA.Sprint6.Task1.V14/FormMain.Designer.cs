
namespace Tyuiu.GunbinNA.Sprint6.Task1.V14
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
            this.groupBoxOutPut_GNA = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_GNA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_GNA = new System.Windows.Forms.GroupBox();
            this.buttonDone_GNA = new System.Windows.Forms.Button();
            this.buttonInfo_GNA = new System.Windows.Forms.Button();
            this.textBoxTask_GNA = new System.Windows.Forms.TextBox();
            this.textBoxVarStart_GNA = new System.Windows.Forms.TextBox();
            this.textBoxVarStop_GNA = new System.Windows.Forms.TextBox();
            this.labelVarStart_GNA = new System.Windows.Forms.Label();
            this.labelVarStop_GNA = new System.Windows.Forms.Label();
            this.textBoxResult_GNA = new System.Windows.Forms.TextBox();
            this.labelResult_GNA = new System.Windows.Forms.Label();
            this.groupBoxOutPut_GNA.SuspendLayout();
            this.groupBoxTask_GNA.SuspendLayout();
            this.groupBoxInPut_GNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOutPut_GNA
            // 
            this.groupBoxOutPut_GNA.Controls.Add(this.labelResult_GNA);
            this.groupBoxOutPut_GNA.Controls.Add(this.textBoxResult_GNA);
            this.groupBoxOutPut_GNA.Location = new System.Drawing.Point(585, 27);
            this.groupBoxOutPut_GNA.Name = "groupBoxOutPut_GNA";
            this.groupBoxOutPut_GNA.Size = new System.Drawing.Size(326, 496);
            this.groupBoxOutPut_GNA.TabIndex = 0;
            this.groupBoxOutPut_GNA.TabStop = false;
            this.groupBoxOutPut_GNA.Text = "Вывод данных";
            // 
            // groupBoxTask_GNA
            // 
            this.groupBoxTask_GNA.Controls.Add(this.textBoxTask_GNA);
            this.groupBoxTask_GNA.Location = new System.Drawing.Point(12, 27);
            this.groupBoxTask_GNA.Name = "groupBoxTask_GNA";
            this.groupBoxTask_GNA.Size = new System.Drawing.Size(567, 345);
            this.groupBoxTask_GNA.TabIndex = 1;
            this.groupBoxTask_GNA.TabStop = false;
            this.groupBoxTask_GNA.Text = "Условие";
            // 
            // groupBoxInPut_GNA
            // 
            this.groupBoxInPut_GNA.Controls.Add(this.labelVarStop_GNA);
            this.groupBoxInPut_GNA.Controls.Add(this.labelVarStart_GNA);
            this.groupBoxInPut_GNA.Controls.Add(this.textBoxVarStop_GNA);
            this.groupBoxInPut_GNA.Controls.Add(this.textBoxVarStart_GNA);
            this.groupBoxInPut_GNA.Location = new System.Drawing.Point(13, 379);
            this.groupBoxInPut_GNA.Name = "groupBoxInPut_GNA";
            this.groupBoxInPut_GNA.Size = new System.Drawing.Size(375, 143);
            this.groupBoxInPut_GNA.TabIndex = 2;
            this.groupBoxInPut_GNA.TabStop = false;
            this.groupBoxInPut_GNA.Text = "Ввод данных";
            // 
            // buttonDone_GNA
            // 
            this.buttonDone_GNA.Location = new System.Drawing.Point(406, 389);
            this.buttonDone_GNA.Name = "buttonDone_GNA";
            this.buttonDone_GNA.Size = new System.Drawing.Size(161, 49);
            this.buttonDone_GNA.TabIndex = 3;
            this.buttonDone_GNA.Text = "Выполнить";
            this.buttonDone_GNA.UseVisualStyleBackColor = true;
            this.buttonDone_GNA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonInfo_GNA
            // 
            this.buttonInfo_GNA.Location = new System.Drawing.Point(406, 459);
            this.buttonInfo_GNA.Name = "buttonInfo_GNA";
            this.buttonInfo_GNA.Size = new System.Drawing.Size(161, 49);
            this.buttonInfo_GNA.TabIndex = 3;
            this.buttonInfo_GNA.Text = "Справка";
            this.buttonInfo_GNA.UseVisualStyleBackColor = true;
            this.buttonInfo_GNA.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // textBoxTask_GNA
            // 
            this.textBoxTask_GNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_GNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GNA.Location = new System.Drawing.Point(19, 26);
            this.textBoxTask_GNA.Multiline = true;
            this.textBoxTask_GNA.Name = "textBoxTask_GNA";
            this.textBoxTask_GNA.ReadOnly = true;
            this.textBoxTask_GNA.Size = new System.Drawing.Size(536, 313);
            this.textBoxTask_GNA.TabIndex = 0;
            this.textBoxTask_GNA.Text = resources.GetString("textBoxTask_GNA.Text");
            // 
            // textBoxVarStart_GNA
            // 
            this.textBoxVarStart_GNA.Location = new System.Drawing.Point(33, 80);
            this.textBoxVarStart_GNA.Name = "textBoxVarStart_GNA";
            this.textBoxVarStart_GNA.Size = new System.Drawing.Size(125, 26);
            this.textBoxVarStart_GNA.TabIndex = 0;
            // 
            // textBoxVarStop_GNA
            // 
            this.textBoxVarStop_GNA.Location = new System.Drawing.Point(199, 80);
            this.textBoxVarStop_GNA.Name = "textBoxVarStop_GNA";
            this.textBoxVarStop_GNA.Size = new System.Drawing.Size(125, 26);
            this.textBoxVarStop_GNA.TabIndex = 0;
            this.textBoxVarStop_GNA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelVarStart_GNA
            // 
            this.labelVarStart_GNA.AutoSize = true;
            this.labelVarStart_GNA.Location = new System.Drawing.Point(33, 54);
            this.labelVarStart_GNA.Name = "labelVarStart_GNA";
            this.labelVarStart_GNA.Size = new System.Drawing.Size(102, 20);
            this.labelVarStart_GNA.TabIndex = 1;
            this.labelVarStart_GNA.Text = "Старт шага:";
            // 
            // labelVarStop_GNA
            // 
            this.labelVarStop_GNA.AutoSize = true;
            this.labelVarStop_GNA.Location = new System.Drawing.Point(195, 54);
            this.labelVarStop_GNA.Name = "labelVarStop_GNA";
            this.labelVarStop_GNA.Size = new System.Drawing.Size(101, 20);
            this.labelVarStop_GNA.TabIndex = 1;
            this.labelVarStop_GNA.Text = "Конец шага:";
            // 
            // textBoxResult_GNA
            // 
            this.textBoxResult_GNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResult_GNA.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_GNA.Location = new System.Drawing.Point(7, 55);
            this.textBoxResult_GNA.Multiline = true;
            this.textBoxResult_GNA.Name = "textBoxResult_GNA";
            this.textBoxResult_GNA.ReadOnly = true;
            this.textBoxResult_GNA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_GNA.Size = new System.Drawing.Size(313, 435);
            this.textBoxResult_GNA.TabIndex = 0;
            // 
            // labelResult_GNA
            // 
            this.labelResult_GNA.AutoSize = true;
            this.labelResult_GNA.Location = new System.Drawing.Point(7, 29);
            this.labelResult_GNA.Name = "labelResult_GNA";
            this.labelResult_GNA.Size = new System.Drawing.Size(93, 20);
            this.labelResult_GNA.TabIndex = 1;
            this.labelResult_GNA.Text = "Результат:";
            // 
            // FormMain_GNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 534);
            this.Controls.Add(this.buttonInfo_GNA);
            this.Controls.Add(this.buttonDone_GNA);
            this.Controls.Add(this.groupBoxInPut_GNA);
            this.Controls.Add(this.groupBoxTask_GNA);
            this.Controls.Add(this.groupBoxOutPut_GNA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_GNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 14 | Гунбин Н. А.";
            this.groupBoxOutPut_GNA.ResumeLayout(false);
            this.groupBoxOutPut_GNA.PerformLayout();
            this.groupBoxTask_GNA.ResumeLayout(false);
            this.groupBoxTask_GNA.PerformLayout();
            this.groupBoxInPut_GNA.ResumeLayout(false);
            this.groupBoxInPut_GNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOutPut_GNA;
        private System.Windows.Forms.GroupBox groupBoxTask_GNA;
        private System.Windows.Forms.GroupBox groupBoxInPut_GNA;
        private System.Windows.Forms.Button buttonDone_GNA;
        private System.Windows.Forms.Button buttonInfo_GNA;
        private System.Windows.Forms.TextBox textBoxTask_GNA;
        private System.Windows.Forms.Label labelVarStop_GNA;
        private System.Windows.Forms.Label labelVarStart_GNA;
        private System.Windows.Forms.TextBox textBoxVarStop_GNA;
        private System.Windows.Forms.TextBox textBoxVarStart_GNA;
        private System.Windows.Forms.Label labelResult_GNA;
        private System.Windows.Forms.TextBox textBoxResult_GNA;
    }
}

