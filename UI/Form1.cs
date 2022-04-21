using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using Entity.Concreate.Entities;

namespace UI
{
    public partial class Form1 : Form
    {
        private IMusteriService _musteriService = new MusteriManager(new EfMusteriDal());
        public Form1()
        {
            InitializeComponent();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri()
            {
                Isim = tbxİsim.Text,
                Soyisim = tbxSoyisim.Text,
                Email = tbxEmail.Text,
                Cinsiyet = cbxCinsiyet.SelectedItem.ToString(),
                TCNo = mtbxTCNo.Text,
                Telefon = mtbxTelefon.Text
            };

            _musteriService.AddMusteri(musteri);
            MusteriListele();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void MusteriListele()
        {
            dgwMusteriler.DataSource = _musteriService.GetAll();
        }

        private void dgwMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwMusteriler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            mtbxTCNo.Text = dgwMusteriler.CurrentRow.Cells[1].Value.ToString();
            tbxMusteriId.Text = dgwMusteriler.CurrentRow.Cells[0].Value.ToString();
            tbxİsim.Text = dgwMusteriler.CurrentRow.Cells[2].Value.ToString();
            tbxSoyisim.Text = dgwMusteriler.CurrentRow.Cells[3].Value.ToString();
            mtbxTelefon.Text = dgwMusteriler.CurrentRow.Cells[4].Value.ToString();
            tbxEmail.Text = dgwMusteriler.CurrentRow.Cells[5].Value.ToString();
            cbxCinsiyet.SelectedItem = dgwMusteriler.CurrentRow.Cells[6].Value.ToString();
          
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri()
            {
                ID = Convert.ToInt32(tbxMusteriId.Text),
                Isim = tbxİsim.Text,
                Soyisim = tbxSoyisim.Text,
                Email = tbxEmail.Text,
                Cinsiyet = cbxCinsiyet.SelectedItem.ToString(),
                TCNo = mtbxTCNo.Text,
                Telefon = mtbxTelefon.Text
            };
            _musteriService.UpdateMusteri(musteri);
            MusteriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri()
            {
                ID = Convert.ToInt32(tbxMusteriId.Text)
            };
            _musteriService.DeleteMusteri(musteri);
            MusteriListele();
        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            Odalar odalar = new Odalar();
            odalar.Show();
        }

        private void btnKonaklamalar_Click(object sender, EventArgs e)
        {
            Konaklamalar konaklamalar = new Konaklamalar();
            konaklamalar.Show();
        }
    }
}
