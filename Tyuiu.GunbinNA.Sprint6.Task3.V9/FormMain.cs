using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GunbinNA.Sprint6.Task3.V9.Lib;

namespace Tyuiu.GunbinNA.Sprint6.Task3.V9
{
    public partial class FormMain_GNA : Form
    {
        public FormMain_GNA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = { { -14, 25, 26, 18, 17 },
                             { 28, 10, 6, -2, 4 },
                             { 30, 25, -3, 11, -10 },
                             { 11, 32, -5, -20, 25 },
                             { 2, -18, 11, 8, -20 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_GNA.ColumnCount = columns;
            dataGridViewMatrix_GNA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_GNA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_GNA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] matr = ds.Calculate(matrix);
            int rows = matr.GetUpperBound(0) + 1;
            int columns = matr.Length / rows;

            dataGridViewMatrix_GNA.ColumnCount = columns;
            dataGridViewMatrix_GNA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_GNA.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_GNA.Rows[i].Cells[j].Value = Convert.ToString(matr[i, j]);
                }
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-23-1 Гунбин Никита Анатольевич", "Сообщение");
        }
    }
}
