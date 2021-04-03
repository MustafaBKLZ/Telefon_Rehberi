using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Telefon_Rehberi
{
    public partial class AnaFom : Form
    {
        public AnaFom()
        {
            InitializeComponent();
        }

        private void AnaFom_Load(object sender, EventArgs e)
        {
            dgv_Update();
        }

        private void yeniKişiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Kisi_Ekle() { }.ShowDialog();
            dgv_Update();
        }

        void dgv_Update()
        {
            dataGridView1.DataSource = Cls.SQLConnectionClass.Table("select * from dbo.Kisi_Bilgileri_Getir(0) ");
        }

        private void kişiBilgileriniGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kisi_Ekle fr = new Kisi_Ekle();
            fr.txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fr.ShowDialog();
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Kullanici_Ekle() { }.ShowDialog();
        }

        private void listeyiYEnileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_Update();
        }
    }
}
