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
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            int kontrol = Convert.ToInt16(Cls.SQLConnectionClass.Command("select count(*) from KULLANICILAR " +
                " where kul_Kod = '" + txt_kulkod.Text + "' and kul_sifre = '" + txt_pw.Text + "'"));
            if (kontrol > 0)
            {
                this.Hide();
                new AnaFom() { }.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı kodu veya şifre hatalı");
            }
        }
    }
}
