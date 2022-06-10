using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KeremGaleri.Detaylar;
using KeremGaleri.Arayuz;

namespace KeremGaleri
{
    public partial class AnaGaleri : Form
    {
        public AnaGaleri()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds1 = detay.SatisDetay();
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];


            DataSet ds2 = detay.OdemeDetay();
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];


        }

        Müşteriler mf = new Müşteriler();
        Araclar uf = new Araclar();

        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnÜrünler_Click(object sender, EventArgs e)
        {
            uf.ShowDialog();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            AracSatisForm frm = new AracSatisForm()
            {
                Text = "Satış Yap",
                Satis = new Satis()
                {
                    ID = Guid.NewGuid()
                }
            };


        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = detay.SatisEkle(frm.Satis);

                if (b)
                {

                    DataSet ds1 = detay.SatisDetay();
                    if (ds1 != null)
                        dataGridView1.DataSource = ds1.Tables[0];
                }
                else
                    goto tekrar;

            }


        }



        private void btnSatışDüzenle_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            AracSatisForm frm = new AracSatisForm()
            {
                Text = "Satış Güncelle",
                Güncelleme = true,
                Satis = new Satis()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    UrunID = Guid.Parse(row.Cells[2].Value.ToString()),
                    Fiyat = double.Parse( row.Cells[7].Value.ToString()),
                    Tarih = DateTime.Parse( row.Cells[8].Value.ToString()),

                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = detay.SatisGüncelle(frm.Satis);

                if (b)
                {
                    row.Cells[1].Value = frm.Satis.MusteriID;
                    row.Cells[2].Value = frm.Satis.UrunID;
                    row.Cells[7].Value = frm.Satis.Fiyat;
                    row.Cells[8].Value = frm.Satis.Tarih;

                }

            }

        }

        private void btnSatışSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = detay.SatisSil(ID);

                if (b)
                {

                    DataSet ds = detay.SatisDetay();
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }


        }

        private void btnÖdemeYap_Click(object sender, EventArgs e)
        {
            OdemeForm frm = new OdemeForm()
            {
                Text = "Ödeme Yap",
                Odeme = new Odeme()
                {
                    ID = Guid.NewGuid()
                }
            };


        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = detay.OdemeEkle(frm.Odeme);

                if (b)
                {

                    DataSet ds2 = detay.OdemeDetay();
                    if (ds2 != null)
                        dataGridView2.DataSource = ds2.Tables[0];
                }
                else
                    goto tekrar;

            }


        }

        private void btnÖdemeDüzenle_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView2.SelectedRows[0];

            OdemeForm frm = new OdemeForm()
            {
                Text = "Satış Güncelle",
                Güncelleme = true,
                Odeme = new Odeme()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(row.Cells[1].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[3].Value.ToString()),
                    Tutar = double.Parse(row.Cells[4].Value.ToString()),
                    Tur =row.Cells[5].Value.ToString(),
                    Aciklama = row.Cells[6].Value.ToString(),

                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = detay.OdemeGüncelle(frm.Odeme);

                if (b)
                {
                    row.Cells[1].Value = frm.Odeme.MusteriID;
                    row.Cells[3].Value = frm.Odeme.Tarih;
                    row.Cells[4].Value = frm.Odeme.Tutar;
                    row.Cells[5].Value = frm.Odeme.Tur;
                    row.Cells[6].Value = frm.Odeme.Aciklama;

                }

            }

        }

        private void btnÖdemeSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = detay.OdemeSil(ID);

                if (b)
                {

                    DataSet ds = detay.OdemeDetay();
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }

            }
        }
    }
}
