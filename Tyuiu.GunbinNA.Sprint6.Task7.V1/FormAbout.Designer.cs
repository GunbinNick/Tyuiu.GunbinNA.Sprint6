
namespace Tyuiu.GunbinNA.Sprint6.Task7.V1
{
    partial class FormAbout_GNA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_GNA));
            this.pictureBoxAva_GNA = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_GNA = new System.Windows.Forms.TextBox();
            this.buttonClose_GNA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_GNA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAva_GNA
            // 
            this.pictureBoxAva_GNA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva_GNA.Image")));
            this.pictureBoxAva_GNA.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAva_GNA.Name = "pictureBoxAva_GNA";
            this.pictureBoxAva_GNA.Size = new System.Drawing.Size(269, 415);
            this.pictureBoxAva_GNA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAva_GNA.TabIndex = 0;
            this.pictureBoxAva_GNA.TabStop = false;
            // 
            // textBoxInfo_GNA
            // 
            this.textBoxInfo_GNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxInfo_GNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_GNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo_GNA.Location = new System.Drawing.Point(289, 13);
            this.textBoxInfo_GNA.Multiline = true;
            this.textBoxInfo_GNA.Name = "textBoxInfo_GNA";
            this.textBoxInfo_GNA.ReadOnly = true;
            this.textBoxInfo_GNA.Size = new System.Drawing.Size(499, 356);
            this.textBoxInfo_GNA.TabIndex = 1;
            this.textBoxInfo_GNA.Text = resources.GetString("textBoxInfo_GNA.Text");
            // 
            // buttonClose_GNA
            // 
            this.buttonClose_GNA.Location = new System.Drawing.Point(599, 376);
            this.buttonClose_GNA.Name = "buttonClose_GNA";
            this.buttonClose_GNA.Size = new System.Drawing.Size(163, 52);
            this.buttonClose_GNA.TabIndex = 2;
            this.buttonClose_GNA.Text = "OK";
            this.buttonClose_GNA.UseVisualStyleBackColor = true;
            this.buttonClose_GNA.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAbout_GNA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose_GNA);
            this.Controls.Add(this.textBoxInfo_GNA);
            this.Controls.Add(this.pictureBoxAva_GNA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_GNA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva_GNA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAva_GNA;
        private System.Windows.Forms.TextBox textBoxInfo_GNA;
        private System.Windows.Forms.Button buttonClose_GNA;
    }
}