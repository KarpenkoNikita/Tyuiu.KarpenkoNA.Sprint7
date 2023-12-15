
namespace Tyuiu.KarpenkoNA.Sprint7.Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_KNA = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_KNA = new System.Windows.Forms.TextBox();
            this.buttonClose_KNA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KNA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_KNA
            // 
            this.pictureBoxAvatar_KNA.Image = global::Tyuiu.KarpenkoNA.Sprint7.Project.V4.Properties.Resources.photo1691351589;
            this.pictureBoxAvatar_KNA.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_KNA.InitialImage")));
            this.pictureBoxAvatar_KNA.Location = new System.Drawing.Point(13, 30);
            this.pictureBoxAvatar_KNA.Name = "pictureBoxAvatar_KNA";
            this.pictureBoxAvatar_KNA.Size = new System.Drawing.Size(226, 304);
            this.pictureBoxAvatar_KNA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_KNA.TabIndex = 0;
            this.pictureBoxAvatar_KNA.TabStop = false;
            // 
            // textBoxInfo_KNA
            // 
            this.textBoxInfo_KNA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfo_KNA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_KNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInfo_KNA.Location = new System.Drawing.Point(245, 30);
            this.textBoxInfo_KNA.Multiline = true;
            this.textBoxInfo_KNA.Name = "textBoxInfo_KNA";
            this.textBoxInfo_KNA.ReadOnly = true;
            this.textBoxInfo_KNA.Size = new System.Drawing.Size(404, 356);
            this.textBoxInfo_KNA.TabIndex = 1;
            this.textBoxInfo_KNA.TabStop = false;
            this.textBoxInfo_KNA.Text = resources.GetString("textBoxInfo_KNA.Text");
            // 
            // buttonClose_KNA
            // 
            this.buttonClose_KNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose_KNA.Location = new System.Drawing.Point(532, 329);
            this.buttonClose_KNA.Name = "buttonClose_KNA";
            this.buttonClose_KNA.Size = new System.Drawing.Size(117, 40);
            this.buttonClose_KNA.TabIndex = 2;
            this.buttonClose_KNA.Text = "Ок";
            this.buttonClose_KNA.UseVisualStyleBackColor = true;
            this.buttonClose_KNA.Click += new System.EventHandler(this.buttonClose_KNA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 398);
            this.Controls.Add(this.buttonClose_KNA);
            this.Controls.Add(this.textBoxInfo_KNA);
            this.Controls.Add(this.pictureBoxAvatar_KNA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KNA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_KNA;
        private System.Windows.Forms.TextBox textBoxInfo_KNA;
        private System.Windows.Forms.Button buttonClose_KNA;
        
    }
}