namespace Egitim
{
    partial class OgrenciDuzenle
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
            this.lbl_ogrAd = new System.Windows.Forms.Label();
            this.lbl_ogrSoyad = new System.Windows.Forms.Label();
            this.lbl_ogrEmail = new System.Windows.Forms.Label();
            this.txt_ogrAd = new System.Windows.Forms.TextBox();
            this.txt_ogrSoyad = new System.Windows.Forms.TextBox();
            this.txt_ogrEmail = new System.Windows.Forms.TextBox();
            this.lbl_ogrTel = new System.Windows.Forms.Label();
            this.txt_ogrTel = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Iptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ogrAd
            // 
            this.lbl_ogrAd.AutoSize = true;
            this.lbl_ogrAd.Location = new System.Drawing.Point(60, 32);
            this.lbl_ogrAd.Name = "lbl_ogrAd";
            this.lbl_ogrAd.Size = new System.Drawing.Size(62, 13);
            this.lbl_ogrAd.TabIndex = 0;
            this.lbl_ogrAd.Text = "Ögrenci Adı";
            this.lbl_ogrAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ogrSoyad
            // 
            this.lbl_ogrSoyad.AutoSize = true;
            this.lbl_ogrSoyad.Location = new System.Drawing.Point(60, 77);
            this.lbl_ogrSoyad.Name = "lbl_ogrSoyad";
            this.lbl_ogrSoyad.Size = new System.Drawing.Size(79, 13);
            this.lbl_ogrSoyad.TabIndex = 0;
            this.lbl_ogrSoyad.Text = "Öğrenci Soyadı";
            // 
            // lbl_ogrEmail
            // 
            this.lbl_ogrEmail.AutoSize = true;
            this.lbl_ogrEmail.Location = new System.Drawing.Point(60, 134);
            this.lbl_ogrEmail.Name = "lbl_ogrEmail";
            this.lbl_ogrEmail.Size = new System.Drawing.Size(32, 13);
            this.lbl_ogrEmail.TabIndex = 0;
            this.lbl_ogrEmail.Text = "Email";
            // 
            // txt_ogrAd
            // 
            this.txt_ogrAd.Location = new System.Drawing.Point(158, 29);
            this.txt_ogrAd.Name = "txt_ogrAd";
            this.txt_ogrAd.Size = new System.Drawing.Size(266, 20);
            this.txt_ogrAd.TabIndex = 1;
            // 
            // txt_ogrSoyad
            // 
            this.txt_ogrSoyad.Location = new System.Drawing.Point(158, 77);
            this.txt_ogrSoyad.Name = "txt_ogrSoyad";
            this.txt_ogrSoyad.Size = new System.Drawing.Size(266, 20);
            this.txt_ogrSoyad.TabIndex = 1;
            // 
            // txt_ogrEmail
            // 
            this.txt_ogrEmail.Location = new System.Drawing.Point(158, 134);
            this.txt_ogrEmail.Name = "txt_ogrEmail";
            this.txt_ogrEmail.Size = new System.Drawing.Size(266, 20);
            this.txt_ogrEmail.TabIndex = 1;
            // 
            // lbl_ogrTel
            // 
            this.lbl_ogrTel.AutoSize = true;
            this.lbl_ogrTel.Location = new System.Drawing.Point(60, 185);
            this.lbl_ogrTel.Name = "lbl_ogrTel";
            this.lbl_ogrTel.Size = new System.Drawing.Size(43, 13);
            this.lbl_ogrTel.TabIndex = 0;
            this.lbl_ogrTel.Text = "Telefon";
            // 
            // txt_ogrTel
            // 
            this.txt_ogrTel.Location = new System.Drawing.Point(158, 182);
            this.txt_ogrTel.Name = "txt_ogrTel";
            this.txt_ogrTel.Size = new System.Drawing.Size(266, 20);
            this.txt_ogrTel.TabIndex = 1;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(146, 242);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_Kaydet.TabIndex = 2;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Iptal
            // 
            this.btn_Iptal.Location = new System.Drawing.Point(269, 242);
            this.btn_Iptal.Name = "btn_Iptal";
            this.btn_Iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_Iptal.TabIndex = 2;
            this.btn_Iptal.Text = "İptal";
            this.btn_Iptal.UseVisualStyleBackColor = true;
            this.btn_Iptal.Click += new System.EventHandler(this.btn_Iptal_Click);
            // 
            // OgrenciDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 386);
            this.Controls.Add(this.btn_Iptal);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_ogrTel);
            this.Controls.Add(this.txt_ogrEmail);
            this.Controls.Add(this.txt_ogrSoyad);
            this.Controls.Add(this.lbl_ogrTel);
            this.Controls.Add(this.txt_ogrAd);
            this.Controls.Add(this.lbl_ogrEmail);
            this.Controls.Add(this.lbl_ogrSoyad);
            this.Controls.Add(this.lbl_ogrAd);
            this.Name = "OgrenciDuzenle";
            this.Text = "OgrenciDuzenle";
            this.Load += new System.EventHandler(this.OgrenciDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ogrAd;
        private System.Windows.Forms.Label lbl_ogrSoyad;
        private System.Windows.Forms.Label lbl_ogrEmail;
        private System.Windows.Forms.TextBox txt_ogrAd;
        private System.Windows.Forms.TextBox txt_ogrSoyad;
        private System.Windows.Forms.TextBox txt_ogrEmail;
        private System.Windows.Forms.Label lbl_ogrTel;
        private System.Windows.Forms.TextBox txt_ogrTel;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Iptal;
    }
}