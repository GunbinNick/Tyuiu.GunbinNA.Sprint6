
namespace Tyuiu.GunbinNA.Sprint6.Task6.V15
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
            this.pictureBoxAva_GNA.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva_GNA.ErrorImage")));
            this.pictureBoxAva_GNA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva_GNA.Image")));
            this.pictureBoxAva_GNA.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAva_GNA.InitialImage")));
            this.pictureBoxAva_GNA.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxAva_GNA.Name = "pictureBoxAva_GNA";
            this.pictureBoxAva_GNA.Size = new System.Drawing.Size(293, 425);
            this.pictureBoxAva_GNA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAva_GNA.TabIndex = 0;
            this.pictureBoxAva_GNA.TabStop = false;
            // 
            // textBoxInfo_GNA
            // 
            this.textBoxInfo_GNA.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxInfo_GNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_GNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo_GNA.Location = new System.Drawing.Point(312, 26);
            this.textBoxInfo_GNA.Multiline = true;
            this.textBoxInfo_GNA.Name = "textBoxInfo_GNA";
            this.textBoxInfo_GNA.ReadOnly = true;
            this.textBoxInfo_GNA.Size = new System.Drawing.Size(476, 351);
            this.textBoxInfo_GNA.TabIndex = 1;
            this.textBoxInfo_GNA.Text = resources.GetString("textBoxInfo_GNA.Text");
            // 
            // buttonClose_GNA
            // 
            this.buttonClose_GNA.Location = new System.Drawing.Point(594, 384);
            this.buttonClose_GNA.Name = "buttonClose_GNA";
            this.buttonClose_GNA.Size = new System.Drawing.Size(194, 54);
            this.buttonClose_GNA.TabIndex = 2;
            this.buttonClose_GNA.Text = "OK";
            this.buttonClose_GNA.UseVisualStyleBackColor = true;
            this.buttonClose_GNA.Click += new System.EventHandler(this.buttonClose_Click);
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