
namespace Tyuiu.GunbinNA.Sprint6.Task5.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTask_GNA = new System.Windows.Forms.Panel();
            this.buttonInfo_GNA = new System.Windows.Forms.Button();
            this.buttonOpenFile_GNA = new System.Windows.Forms.Button();
            this.buttonDone_GNA = new System.Windows.Forms.Button();
            this.groupBoxTask_GNA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_GNA = new System.Windows.Forms.TextBox();
            this.panelGraph_GNA = new System.Windows.Forms.Panel();
            this.chartFunction_GNA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelOutPut_GNA = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_GNA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_GNA = new System.Windows.Forms.DataGridView();
            this.splitterOutPut_GNA = new System.Windows.Forms.Splitter();
            this.panelTask_GNA.SuspendLayout();
            this.groupBoxTask_GNA.SuspendLayout();
            this.panelGraph_GNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GNA)).BeginInit();
            this.panelOutPut_GNA.SuspendLayout();
            this.groupBoxOutPut_GNA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GNA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_GNA
            // 
            this.panelTask_GNA.Controls.Add(this.buttonInfo_GNA);
            this.panelTask_GNA.Controls.Add(this.buttonOpenFile_GNA);
            this.panelTask_GNA.Controls.Add(this.buttonDone_GNA);
            this.panelTask_GNA.Controls.Add(this.groupBoxTask_GNA);
            this.panelTask_GNA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_GNA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_GNA.Name = "panelTask_GNA";
            this.panelTask_GNA.Size = new System.Drawing.Size(1060, 143);
            this.panelTask_GNA.TabIndex = 0;
            // 
            // buttonInfo_GNA
            // 
            this.buttonInfo_GNA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_GNA.Location = new System.Drawing.Point(954, 12);
            this.buttonInfo_GNA.Name = "buttonInfo_GNA";
            this.buttonInfo_GNA.Size = new System.Drawing.Size(94, 125);
            this.buttonInfo_GNA.TabIndex = 1;
            this.buttonInfo_GNA.Text = "Справка";
            this.buttonInfo_GNA.UseVisualStyleBackColor = true;
            this.buttonInfo_GNA.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonOpenFile_GNA
            // 
            this.buttonOpenFile_GNA.Location = new System.Drawing.Point(845, 12);
            this.buttonOpenFile_GNA.Name = "buttonOpenFile_GNA";
            this.buttonOpenFile_GNA.Size = new System.Drawing.Size(103, 125);
            this.buttonOpenFile_GNA.TabIndex = 1;
            this.buttonOpenFile_GNA.Text = "Открыть файл";
            this.buttonOpenFile_GNA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GNA.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonDone_GNA
            // 
            this.buttonDone_GNA.Location = new System.Drawing.Point(733, 12);
            this.buttonDone_GNA.Name = "buttonDone_GNA";
            this.buttonDone_GNA.Size = new System.Drawing.Size(106, 125);
            this.buttonDone_GNA.TabIndex = 1;
            this.buttonDone_GNA.Text = "Выполнить";
            this.buttonDone_GNA.UseVisualStyleBackColor = true;
            this.buttonDone_GNA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxTask_GNA
            // 
            this.groupBoxTask_GNA.Controls.Add(this.textBoxTask_GNA);
            this.groupBoxTask_GNA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_GNA.Name = "groupBoxTask_GNA";
            this.groupBoxTask_GNA.Size = new System.Drawing.Size(715, 125);
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
            this.textBoxTask_GNA.Size = new System.Drawing.Size(709, 100);
            this.textBoxTask_GNA.TabIndex = 0;
            this.textBoxTask_GNA.Text = resources.GetString("textBoxTask_GNA.Text");
            // 
            // panelGraph_GNA
            // 
            this.panelGraph_GNA.BackColor = System.Drawing.SystemColors.Control;
            this.panelGraph_GNA.Controls.Add(this.chartFunction_GNA);
            this.panelGraph_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph_GNA.Location = new System.Drawing.Point(0, 143);
            this.panelGraph_GNA.Name = "panelGraph_GNA";
            this.panelGraph_GNA.Size = new System.Drawing.Size(1060, 415);
            this.panelGraph_GNA.TabIndex = 0;
            // 
            // chartFunction_GNA
            // 
            this.chartFunction_GNA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartFunction_GNA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_GNA.Legends.Add(legend1);
            this.chartFunction_GNA.Location = new System.Drawing.Point(303, 6);
            this.chartFunction_GNA.Name = "chartFunction_GNA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_GNA.Series.Add(series1);
            this.chartFunction_GNA.Size = new System.Drawing.Size(754, 404);
            this.chartFunction_GNA.TabIndex = 0;
            this.chartFunction_GNA.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции чисел кратных трём";
            this.chartFunction_GNA.Titles.Add(title1);
            // 
            // panelOutPut_GNA
            // 
            this.panelOutPut_GNA.Controls.Add(this.groupBoxOutPut_GNA);
            this.panelOutPut_GNA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_GNA.Location = new System.Drawing.Point(0, 143);
            this.panelOutPut_GNA.Name = "panelOutPut_GNA";
            this.panelOutPut_GNA.Padding = new System.Windows.Forms.Padding(5);
            this.panelOutPut_GNA.Size = new System.Drawing.Size(294, 415);
            this.panelOutPut_GNA.TabIndex = 0;
            // 
            // groupBoxOutPut_GNA
            // 
            this.groupBoxOutPut_GNA.Controls.Add(this.dataGridViewResult_GNA);
            this.groupBoxOutPut_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GNA.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutPut_GNA.Name = "groupBoxOutPut_GNA";
            this.groupBoxOutPut_GNA.Size = new System.Drawing.Size(284, 405);
            this.groupBoxOutPut_GNA.TabIndex = 0;
            this.groupBoxOutPut_GNA.TabStop = false;
            this.groupBoxOutPut_GNA.Text = "Вывод данных";
            // 
            // dataGridViewResult_GNA
            // 
            this.dataGridViewResult_GNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_GNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_GNA.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewResult_GNA.Name = "dataGridViewResult_GNA";
            this.dataGridViewResult_GNA.ReadOnly = true;
            this.dataGridViewResult_GNA.RowHeadersVisible = false;
            this.dataGridViewResult_GNA.RowHeadersWidth = 62;
            this.dataGridViewResult_GNA.RowTemplate.Height = 28;
            this.dataGridViewResult_GNA.Size = new System.Drawing.Size(278, 380);
            this.dataGridViewResult_GNA.TabIndex = 0;
            // 
            // splitterOutPut_GNA
            // 
            this.splitterOutPut_GNA.Location = new System.Drawing.Point(294, 143);
            this.splitterOutPut_GNA.Name = "splitterOutPut_GNA";
            this.splitterOutPut_GNA.Size = new System.Drawing.Size(3, 415);
            this.splitterOutPut_GNA.TabIndex = 1;
            this.splitterOutPut_GNA.TabStop = false;
            // 
            // FormMain_GNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 558);
            this.Controls.Add(this.splitterOutPut_GNA);
            this.Controls.Add(this.panelOutPut_GNA);
            this.Controls.Add(this.panelGraph_GNA);
            this.Controls.Add(this.panelTask_GNA);
            this.MinimumSize = new System.Drawing.Size(1082, 608);
            this.Name = "FormMain_GNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 6 | Гунбин Н. А.";
            this.panelTask_GNA.ResumeLayout(false);
            this.groupBoxTask_GNA.ResumeLayout(false);
            this.groupBoxTask_GNA.PerformLayout();
            this.panelGraph_GNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_GNA)).EndInit();
            this.panelOutPut_GNA.ResumeLayout(false);
            this.groupBoxOutPut_GNA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_GNA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_GNA;
        private System.Windows.Forms.Button buttonInfo_GNA;
        private System.Windows.Forms.Button buttonOpenFile_GNA;
        private System.Windows.Forms.Button buttonDone_GNA;
        private System.Windows.Forms.GroupBox groupBoxTask_GNA;
        private System.Windows.Forms.TextBox textBoxTask_GNA;
        private System.Windows.Forms.Panel panelGraph_GNA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_GNA;
        private System.Windows.Forms.Panel panelOutPut_GNA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GNA;
        private System.Windows.Forms.Splitter splitterOutPut_GNA;
        private System.Windows.Forms.DataGridView dataGridViewResult_GNA;
    }
}

