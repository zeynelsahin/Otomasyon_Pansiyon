using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entity.Concreate.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class Konaklamalar : Form
    {
        private readonly IKonaklamaService _konaklamaService= new KonaklamaManager(new EfKonaklamaDal());
        private readonly IOdaService _odaService = new OdaManager(new EfOdaDal());
        public Konaklamalar()
        {
         
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Konaklama konaklama = new Konaklama()
            {
                MusteriID = (int) cbxMusteri.SelectedValue,
                OdaID = (int) cbxOda.SelectedValue,
                GirisTarihi = dtpkGirisTarihi.Value,
                CikisTarihi = dtpkCikisTarihi.Value,
                ToplamFiyat = Convert.ToDecimal(tbxToplamFiyat.Text),
                AktifMi = true
            };
            _konaklamaService.AddKonaklama(konaklama);


            TutulanOda();

            OdalarıGetir();
            ListeleKonaklama();
            cbxOda.Text = null;
        }

        private void TutulanOda()
        {
            Oda tutulanOda = _odaService.GetOda(Convert.ToInt32(cbxOda.SelectedValue));
            //Oda tutulanOdaProperty = new Oda();
            //List<Oda> liste = new List<Oda>();
            //liste = cbxOda.DataSource as List<Oda>;
            //foreach (var oda in liste)
            //{
            //    if (oda.ID == (int) cbxOda.SelectedValue)
            //    {
            //        tutulanOdaProperty = oda;
            //    }
            //}

            //Tutulan odayı pasif hale getiriyoruz
            tutulanOda.MusaitMi = false;
            _odaService.UpdateOda(tutulanOda);
        }

        private void ListeleKonaklama()
        {
            dgwKonaklamalar.DataSource = _konaklamaService.GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            Konaklama konaklama = new Konaklama()
            {
                ID = (int)dgwKonaklamalar.CurrentRow.Cells[0].Value,
                MusteriID = (int)cbxMusteri.SelectedValue,
                OdaID = (int)cbxOda.SelectedValue,
                GirisTarihi = dtpkGirisTarihi.Value,
                CikisTarihi = dtpkCikisTarihi.Value,
                ToplamFiyat = Convert.ToDecimal(tbxToplamFiyat.Text),
                AktifMi = Convert.ToBoolean(cbxAktifMi.Text),
            };
            _konaklamaService.UpdateKonaklama(konaklama);
            TutulanOda();
            ListeleKonaklama();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            Konaklama konaklama = new Konaklama()
            {
                ID = (int)dgwKonaklamalar.CurrentRow.Cells[0].Value,
            };
            _konaklamaService.DeleteKonaklama(konaklama);
            ListeleKonaklama();
        }

        private void Konaklamalar_Load(object sender, EventArgs e)
        {
            ListeleKonaklama();

            MusterileriGetir();
            
            OdalarıGetir();


        }

        private void OdalarıGetir()
        {
            cbxOda.DataSource = new OdaManager(new EfOdaDal()).GetAllByAktif();
            cbxOda.DisplayMember = "OdaNo";
            cbxOda.ValueMember = "ID";

            List<Oda> liste = new List<Oda>();
            liste = (List<Oda>) cbxOda.DataSource;
        }

        private void MusterileriGetir()
        {
            cbxMusteri.DataSource = new MusteriManager(new EfMusteriDal()).GetAll();
            cbxMusteri.ValueMember= "Id";
            cbxMusteri.DisplayMember = "Isim";
            cbxMusteri.DisplayMember += "Soyisim";
        }

        private void cbxOda_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dgwKonaklamalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cbxMusteri.SelectedItem = dgwKonaklamalar.CurrentRow.Cells[1].Value.ToString();
           cbxOda.SelectedItem = dgwKonaklamalar.CurrentRow.Cells[2].Value.ToString();
            dtpkGirisTarihi.Value = (DateTime) dgwKonaklamalar.CurrentRow.Cells[3].Value;
            dtpkCikisTarihi.Value = (DateTime) dgwKonaklamalar.CurrentRow.Cells[4].Value;
            tbxToplamFiyat.Text = dgwKonaklamalar.CurrentRow.Cells[5].Value.ToString();
            cbxAktifMi.SelectedItem = dgwKonaklamalar.CurrentRow.Cells[6].Value.ToString();
        }

     

        private void tbxFiltre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxFiltre.Text))
            {
                dgwKonaklamalar.DataSource = _konaklamaService.GetKonaklamaMusteriId(Convert.ToInt32(tbxFiltre.Text));
            }
            else
            {
                ListeleKonaklama();
            }

            
        }
    }
}
