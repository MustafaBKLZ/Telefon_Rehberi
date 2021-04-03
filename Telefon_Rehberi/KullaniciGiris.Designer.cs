
namespace Telefon_Rehberi
{
    partial class KullaniciGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kulkod = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Kodu";
            // 
            // txt_kulkod
            // 
            this.txt_kulkod.Location = new System.Drawing.Point(109, 31);
            this.txt_kulkod.Name = "txt_kulkod";
            this.txt_kulkod.Size = new System.Drawing.Size(100, 20);
            this.txt_kulkod.TabIndex = 1;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(109, 57);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '*';
            this.txt_pw.Size = new System.Drawing.Size(100, 20);
            this.txt_pw.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // btn_cikis
            // 
            this.btn_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cikis.Location = new System.Drawing.Point(32, 98);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(103, 44);
            this.btn_cikis.TabIndex = 22;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(141, 98);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(105, 44);
            this.btn_giris.TabIndex = 21;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kulkod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kulkod;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_giris;
    }
}