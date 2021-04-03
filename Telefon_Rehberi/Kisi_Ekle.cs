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
    public partial class Kisi_Ekle : Form
    {
        public Kisi_Ekle()
        {
            InitializeComponent();
        }
        private void Kisi_Ekle_Load(object sender, EventArgs e)
        {
            Kisi_Oku();
        }
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Kisi_Oku()
        {
            if (Convert.ToInt32(txt_id.Text) > 0)
            {
                DataTable dt = Cls.SQLConnectionClass.Table("select * from dbo.Kisi_Bilgileri_Getir(0) where [KAYITNO] =  " + Convert.ToInt32(txt_id.Text) + " ");
                txt_ad.Text = dt.Rows[0]["Kişi Adı"].ToString();
                txt_cep1.Text = dt.Rows[0]["Cep No 1"].ToString();
                txt_cep2.Text = dt.Rows[0]["Cep No 2"].ToString();
                txt_is1.Text = dt.Rows[0]["İş No 1"].ToString();
                txt_is2.Text = dt.Rows[0]["İş No 2"].ToString();
                txt_fax1.Text = dt.Rows[0]["Fax No 1"].ToString();
                txt_fax2.Text = dt.Rows[0]["Fax No 2"].ToString();
                txt_mail1.Text = dt.Rows[0]["E-Posta 1"].ToString();
                txt_mail2.Text = dt.Rows[0]["E-Posta 2"].ToString();
                txt_aciklama.Text = dt.Rows[0]["Açıklama"].ToString();
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Cls.SQLConnectionClass.Command("exec YeniKisi_Kaydet_Guncelle "
                + " " + Convert.ToInt32(txt_id.Text) + "  "
                + ", " + Cls.glb.Aktif_Kullanici_Kod + "   "
                + ", '" + txt_ad.Text + "'  "
                + ", '" + txt_cep1.Text + "' "
                + ", '" + txt_cep2.Text + "' "
                + ", '" + txt_is1.Text + "' "
                + ", '" + txt_is2.Text + "' "
                + ", '" + txt_fax1.Text + "' "
                + ", '" + txt_fax2.Text + "' "
                + ", '" + txt_mail1.Text + "' "
                + ", '" + txt_mail2.Text + "' "
                + ", '" + txt_aciklama.Text + "' ");
            if (Cls.SQLConnectionClass.exception == null)
            {
                MessageBox.Show("İşlem Başarılı");
                Close();
            }

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Cls.SQLConnectionClass.Command("delete from KISI_TELEFON_LISTESI where [tel_RECno] = " + Convert.ToInt32(txt_id.Text) + " ");
            if (Cls.SQLConnectionClass.exception == null)
            {
                MessageBox.Show("Silme Başarılı");
                Close();
            }

        }
    }
}
