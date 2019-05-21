namespace Egitim
{
    partial class DersleriListele
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
            this.grd_Ders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Ders)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Ders
            // 
            this.grd_Ders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Ders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Ders.Location = new System.Drawing.Point(0, 0);
            this.grd_Ders.Name = "grd_Ders";
            this.grd_Ders.Size = new System.Drawing.Size(800, 450);
            this.grd_Ders.TabIndex = 0;
            // 
            // DersleriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd_Ders);
            this.Name = "DersleriListele";
            this.Text = "DersleriListele";
            this.Load += new System.EventHandler(this.DersleriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Ders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Ders;
    }
}