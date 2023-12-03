
namespace Tyuiu.GunbinNA.Sprint6.Task0.V13
{
    partial class FormMain
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask = new System.Windows.Forms.PictureBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBoxTask);
            this.groupBoxTask.Controls.Add(this.pictureBoxTask);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 27);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(776, 260);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";
            this.groupBoxTask.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBoxTask
            // 
            this.pictureBoxTask.Location = new System.Drawing.Point(603, 25);
            this.pictureBoxTask.Name = "pictureBoxTask";
            this.pictureBoxTask.Size = new System.Drawing.Size(167, 102);
            this.pictureBoxTask.TabIndex = 0;
            this.pictureBoxTask.TabStop = false;
            this.pictureBoxTask.Click += new System.EventHandler(this.pictureBoxTask_Click);
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(6, 25);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(293, 26);
            this.textBoxTask.TabIndex = 1;
            this.textBoxTask.Text = "Вычислить выражение по формуле";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxTask);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.PictureBox pictureBoxTask;
        private System.Windows.Forms.TextBox textBoxTask;
    }
}

