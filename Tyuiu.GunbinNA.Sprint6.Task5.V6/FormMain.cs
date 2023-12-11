using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GunbinNA.Sprint6.Task5.V6.Lib;

namespace Tyuiu.GunbinNA.Sprint6.Task5.V6
{
    public partial class FormMain_GNA : Form
    {
        public FormMain_GNA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\wackko\source\repos\Tyuiu.GunbinNA.Sprint6\Tyuiu.GunbinNA.Sprint6.Task5.V6\bin\Debug\InPutFileTask5V6.txt";
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-23-1 Гунбин Никита Анатольевич", "Сообщение");
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewResult_GNA.ColumnCount = 2;
            dataGridViewResult_GNA.Columns[0].Width = 20;
            dataGridViewResult_GNA.Columns[1].Width = 50;

            this.chartFunction_GNA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_GNA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_GNA.Series[0].Points.Clear();

            double[] numsArray = new double[ds.len];

            numsArray = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsArray.Length; i++)
            {
                dataGridViewResult_GNA.Rows.Add(Convert.ToString(i), Convert.ToString(numsArray[i]));
                chartFunction_GNA.Series[0].Points.AddXY(i, numsArray[i]);
            }

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
