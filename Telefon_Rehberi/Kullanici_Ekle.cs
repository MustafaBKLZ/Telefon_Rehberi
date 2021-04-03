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
    public partial class Kullanici_Ekle : Form
    {
        public Kullanici_Ekle()
        {
            InitializeComponent();
        }


        private void Kullanici_Ekle_Load(object sender, EventArgs e)
        {
            temizle();
            dgv_Update();
        }

        void kullanici_kod_al()
        {
            txt_kulkod.Text = Cls.SQLConnectionClass.Command("select max(kul_Kod)+1 from  KULLANICILAR ").ToString();
        }
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            int kontrol = Convert.ToInt32(Cls.SQLConnectionClass.Command("select count(*) from  KULLANICILAR where [kul_Kod] = " + Convert.ToInt32(txt_kulkod.Text) + ""));
            if (kontrol == 0)
            {
                Cls.SQLConnectionClass.Command(""
               + "     INSERT INTO  [dbo].[KULLANICILAR] "
               + "            ([kul_Kod] "
               + "            ,[kul_Adi] "
               + "            ,[kul_sifre]) "
               + "      VALUES "
               + "            (" + Convert.ToInt32(txt_kulkod.Text) + ""
               + "            ,'" + txt_kulad.Text + "' "
               + "            ,'" + txt_kulpw.Text + "' ) ");
                if (Cls.SQLConnectionClass.exception == null)
                {
                    temizle();
                    MessageBox.Show("Kaydetme Başarılı");
                    dgv_Update();
                }
            }
            else
            {

                Cls.SQLConnectionClass.Command(""
               + "  update  [dbo].[KULLANICILAR] set "
               + "             [kul_Adi]  = '" + txt_kulad.Text + "' "
               + "            ,[kul_sifre]  = '" + txt_kulpw.Text + "' where kul_Kod = " + Convert.ToInt32(txt_kulkod.Text) + " ");
                if (Cls.SQLConnectionClass.exception == null)
                {
                    temizle();
                    MessageBox.Show("Kaydetme Başarılı");
                    dgv_Update();
                }
            }
        }
        void temizle()
        {
            txt_kulad.Text = "";
            txt_kulpw.Text = "";
            kullanici_kod_al();
        }

        void dgv_Update()
        {
            dataGridView1.DataSource = Cls.SQLConnectionClass.Table(" "
                   + "      SELECT [kul_RECno]  as [KAYTINO]"
                   + "            ,[kul_Kod]  as Kod"
                   + "            ,[kul_Adi] as Ad"
                   + "            ,[kul_sifre] as Şifre "
                   + "        FROM [dbo].[KULLANICILAR] ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                temizle();
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_kulad.Text = row.Cells["Ad"].Value.ToString();
                txt_kulkod.Text = row.Cells["Kod"].Value.ToString();
                txt_kulpw.Text = row.Cells["Şifre"].Value.ToString();
            }
        }
    }



}
