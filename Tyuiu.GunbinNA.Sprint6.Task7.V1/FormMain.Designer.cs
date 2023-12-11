
namespace Tyuiu.GunbinNA.Sprint6.Task7.V1
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
            this.panelOutPut_GNA = new System.Windows.Forms.Panel();
            this.panelInPut_GNA = new System.Windows.Forms.Panel();
            this.splitterOut_GNA = new System.Windows.Forms.Splitter();
            this.buttonDone_GNA = new System.Windows.Forms.Button();
            this.buttonOpenFile_GNA = new System.Windows.Forms.Button();
            this.buttonInfo_GNA = new System.Windows.Forms.Button();
            this.buttonSaveFile_GNA = new System.Windows.Forms.Button();
            this.groupBoxTask_GNA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GNA = new System.Windows.Forms.TextBox();
            this.groupBoxIn_GNA = new System.Windows.Forms.GroupBox();
            this.groupBoxOut_GNA = new System.Windows.Forms.GroupBox();
            this.openFileDialogTask_GNA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_GNA = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_GNA = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewIn_GNA = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut_GNA = new System.Windows.Forms.DataGridView();
            this.panelTask_GNA.SuspendLayout();
            this.panelOutPut_GNA.SuspendLayout();
            this.panelInPut_GNA.SuspendLayout();
            this.groupBoxTask_GNA.SuspendLayout();
            this.groupBoxIn_GNA.SuspendLayout();
            this.groupBoxOut_GNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GNA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_GNA
            // 
            this.panelTask_GNA.Controls.Add(this.groupBoxTask_GNA);
            this.panelTask_GNA.Controls.Add(this.buttonOpenFile_GNA);
            this.panelTask_GNA.Controls.Add(this.buttonInfo_GNA);
            this.panelTask_GNA.Controls.Add(this.buttonSaveFile_GNA);
            this.panelTask_GNA.Controls.Add(this.buttonDone_GNA);
            this.panelTask_GNA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_GNA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_GNA.Name = "panelTask_GNA";
            this.panelTask_GNA.Size = new System.Drawing.Size(1170, 187);
            this.panelTask_GNA.TabIndex = 0;
            // 
            // panelOutPut_GNA
            // 
            this.panelOutPut_GNA.BackColor = System.Drawing.SystemColors.Control;
            this.panelOutPut_GNA.Controls.Add(this.groupBoxOut_GNA);
            this.panelOutPut_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_GNA.Location = new System.Drawing.Point(0, 187);
            this.panelOutPut_GNA.Name = "panelOutPut_GNA";
            this.panelOutPut_GNA.Padding = new System.Windows.Forms.Padding(5);
            this.panelOutPut_GNA.Size = new System.Drawing.Size(1170, 535);
            this.panelOutPut_GNA.TabIndex = 0;
            // 
            // panelInPut_GNA
            // 
            this.panelInPut_GNA.Controls.Add(this.groupBoxIn_GNA);
            this.panelInPut_GNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_GNA.Location = new System.Drawing.Point(0, 187);
            this.panelInPut_GNA.Name = "panelInPut_GNA";
            this.panelInPut_GNA.Padding = new System.Windows.Forms.Padding(5);
            this.panelInPut_GNA.Size = new System.Drawing.Size(549, 535);
            this.panelInPut_GNA.TabIndex = 0;
            // 
            // splitterOut_GNA
            // 
            this.splitterOut_GNA.Location = new System.Drawing.Point(549, 187);
            this.splitterOut_GNA.Name = "splitterOut_GNA";
            this.splitterOut_GNA.Size = new System.Drawing.Size(3, 535);
            this.splitterOut_GNA.TabIndex = 1;
            this.splitterOut_GNA.TabStop = false;
            // 
            // buttonDone_GNA
            // 
            this.buttonDone_GNA.Enabled = false;
            this.buttonDone_GNA.Location = new System.Drawing.Point(150, 13);
            this.buttonDone_GNA.Name = "buttonDone_GNA";
            this.buttonDone_GNA.Size = new System.Drawing.Size(131, 53);
            this.buttonDone_GNA.TabIndex = 0;
            this.buttonDone_GNA.Text = "Выполнить";
            this.buttonDone_GNA.UseVisualStyleBackColor = true;
            this.buttonDone_GNA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile_GNA
            // 
            this.buttonOpenFile_GNA.Location = new System.Drawing.Point(13, 13);
            this.buttonOpenFile_GNA.Name = "buttonOpenFile_GNA";
            this.buttonOpenFile_GNA.Size = new System.Drawing.Size(131, 53);
            this.buttonOpenFile_GNA.TabIndex = 0;
            this.buttonOpenFile_GNA.Text = "Открыть файл";
            this.toolTipButton_GNA.SetToolTip(this.buttonOpenFile_GNA, "Открыть файл");
            this.buttonOpenFile_GNA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GNA.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonInfo_GNA
            // 
            this.buttonInfo_GNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GNA.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_GNA.Image")));
            this.buttonInfo_GNA.Location = new System.Drawing.Point(1031, 13);
            this.buttonInfo_GNA.Name = "buttonInfo_GNA";
            this.buttonInfo_GNA.Size = new System.Drawing.Size(127, 53);
            this.buttonInfo_GNA.TabIndex = 0;
            this.buttonInfo_GNA.UseVisualStyleBackColor = true;
            this.buttonInfo_GNA.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonSaveFile_GNA
            // 
            this.buttonSaveFile_GNA.Enabled = false;
            this.buttonSaveFile_GNA.Location = new System.Drawing.Point(287, 13);
            this.buttonSaveFile_GNA.Name = "buttonSaveFile_GNA";
            this.buttonSaveFile_GNA.Size = new System.Drawing.Size(131, 53);
            this.buttonSaveFile_GNA.TabIndex = 0;
            this.buttonSaveFile_GNA.Text = "Сохранить";
            this.buttonSaveFile_GNA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_GNA.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // groupBoxTask_GNA
            // 
            this.groupBoxTask_GNA.Controls.Add(this.textBoxTask_GNA);
            this.groupBoxTask_GNA.Location = new System.Drawing.Point(13, 73);
            this.groupBoxTask_GNA.Name = "groupBoxTask_GNA";
            this.groupBoxTask_GNA.Size = new System.Drawing.Size(1102, 100);
            this.groupBoxTask_GNA.TabIndex = 1;
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
            this.textBoxTask_GNA.Size = new System.Drawing.Size(1096, 75);
            this.textBoxTask_GNA.TabIndex = 0;
            this.textBoxTask_GNA.Text = resources.GetString("textBoxTask_GNA.Text");
            // 
            // groupBoxIn_GNA
            // 
            this.groupBoxIn_GNA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxIn_GNA.Controls.Add(this.dataGridViewIn_GNA);
            this.groupBoxIn_GNA.Location = new System.Drawing.Point(8, 8);
            this.groupBoxIn_GNA.Name = "groupBoxIn_GNA";
            this.groupBoxIn_GNA.Size = new System.Drawing.Size(533, 527);
            this.groupBoxIn_GNA.TabIndex = 0;
            this.groupBoxIn_GNA.TabStop = false;
            this.groupBoxIn_GNA.Text = "Ввод данных";
            // 
            // groupBoxOut_GNA
            // 
            this.groupBoxOut_GNA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOut_GNA.Controls.Add(this.dataGridViewOut_GNA);
            this.groupBoxOut_GNA.Location = new System.Drawing.Point(555, 8);
            this.groupBoxOut_GNA.Name = "groupBoxOut_GNA";
            this.groupBoxOut_GNA.Size = new System.Drawing.Size(603, 527);
            this.groupBoxOut_GNA.TabIndex = 0;
            this.groupBoxOut_GNA.TabStop = false;
            this.groupBoxOut_GNA.Text = "Вывод данных";
            // 
            // openFileDialogTask_GNA
            // 
            this.openFileDialogTask_GNA.FileName = "openFileDialog1";
            // 
            // toolTipButton_GNA
            // 
            this.toolTipButton_GNA.IsBalloon = true;
            this.toolTipButton_GNA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_GNA.ToolTipTitle = "Подсказка";
            // 
            // dataGridViewIn_GNA
            // 
            this.dataGridViewIn_GNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_GNA.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewIn_GNA.Name = "dataGridViewIn_GNA";
            this.dataGridViewIn_GNA.ReadOnly = true;
            this.dataGridViewIn_GNA.RowHeadersVisible = false;
            this.dataGridViewIn_GNA.RowHeadersWidth = 62;
            this.dataGridViewIn_GNA.RowTemplate.Height = 28;
            this.dataGridViewIn_GNA.Size = new System.Drawing.Size(527, 502);
            this.dataGridViewIn_GNA.TabIndex = 0;
            // 
            // dataGridViewOut_GNA
            // 
            this.dataGridViewOut_GNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_GNA.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewOut_GNA.Name = "dataGridViewOut_GNA";
            this.dataGridViewOut_GNA.ReadOnly = true;
            this.dataGridViewOut_GNA.RowHeadersVisible = false;
            this.dataGridViewOut_GNA.RowHeadersWidth = 62;
            this.dataGridViewOut_GNA.RowTemplate.Height = 28;
            this.dataGridViewOut_GNA.Size = new System.Drawing.Size(597, 502);
            this.dataGridViewOut_GNA.TabIndex = 0;
            // 
            // FormMain_GNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 722);
            this.Controls.Add(this.splitterOut_GNA);
            this.Controls.Add(this.panelInPut_GNA);
            this.Controls.Add(this.panelOutPut_GNA);
            this.Controls.Add(this.panelTask_GNA);
            this.MinimumSize = new System.Drawing.Size(1192, 772);
            this.Name = "FormMain_GNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 1 | Гунбин Н. А.";
            this.panelTask_GNA.ResumeLayout(false);
            this.panelOutPut_GNA.ResumeLayout(false);
            this.panelInPut_GNA.ResumeLayout(false);
            this.groupBoxTask_GNA.ResumeLayout(false);
            this.groupBoxTask_GNA.PerformLayout();
            this.groupBoxIn_GNA.ResumeLayout(false);
            this.groupBoxOut_GNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_GNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_GNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_GNA;
        private System.Windows.Forms.GroupBox groupBoxTask_GNA;
        private System.Windows.Forms.TextBox textBoxTask_GNA;
        private System.Windows.Forms.Button buttonOpenFile_GNA;
        private System.Windows.Forms.Button buttonInfo_GNA;
        private System.Windows.Forms.Button buttonSaveFile_GNA;
        private System.Windows.Forms.Button buttonDone_GNA;
        private System.Windows.Forms.Panel panelOutPut_GNA;
        private System.Windows.Forms.Panel panelInPut_GNA;
        private System.Windows.Forms.Splitter splitterOut_GNA;
        private System.Windows.Forms.GroupBox groupBoxOut_GNA;
        private System.Windows.Forms.GroupBox groupBoxIn_GNA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GNA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_GNA;
        private System.Windows.Forms.ToolTip toolTipButton_GNA;
        private System.Windows.Forms.DataGridView dataGridViewOut_GNA;
        private System.Windows.Forms.DataGridView dataGridViewIn_GNA;
    }
}

