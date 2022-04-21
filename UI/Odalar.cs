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
    public partial class Odalar : Form
    {
        private IOdaService _odaService= new OdaManager(new EfOdaDal());
        public Odalar()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda()
            {
                Fiyat = Convert.ToDecimal(tbxFiyat.Text),
                MusaitMi = Convert.ToBoolean(cbxMusaitMi.SelectedItem.ToString()),
                Odano = tbxOdaNo.Text
            };
            _odaService.AddOda(oda);

            ListeleOdalar();
        }

        private void ListeleOdalar()
        {
            dgwOdalar.DataSource = _odaService.GetAll();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda()
            {
                ID = Convert.ToInt32(tbxOdaId.Text),
                Fiyat = Convert.ToDecimal(tbxFiyat.Text),
                MusaitMi = Convert.ToBoolean(cbxMusaitMi.SelectedItem.ToString()),
                Odano = tbxOdaNo.Text
            };
            _odaService.UpdateOda(oda);

            ListeleOdalar();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            ListeleOdalar();
        }

        private void dgwOdalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbxOdaId.Text = dgwOdalar.CurrentRow.Cells[0].Value.ToString();
            tbxOdaNo.Text = dgwOdalar.CurrentRow.Cells[1].Value.ToString();
            tbxFiyat.Text = dgwOdalar.CurrentRow.Cells[2].Value.ToString();
            cbxMusaitMi.SelectedItem = dgwOdalar.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Oda oda = new Oda()
            {
                ID = Convert.ToInt32(tbxOdaId.Text),
            };
            _odaService.DeleteOda(oda);

            ListeleOdalar();
        }
    }
}
