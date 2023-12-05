
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
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut = new System.Windows.Forms.GroupBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.textBoxVarStart = new System.Windows.Forms.TextBox();
            this.textBoxVarStop = new System.Windows.Forms.TextBox();
            this.labelVarStart = new System.Windows.Forms.Label();
            this.labelVarStop = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxOutPut.SuspendLayout();
            this.groupBoxTask.SuspendLayout();
            this.groupBoxInPut.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.labelResult);
            this.groupBoxOutPut.Controls.Add(this.textBoxResult);
            this.groupBoxOutPut.Location = new System.Drawing.Point(585, 27);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(326, 496);
            this.groupBoxOutPut.TabIndex = 0;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод данных";
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 27);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(567, 345);
            this.groupBoxTask.TabIndex = 1;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            // 
            // groupBoxInPut
            // 
            this.groupBoxInPut.Controls.Add(this.labelVarStop);
            this.groupBoxInPut.Controls.Add(this.labelVarStart);
            this.groupBoxInPut.Controls.Add(this.textBoxVarStop);
            this.groupBoxInPut.Controls.Add(this.textBoxVarStart);
            this.groupBoxInPut.Location = new System.Drawing.Point(13, 379);
            this.groupBoxInPut.Name = "groupBoxInPut";
            this.groupBoxInPut.Size = new System.Drawing.Size(375, 143);
            this.groupBoxInPut.TabIndex = 2;
            this.groupBoxInPut.TabStop = false;
            this.groupBoxInPut.Text = "Ввод данных";
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(406, 389);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(161, 49);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(406, 459);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(161, 49);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Location = new System.Drawing.Point(19, 26);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(536, 313);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // textBoxVarStart
            // 
            this.textBoxVarStart.Location = new System.Drawing.Point(33, 80);
            this.textBoxVarStart.Name = "textBoxVarStart";
            this.textBoxVarStart.Size = new System.Drawing.Size(125, 26);
            this.textBoxVarStart.TabIndex = 0;
            // 
            // textBoxVarStop
            // 
            this.textBoxVarStop.Location = new System.Drawing.Point(199, 80);
            this.textBoxVarStop.Name = "textBoxVarStop";
            this.textBoxVarStop.Size = new System.Drawing.Size(125, 26);
            this.textBoxVarStop.TabIndex = 0;
            this.textBoxVarStop.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelVarStart
            // 
            this.labelVarStart.AutoSize = true;
            this.labelVarStart.Location = new System.Drawing.Point(33, 54);
            this.labelVarStart.Name = "labelVarStart";
            this.labelVarStart.Size = new System.Drawing.Size(102, 20);
            this.labelVarStart.TabIndex = 1;
            this.labelVarStart.Text = "Старт шага:";
            // 
            // labelVarStop
            // 
            this.labelVarStop.AutoSize = true;
            this.labelVarStop.Location = new System.Drawing.Point(195, 54);
            this.labelVarStop.Name = "labelVarStop";
            this.labelVarStop.Size = new System.Drawing.Size(101, 20);
            this.labelVarStop.TabIndex = 1;
            this.labelVarStop.Text = "Конец шага:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(7, 55);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(313, 435);
            this.textBoxResult.TabIndex = 0;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(7, 29);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(93, 20);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Результат:";
            // 
            // FormMain_GNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 534);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxInPut);
            this.Controls.Add(this.groupBoxTask);
            this.Controls.Add(this.groupBoxOutPut);
            this.MaximizeBox = false;
            this.Name = "FormMain_GNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 14 | Гунбин Н. А.";
            this.groupBoxOutPut.ResumeLayout(false);
            this.groupBoxOutPut.PerformLayout();
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxInPut.ResumeLayout(false);
            this.groupBoxInPut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInPut;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Label labelVarStop;
        private System.Windows.Forms.Label labelVarStart;
        private System.Windows.Forms.TextBox textBoxVarStop;
        private System.Windows.Forms.TextBox textBoxVarStart;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

