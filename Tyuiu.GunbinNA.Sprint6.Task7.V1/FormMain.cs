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
using Tyuiu.GunbinNA.Sprint6.Task7.V1.Lib;

namespace Tyuiu.GunbinNA.Sprint6.Task7.V1
{
    public partial class FormMain_GNA : Form
    {
        public FormMain_GNA()
        {
            InitializeComponent();

            openFileDialogTask_GNA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_GNA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for(int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                    array[i, j] = Convert.ToInt32(line_i[j]);
            }
            return array;

        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout_GNA form = new FormAbout_GNA();
            form.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GNA.ShowDialog();
            openFilePath = openFileDialogTask_GNA.FileName;

            int[,] array = new int[rows, columns];

            array = LoadFromFileData(openFilePath);

            dataGridViewIn_GNA.ColumnCount = columns;
            dataGridViewIn_GNA.RowCount = rows;
            dataGridViewOut_GNA.ColumnCount = columns;
            dataGridViewOut_GNA.RowCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_GNA.Columns[i].Width = 25;
                dataGridViewOut_GNA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < columns; c++)
                    dataGridViewIn_GNA.Rows[r].Cells[c].Value = array[r, c];

            array = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone_GNA.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] array = new int[rows, columns];
            array = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < columns; c++)
                    dataGridViewOut_GNA.Rows[r].Cells[c].Value = array[r, c];
            buttonSaveFile_GNA.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_GNA.FileName = "OutPutFileTask7V1.csv";
            saveFileDialogMatrix_GNA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_GNA.ShowDialog();

            string path = saveFileDialogMatrix_GNA.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;

            if (fileex)
                File.Delete(path);

            int rows = dataGridViewOut_GNA.RowCount;
            int columns = dataGridViewOut_GNA.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                        str += dataGridViewOut_GNA.Rows[i].Cells[j].Value + ";";
                    else
                        str += dataGridViewOut_GNA.Rows[i].Cells[j].Value;
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
