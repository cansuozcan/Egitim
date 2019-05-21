namespace Egitim
{
    partial class SubeleriListele
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
            this.grd_Sube = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Sube)).BeginInit();
            this.SuspendLayout();
            // 
            // grd_Sube
            // 
            this.grd_Sube.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Sube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Sube.Location = new System.Drawing.Point(0, 0);
            this.grd_Sube.Name = "grd_Sube";
            this.grd_Sube.Size = new System.Drawing.Size(800, 450);
            this.grd_Sube.TabIndex = 0;
            // 
            // SubeleriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd_Sube);
            this.Name = "SubeleriListele";
            this.Text = "SubeleriListele";
            this.Load += new System.EventHandler(this.SubeleriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Sube)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grd_Sube;
    }
}