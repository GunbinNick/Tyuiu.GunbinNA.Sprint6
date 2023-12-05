
namespace Tyuiu.GunbinNA.Sprint6.Task2.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_GNA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GNA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_GNA = new System.Windows.Forms.GroupBox();
            this.labelVarStop_GNA = new System.Windows.Forms.Label();
            this.labelVarStart_GNA = new System.Windows.Forms.Label();
            this.textBoxVarStop_GNA = new System.Windows.Forms.TextBox();
            this.textBoxVarStart_GNA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_GNA = new System.Windows.Forms.GroupBox();
            this.chartFunction_GNA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridResult_GNA = new System.Windows.Forms.DataGridView();
            this.ColumnX_GNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFx_GNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_GNA = new System.Windows.Forms.Button();
            this.buttonInfo_GNA = new System.Windows.Forms.Button();
            this.groupBoxTask_GNA.SuspendLayout();
            this.groupBoxInPut_GNA.SuspendLayout();
            this.groupBoxOutPut_GNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult_GNA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_GNA
            // 
            this.groupBoxTask_GNA.Controls.Add(this.textBoxTask_GNA);
            this.groupBoxTask_GNA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_GNA.Name = "groupBoxTask_GNA";
            this.groupBoxTask_GNA.Size = new System.Drawing.Size(608, 322);
            this.groupBoxTask_GNA.TabIndex = 0;
            this.groupBoxTask_GNA.TabStop = false;
            this.groupBoxTask_GNA.Text = "Условие";
            // 
            // textBoxTask_GNA
            // 
            this.textBoxTask_GNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTask_GNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_GNA.Location = new System.Drawing.Point(7, 25);
            this.textBoxTask_GNA.Multiline = true;
            this.textBoxTask_GNA.Name = "textBoxTask_GNA";
            this.textBoxTask_GNA.ReadOnly = true;
            this.textBoxTask_GNA.Size = new System.Drawing.Size(595, 291);
            this.textBoxTask_GNA.TabIndex = 0;
            this.textBoxTask_GNA.Text = resources.GetString("textBoxTask_GNA.Text");
            // 
            // groupBoxInPut_GNA
            // 
            this.groupBoxInPut_GNA.Controls.Add(this.labelVarStop_GNA);
            this.groupBoxInPut_GNA.Controls.Add(this.labelVarStart_GNA);
            this.groupBoxInPut_GNA.Controls.Add(this.textBoxVarStop_GNA);
            this.groupBoxInPut_GNA.Controls.Add(this.textBoxVarStart_GNA);
            this.groupBoxInPut_GNA.Location = new System.Drawing.Point(13, 342);
            this.groupBoxInPut_GNA.Name = "groupBoxInPut_GNA";
            this.groupBoxInPut_GNA.Size = new System.Drawing.Size(392, 134);
            this.groupBoxInPut_GNA.TabIndex = 1;
            this.groupBoxInPut_GNA.TabStop = false;
            this.groupBoxInPut_GNA.Text = "Ввод данных";
            // 
            // labelVarStop_GNA
            // 
            this.labelVarStop_GNA.AutoSize = true;
            this.labelVarStop_GNA.Location = new System.Drawing.Point(187, 50);
            this.labelVarStop_GNA.Name = "labelVarStop_GNA";
            this.labelVarStop_GNA.Size = new System.Drawing.Size(101, 20);
            this.labelVarStop_GNA.TabIndex = 1;
            this.labelVarStop_GNA.Text = "Конец шага:";
            this.labelVarStop_GNA.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelVarStart_GNA
            // 
            this.labelVarStart_GNA.AutoSize = true;
            this.labelVarStart_GNA.Location = new System.Drawing.Point(21, 50);
            this.labelVarStart_GNA.Name = "labelVarStart_GNA";
            this.labelVarStart_GNA.Size = new System.Drawing.Size(102, 20);
            this.labelVarStart_GNA.TabIndex = 1;
            this.labelVarStart_GNA.Text = "Старт шага:";
            this.labelVarStart_GNA.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxVarStop_GNA
            // 
            this.textBoxVarStop_GNA.Location = new System.Drawing.Point(191, 84);
            this.textBoxVarStop_GNA.Name = "textBoxVarStop_GNA";
            this.textBoxVarStop_GNA.Size = new System.Drawing.Size(114, 26);
            this.textBoxVarStop_GNA.TabIndex = 0;
            // 
            // textBoxVarStart_GNA
            // 
            this.textBoxVarStart_GNA.Location = new System.Drawing.Point(25, 84);
            this.textBoxVarStart_GNA.Name = "textBoxVarStart_GNA";
            this.textBoxVarStart_GNA.Size = new System.Drawing.Size(114, 26);
            this.textBoxVarStart_GNA.TabIndex = 0;
            // 
            // groupBoxOutPut_GNA
            // 
            this.groupBoxOutPut_GNA.Controls.Add(this.chartFunction_GNA);
            this.groupBoxOutPut_GNA.Controls.Add(this.dataGridResult_GNA);
            this.groupBoxOutPut_GNA.Location = new System.Drawing.Point(637, 13);
            this.groupBoxOutPut_GNA.Name = "groupBoxOutPut_GNA";
            this.groupBoxOutPut_GNA.Size = new System.Drawing.Size(753, 491);
            this.groupBoxOutPut_GNA.TabIndex = 2;
            this.groupBoxOutPut_GNA.TabStop = false;
            this.groupBoxOutPut_GNA.Text = "Вывод данных";
            // 
            // chartFunction_GNA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_GNA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_GNA.Legends.Add(legend2);
            this.chartFunction_GNA.Location = new System.Drawing.Point(198, 25);
            this.chartFunction_GNA.Name = "chartFunction_GNA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_GNA.Series.Add(series2);
            this.chartFunction_GNA.Size = new System.Drawing.Size(425, 460);
            this.chartFunction_GNA.TabIndex = 1;
            this.chartFunction_GNA.Text = "chart1";
            // 
            // dataGridResult_GNA
            // 
            this.dataGridResult_GNA.AllowUserToDeleteRows = false;
            this.dataGridResult_GNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult_GNA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_GNA,
            this.ColumnFx_GNA});
            this.dataGridResult_GNA.Location = new System.Drawing.Point(6, 25);
            this.dataGridResult_GNA.Name = "dataGridResult_GNA";
            this.dataGridResult_GNA.ReadOnly = true;
            this.dataGridResult_GNA.RowHeadersVisible = false;
            this.dataGridResult_GNA.RowHeadersWidth = 62;
            this.dataGridResult_GNA.RowTemplate.Height = 28;
            this.dataGridResult_GNA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridResult_GNA.Size = new System.Drawing.Size(172, 459);
            this.dataGridResult_GNA.TabIndex = 0;
            // 
            // ColumnX_GNA
            // 
            this.ColumnX_GNA.HeaderText = "X";
            this.ColumnX_GNA.MinimumWidth = 8;
            this.ColumnX_GNA.Name = "ColumnX_GNA";
            this.ColumnX_GNA.ReadOnly = true;
            this.ColumnX_GNA.Width = 50;
            // 
            // ColumnFx_GNA
            // 
            this.ColumnFx_GNA.HeaderText = "F(X)";
            this.ColumnFx_GNA.MinimumWidth = 8;
            this.ColumnFx_GNA.Name = "ColumnFx_GNA";
            this.ColumnFx_GNA.ReadOnly = true;
            this.ColumnFx_GNA.Width = 50;
            // 
            // buttonDone_GNA
            // 
            this.buttonDone_GNA.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDone_GNA.Location = new System.Drawing.Point(423, 362);
            this.buttonDone_GNA.Name = "buttonDone_GNA";
            this.buttonDone_GNA.Size = new System.Drawing.Size(198, 50);
            this.buttonDone_GNA.TabIndex = 3;
            this.buttonDone_GNA.Text = "Выполнить";
            this.buttonDone_GNA.UseVisualStyleBackColor = false;
            this.buttonDone_GNA.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone_GNA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MouseDown);
            this.buttonDone_GNA.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone_GNA.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // buttonInfo_GNA
            // 
            this.buttonInfo_GNA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_GNA.Location = new System.Drawing.Point(423, 447);
            this.buttonInfo_GNA.Name = "buttonInfo_GNA";
            this.buttonInfo_GNA.Size = new System.Drawing.Size(198, 50);
            this.buttonInfo_GNA.TabIndex = 3;
            this.buttonInfo_GNA.Text = "Справка";
            this.buttonInfo_GNA.UseVisualStyleBackColor = false;
            this.buttonInfo_GNA.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // FormMain_GNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 513);
            this.Controls.Add(this.buttonInfo_GNA);
            this.Controls.Add(this.buttonDone_GNA);
            this.Controls.Add(this.groupBoxOutPut_GNA);
            this.Controls.Add(this.groupBoxInPut_GNA);
            this.Controls.Add(this.groupBoxTask_GNA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormMain_GNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 3 | Гунбин Н. А.";
            this.groupBoxTask_GNA.ResumeLayout(false);
            this.groupBoxTask_GNA.PerformLayout();
            this.groupBoxInPut_GNA.ResumeLayout(false);
            this.groupBoxInPut_GNA.PerformLayout();
            this.groupBoxOutPut_GNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult_GNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_GNA;
        private System.Windows.Forms.GroupBox groupBoxInPut_GNA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GNA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GNA;
        private System.Windows.Forms.DataGridView dataGridResult_GNA;
        private System.Windows.Forms.Button buttonDone_GNA;
        private System.Windows.Forms.Button buttonInfo_GNA;
        private System.Windows.Forms.TextBox textBoxTask_GNA;
        private System.Windows.Forms.Label labelVarStart_GNA;
        private System.Windows.Forms.TextBox textBoxVarStop_GNA;
        private System.Windows.Forms.TextBox textBoxVarStart_GNA;
        private System.Windows.Forms.Label labelVarStop_GNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_GNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx_GNA;
    }
}

