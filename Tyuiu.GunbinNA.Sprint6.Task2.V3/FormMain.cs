using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GunbinNA.Sprint6.Task2.V3.Lib;


namespace Tyuiu.GunbinNA.Sprint6.Task2.V3
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
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТб-23-1 Гунбин Никита Анатольевич", "Сообщение");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxVarStart_GNA.Text);
                int stop = Convert.ToInt32(textBoxVarStop_GNA.Text);

                int len = ds.GetMassFunction(start, stop).Length;

                double[] array;
                array = new double[len];

                array = ds.GetMassFunction(start, stop);

                this.chartFunction_GNA.Titles.Add("График функции (Sin(x)/(x + 1.2)) + Cos(x)*7x - 2");

                this.chartFunction_GNA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_GNA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridResult_GNA.Rows.Add(Convert.ToString(start), Convert.ToString(array[i]));

                    this.chartFunction_GNA.Series[0].Points.AddXY(start, array[i]);

                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_GNA.BackColor = Color.Yellow;
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_GNA.BackColor = Color.IndianRed;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_GNA.BackColor = Color.LightCoral;
        }
    }
}
