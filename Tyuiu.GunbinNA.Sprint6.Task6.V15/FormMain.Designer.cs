
namespace Tyuiu.GunbinNA.Sprint6.Task6.V15
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_GNA));
            this.panelTask_GNA = new System.Windows.Forms.Panel();
            this.buttonDone_GNA = new System.Windows.Forms.Button();
            this.buttonOpenFile_GNA = new System.Windows.Forms.Button();
            this.buttonInfo_GNA = new System.Windows.Forms.Button();
            this.groupBoxTask_GNA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GNA = new System.Windows.Forms.TextBox();
            this.panelInPut_GNA = new System.Windows.Forms.Panel();
            this.groupBoxIn_GNA = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_GNA = new System.Windows.Forms.TextBox();
            this.panelOutPut_GNA = new System.Windows.Forms.Panel();
            this.groupBoxOut_GNA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_GNA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_GNA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_GNA = new System.Windows.Forms.ToolTip(this.components);
            this.panelTask_GNA.SuspendLayout();
            this.groupBoxTask_GNA.SuspendLayout();
            this.panelInPut_GNA.SuspendLayout();
            this.groupBoxIn_GNA.SuspendLayout();
            this.panelOutPut_GNA.SuspendLayout();
            this.groupBoxOut_GNA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTask_GNA
            // 
            this.panelTask_GNA.Controls.Add(this.buttonDone_GNA);
            this.panelTask_GNA.Controls.Add(this.buttonOpenFile_GNA);
            this.panelTask_GNA.Controls.Add(this.buttonInfo_GNA);
            this.panelTask_GNA.Controls.Add(this.groupBoxTask_GNA);
            this.panelTask_GNA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_GNA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_GNA.Name = "panelTask_GNA";
            this.panelTask_GNA.Size = new System.Drawing.Size(1060, 184);
            this.panelTask_GNA.TabIndex = 0;
            // 
            // buttonDone_GNA
            // 
            this.buttonDone_GNA.Enabled = false;
            this.buttonDone_GNA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDone_GNA.Location = new System.Drawing.Point(187, 13);
            this.buttonDone_GNA.Name = "buttonDone_GNA";
            this.buttonDone_GNA.Size = new System.Drawing.Size(164, 68);
            this.buttonDone_GNA.TabIndex = 1;
            this.buttonDone_GNA.Text = "Выполнить";
            this.toolTip_GNA.SetToolTip(this.buttonDone_GNA, "Проходит по каждой строке в файле и выводит \r\nпоследнее слово в каждой.\r\n\r\n");
            this.buttonDone_GNA.UseVisualStyleBackColor = true;
            this.buttonDone_GNA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile_GNA
            // 
            this.buttonOpenFile_GNA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenFile_GNA.Location = new System.Drawing.Point(15, 13);
            this.buttonOpenFile_GNA.Name = "buttonOpenFile_GNA";
            this.buttonOpenFile_GNA.Size = new System.Drawing.Size(166, 68);
            this.buttonOpenFile_GNA.TabIndex = 1;
            this.buttonOpenFile_GNA.Text = "Открыть файл";
            this.toolTip_GNA.SetToolTip(this.buttonOpenFile_GNA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n\r\n");
            this.buttonOpenFile_GNA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GNA.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonInfo_GNA
            // 
            this.buttonInfo_GNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GNA.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_GNA.Image")));
            this.buttonInfo_GNA.Location = new System.Drawing.Point(928, 13);
            this.buttonInfo_GNA.Name = "buttonInfo_GNA";
            this.buttonInfo_GNA.Size = new System.Drawing.Size(111, 68);
            this.buttonInfo_GNA.TabIndex = 1;
            this.toolTip_GNA.SetToolTip(this.buttonInfo_GNA, "Сведения о программе");
            this.buttonInfo_GNA.UseVisualStyleBackColor = true;
            this.buttonInfo_GNA.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // groupBoxTask_GNA
            // 
            this.groupBoxTask_GNA.Controls.Add(this.textBoxTask_GNA);
            this.groupBoxTask_GNA.Location = new System.Drawing.Point(12, 87);
            this.groupBoxTask_GNA.Name = "groupBoxTask_GNA";
            this.groupBoxTask_GNA.Size = new System.Drawing.Size(979, 91);
            this.groupBoxTask_GNA.TabIndex = 0;
            this.groupBoxTask_GNA.TabStop = false;
            this.groupBoxTask_GNA.Text = "Условие";
            // 
            // textBoxTask_GNA
            // 
            this.textBoxTask_GNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_GNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_GNA.Location = new System.Drawing.Point(3, 22);
            this.textBoxTask_GNA.Multiline = true;
            this.textBoxTask_GNA.Name = "textBoxTask_GNA";
            this.textBoxTask_GNA.ReadOnly = true;
            this.textBoxTask_GNA.Size = new System.Drawing.Size(973, 66);
            this.textBoxTask_GNA.TabIndex = 0;
            this.textBoxTask_GNA.Text = resources.GetString("textBoxTask_GNA.Text");
            // 
            // panelInPut_GNA
            // 
            this.panelInPut_GNA.Controls.Add(this.groupBoxIn_GNA);
            this.panelInPut_GNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_GNA.Location = new System.Drawing.Point(0, 184);
            this.panelInPut_GNA.Name = "panelInPut_GNA";
            this.panelInPut_GNA.Padding = new System.Windows.Forms.Padding(5);
            this.panelInPut_GNA.Size = new System.Drawing.Size(516, 388);
            this.panelInPut_GNA.TabIndex = 0;
            // 
            // groupBoxIn_GNA
            // 
            this.groupBoxIn_GNA.Controls.Add(this.textBoxInPut_GNA);
            this.groupBoxIn_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIn_GNA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxIn_GNA.Name = "groupBoxIn_GNA";
            this.groupBoxIn_GNA.Size = new System.Drawing.Size(506, 378);
            this.groupBoxIn_GNA.TabIndex = 0;
            this.groupBoxIn_GNA.TabStop = false;
            this.groupBoxIn_GNA.Text = "Ввод";
            // 
            // textBoxInPut_GNA
            // 
            this.textBoxInPut_GNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxInPut_GNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInPut_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_GNA.Location = new System.Drawing.Point(3, 22);
            this.textBoxInPut_GNA.Multiline = true;
            this.textBoxInPut_GNA.Name = "textBoxInPut_GNA";
            this.textBoxInPut_GNA.ReadOnly = true;
            this.textBoxInPut_GNA.Size = new System.Drawing.Size(500, 353);
            this.textBoxInPut_GNA.TabIndex = 0;
            // 
            // panelOutPut_GNA
            // 
            this.panelOutPut_GNA.Controls.Add(this.groupBoxOut_GNA);
            this.panelOutPut_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_GNA.Location = new System.Drawing.Point(516, 184);
            this.panelOutPut_GNA.Name = "panelOutPut_GNA";
            this.panelOutPut_GNA.Padding = new System.Windows.Forms.Padding(5);
            this.panelOutPut_GNA.Size = new System.Drawing.Size(544, 388);
            this.panelOutPut_GNA.TabIndex = 0;
            // 
            // groupBoxOut_GNA
            // 
            this.groupBoxOut_GNA.Controls.Add(this.textBoxOutPut_GNA);
            this.groupBoxOut_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOut_GNA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOut_GNA.Name = "groupBoxOut_GNA";
            this.groupBoxOut_GNA.Size = new System.Drawing.Size(534, 378);
            this.groupBoxOut_GNA.TabIndex = 0;
            this.groupBoxOut_GNA.TabStop = false;
            this.groupBoxOut_GNA.Text = "Вывод";
            // 
            // textBoxOutPut_GNA
            // 
            this.textBoxOutPut_GNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxOutPut_GNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutPut_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_GNA.Location = new System.Drawing.Point(3, 22);
            this.textBoxOutPut_GNA.Multiline = true;
            this.textBoxOutPut_GNA.Name = "textBoxOutPut_GNA";
            this.textBoxOutPut_GNA.ReadOnly = true;
            this.textBoxOutPut_GNA.Size = new System.Drawing.Size(528, 353);
            this.textBoxOutPut_GNA.TabIndex = 0;
            // 
            // openFileDialogTask_GNA
            // 
            this.openFileDialogTask_GNA.FileName = "openFileDialog1";
            // 
            // toolTip_GNA
            // 
            this.toolTip_GNA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_GNA.ToolTipTitle = "Подсказка";
            // 
            // FormMain_GNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 572);
            this.Controls.Add(this.panelOutPut_GNA);
            this.Controls.Add(this.panelInPut_GNA);
            this.Controls.Add(this.panelTask_GNA);
            this.MinimumSize = new System.Drawing.Size(1082, 622);
            this.Name = "FormMain_GNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 15 | Гунбин Н. А.";
            this.panelTask_GNA.ResumeLayout(false);
            this.groupBoxTask_GNA.ResumeLayout(false);
            this.groupBoxTask_GNA.PerformLayout();
            this.panelInPut_GNA.ResumeLayout(false);
            this.groupBoxIn_GNA.ResumeLayout(false);
            this.groupBoxIn_GNA.PerformLayout();
            this.panelOutPut_GNA.ResumeLayout(false);
            this.groupBoxOut_GNA.ResumeLayout(false);
            this.groupBoxOut_GNA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_GNA;
        private System.Windows.Forms.Button buttonDone_GNA;
        private System.Windows.Forms.Button buttonOpenFile_GNA;
        private System.Windows.Forms.Button buttonInfo_GNA;
        private System.Windows.Forms.GroupBox groupBoxTask_GNA;
        private System.Windows.Forms.TextBox textBoxTask_GNA;
        private System.Windows.Forms.Panel panelInPut_GNA;
        private System.Windows.Forms.GroupBox groupBoxIn_GNA;
        private System.Windows.Forms.Panel panelOutPut_GNA;
        private System.Windows.Forms.GroupBox groupBoxOut_GNA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GNA;
        private System.Windows.Forms.ToolTip toolTip_GNA;
        private System.Windows.Forms.TextBox textBoxOutPut_GNA;
        private System.Windows.Forms.TextBox textBoxInPut_GNA;
    }
}

