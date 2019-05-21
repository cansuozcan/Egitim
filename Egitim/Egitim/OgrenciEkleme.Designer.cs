namespace Egitim
{
    partial class OgrenciEkleme
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
            this.btn_yeniIptal = new System.Windows.Forms.Button();
            this.btn_yeniKayıt = new System.Windows.Forms.Button();
            this.txt_yeniogrTel = new System.Windows.Forms.TextBox();
            this.txt_yeniogrEmail = new System.Windows.Forms.TextBox();
            this.txt_yeniogrSoyad = new System.Windows.Forms.TextBox();
            this.lbl_yeniogrTel = new System.Windows.Forms.Label();
            this.txt_yeniogrAd = new System.Windows.Forms.TextBox();
            this.lbl_yeniogrEmail = new System.Windows.Forms.Label();
            this.lbl_yeniogrSoyad = new System.Windows.Forms.Label();
            this.lbl_yeniogrAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_yeniIptal
            // 
            this.btn_yeniIptal.Location = new System.Drawing.Point(275, 274);
            this.btn_yeniIptal.Name = "btn_yeniIptal";
            this.btn_yeniIptal.Size = new System.Drawing.Size(75, 23);
            this.btn_yeniIptal.TabIndex = 11;
            this.btn_yeniIptal.Text = "İptal";
            this.btn_yeniIptal.UseVisualStyleBackColor = true;
            // 
            // btn_yeniKayıt
            // 
            this.btn_yeniKayıt.Location = new System.Drawing.Point(152, 274);
            this.btn_yeniKayıt.Name = "btn_yeniKayıt";
            this.btn_yeniKayıt.Size = new System.Drawing.Size(75, 23);
            this.btn_yeniKayıt.TabIndex = 12;
            this.btn_yeniKayıt.Text = "Yeni Kayıt";
            this.btn_yeniKayıt.UseVisualStyleBackColor = true;
            this.btn_yeniKayıt.Click += new System.EventHandler(this.btn_yeniKayıt_Click);
            // 
            // txt_yeniogrTel
            // 
            this.txt_yeniogrTel.Location = new System.Drawing.Point(164, 210);
            this.txt_yeniogrTel.Name = "txt_yeniogrTel";
            this.txt_yeniogrTel.Size = new System.Drawing.Size(266, 20);
            this.txt_yeniogrTel.TabIndex = 7;
            // 
            // txt_yeniogrEmail
            // 
            this.txt_yeniogrEmail.Location = new System.Drawing.Point(164, 166);
            this.txt_yeniogrEmail.Name = "txt_yeniogrEmail";
            this.txt_yeniogrEmail.Size = new System.Drawing.Size(266, 20);
            this.txt_yeniogrEmail.TabIndex = 8;
            // 
            // txt_yeniogrSoyad
            // 
            this.txt_yeniogrSoyad.Location = new System.Drawing.Point(164, 109);
            this.txt_yeniogrSoyad.Name = "txt_yeniogrSoyad";
            this.txt_yeniogrSoyad.Size = new System.Drawing.Size(266, 20);
            this.txt_yeniogrSoyad.TabIndex = 9;
            // 
            // lbl_yeniogrTel
            // 
            this.lbl_yeniogrTel.AutoSize = true;
            this.lbl_yeniogrTel.Location = new System.Drawing.Point(66, 217);
            this.lbl_yeniogrTel.Name = "lbl_yeniogrTel";
            this.lbl_yeniogrTel.Size = new System.Drawing.Size(43, 13);
            this.lbl_yeniogrTel.TabIndex = 3;
            this.lbl_yeniogrTel.Text = "Telefon";
            // 
            // txt_yeniogrAd
            // 
            this.txt_yeniogrAd.Location = new System.Drawing.Point(164, 61);
            this.txt_yeniogrAd.Name = "txt_yeniogrAd";
            this.txt_yeniogrAd.Size = new System.Drawing.Size(266, 20);
            this.txt_yeniogrAd.TabIndex = 10;
            // 
            // lbl_yeniogrEmail
            // 
            this.lbl_yeniogrEmail.AutoSize = true;
            this.lbl_yeniogrEmail.Location = new System.Drawing.Point(66, 166);
            this.lbl_yeniogrEmail.Name = "lbl_yeniogrEmail";
            this.lbl_yeniogrEmail.Size = new System.Drawing.Size(32, 13);
            this.lbl_yeniogrEmail.TabIndex = 4;
            this.lbl_yeniogrEmail.Text = "Email";
            // 
            // lbl_yeniogrSoyad
            // 
            this.lbl_yeniogrSoyad.AutoSize = true;
            this.lbl_yeniogrSoyad.Location = new System.Drawing.Point(66, 109);
            this.lbl_yeniogrSoyad.Name = "lbl_yeniogrSoyad";
            this.lbl_yeniogrSoyad.Size = new System.Drawing.Size(79, 13);
            this.lbl_yeniogrSoyad.TabIndex = 5;
            this.lbl_yeniogrSoyad.Text = "Öğrenci Soyadı";
            // 
            // lbl_yeniogrAd
            // 
            this.lbl_yeniogrAd.AutoSize = true;
            this.lbl_yeniogrAd.Location = new System.Drawing.Point(66, 64);
            this.lbl_yeniogrAd.Name = "lbl_yeniogrAd";
            this.lbl_yeniogrAd.Size = new System.Drawing.Size(62, 13);
            this.lbl_yeniogrAd.TabIndex = 6;
            this.lbl_yeniogrAd.Text = "Ögrenci Adı";
            this.lbl_yeniogrAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OgrenciEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 368);
            this.Controls.Add(this.btn_yeniIptal);
            this.Controls.Add(this.btn_yeniKayıt);
            this.Controls.Add(this.txt_yeniogrTel);
            this.Controls.Add(this.txt_yeniogrEmail);
            this.Controls.Add(this.txt_yeniogrSoyad);
            this.Controls.Add(this.lbl_yeniogrTel);
            this.Controls.Add(this.txt_yeniogrAd);
            this.Controls.Add(this.lbl_yeniogrEmail);
            this.Controls.Add(this.lbl_yeniogrSoyad);
            this.Controls.Add(this.lbl_yeniogrAd);
            this.Name = "OgrenciEkleme";
            this.Text = "OgrenciEkleme";
            this.Load += new System.EventHandler(this.OgrenciEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yeniIptal;
        private System.Windows.Forms.Button btn_yeniKayıt;
        private System.Windows.Forms.TextBox txt_yeniogrTel;
        private System.Windows.Forms.TextBox txt_yeniogrEmail;
        private System.Windows.Forms.TextBox txt_yeniogrSoyad;
        private System.Windows.Forms.Label lbl_yeniogrTel;
        private System.Windows.Forms.TextBox txt_yeniogrAd;
        private System.Windows.Forms.Label lbl_yeniogrEmail;
        private System.Windows.Forms.Label lbl_yeniogrSoyad;
        private System.Windows.Forms.Label lbl_yeniogrAd;
    }
}