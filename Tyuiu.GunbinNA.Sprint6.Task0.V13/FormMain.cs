using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GunbinNA.Sprint6.Task0.V13.Lib;

namespace Tyuiu.GunbinNA.Sprint6.Task0.V13
{
    public partial class FormMain_GNA : Form
    {
        public FormMain_GNA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxTask_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVarX_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-23-1 Гунбин Никита Анатольевич");
        }

        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int x = Convert.ToInt32(textBoxVarX_GNA.Text);

                textBoxResult_GNA.Text = Convert.ToString(ds.Calculate(x));
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_GNA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
