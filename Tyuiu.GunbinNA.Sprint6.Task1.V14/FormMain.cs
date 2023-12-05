using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GunbinNA.Sprint6.Task1.V14.Lib;

namespace Tyuiu.GunbinNA.Sprint6.Task1.V14
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
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-23-1 Гунбин Никита Анатольевич", "Сообщение");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxVarStart.Text);
                int stop = Convert.ToInt32(textBoxVarStop.Text);

                string str;

                int len = ds.GetMassFunction(start, stop).Length;

                double[] array;
                array = new double[len];

                array = ds.GetMassFunction(start, stop);

                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X     |    f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0,5:d}     |  {1, 5:f2}   |", start, array[i]);
                    textBoxResult.AppendText(str + Environment.NewLine);
                    start++;
                }
                textBoxResult.AppendText("+----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
