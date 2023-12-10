using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GunbinNA.Sprint6.Task4.V3.Lib;
using System.IO;

namespace Tyuiu.GunbinNA.Sprint6.Task4.V3
{
    public partial class FormMain_GNA : Form
    {
        public FormMain_GNA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-23-1 Гунбин Никита Анатольевич", "Сообщение");
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_GNA.Text);
                int stop = Convert.ToInt32(textBoxEnd_GNA.Text);

                int len = ds.GetMassFunction(start, stop).Length;

                double[] array;
                array = new double[len];

                array = ds.GetMassFunction(start, stop);

                //this.chartFunction.Titles.Add("График функции (Sin(x)/(x + 1.2)) + Cos(x)*7x - 2");

                this.chartFunction_GNA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_GNA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPut_GNA.Text = "";

                chartFunction_GNA.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_GNA.Series[0].Points.AddXY(start, array[i]);
                    textBoxOutPut_GNA.AppendText(array[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V3.txt";
                File.WriteAllText(path, textBoxOutPut_GNA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
