
namespace Telefon_Rehberi
{
    partial class AnaFom
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKişiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kişiBilgileriniGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeyiYEnileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1046, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.yeniKişiEkleToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // yeniKişiEkleToolStripMenuItem
            // 
            this.yeniKişiEkleToolStripMenuItem.Name = "yeniKişiEkleToolStripMenuItem";
            this.yeniKişiEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniKişiEkleToolStripMenuItem.Text = "Yeni Kişi Ekle";
            this.yeniKişiEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniKişiEkleToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1046, 505);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kişiBilgileriniGüncelleToolStripMenuItem,
            this.listeyiYEnileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 48);
            // 
            // kişiBilgileriniGüncelleToolStripMenuItem
            // 
            this.kişiBilgileriniGüncelleToolStripMenuItem.Name = "kişiBilgileriniGüncelleToolStripMenuItem";
            this.kişiBilgileriniGüncelleToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.kişiBilgileriniGüncelleToolStripMenuItem.Text = "Kişi Bilgilerini Güncelle";
            this.kişiBilgileriniGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kişiBilgileriniGüncelleToolStripMenuItem_Click);
            // 
            // listeyiYEnileToolStripMenuItem
            // 
            this.listeyiYEnileToolStripMenuItem.Name = "listeyiYEnileToolStripMenuItem";
            this.listeyiYEnileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.listeyiYEnileToolStripMenuItem.Text = "Listeyi Yenile";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullanıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıİşlemleriToolStripMenuItem_Click);
            // 
            // AnaFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaFom";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnaFom_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKişiEkleToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kişiBilgileriniGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeyiYEnileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
    }
}

