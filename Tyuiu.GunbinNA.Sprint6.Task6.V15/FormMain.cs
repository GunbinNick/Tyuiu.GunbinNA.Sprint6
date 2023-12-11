using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GunbinNA.Sprint6.Task6.V15.Lib;
using System.IO;

namespace Tyuiu.GunbinNA.Sprint6.Task6.V15
{
    public partial class FormMain_GNA : Form
    {
        public FormMain_GNA()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GNA.ShowDialog();
            openFilePath = openFileDialogTask_GNA.FileName;
            textBoxInPut_GNA.Text = File.ReadAllText(openFilePath);
            groupBoxIn_GNA.Text = groupBoxOut_GNA.Text + " " + openFileDialogTask_GNA.FileName;
            buttonDone_GNA.Enabled = true;

        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOutPut_GNA.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout_GNA form = new FormAbout_GNA();
            form.ShowDialog();
        }
    }
}
