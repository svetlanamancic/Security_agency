using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using SBP_Projekat.DTOs;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Forme
{
    public partial class PovezivanjeRegCenSaMenadzerom : MetroForm
    {
        #region Atributi

        private List<MenadzerView> menadzerko;
        private RegionalniCentarView centar;
        #endregion

        #region Konstruktori
        public PovezivanjeRegCenSaMenadzerom()
        {
            InitializeComponent();
            centar = new RegionalniCentarView();
            menadzerko = new List<MenadzerView>();
        }

        public PovezivanjeRegCenSaMenadzerom(RegionalniCentarView r)
        {
            InitializeComponent();
            this.lblAdresa.Text = r.Adresa;
            this.centar = r;
            menadzerko = DTOManager.getMenadzereIzCentra(centar.Id);

        }

        #endregion
        private void PovezivanjeRegCenSaMenadzerom_Load(object sender, EventArgs e)
        {
            this.Prikazi();
            lblAdresa.Text = centar.Adresa;
        }

        public void Prikazi()
        {
            menadzerko = DTOManager.getMenadzereIzCentra(centar.Id);
            dgvMenadzeriUCentru.DataSource = menadzerko;
            dgvMenadzeriUCentru.Columns[0].Visible = false;
            combo.DataSource = DTOManager.getMenadzerViews().Where(item => !menadzerko.Any(item2 => item2.Id == item.Id)).ToList();
        }

        private void btnDodeli_Click(object sender, EventArgs e)
        {
            if (combo.SelectedItem == null)
                return;
            if (dtpVoziloDo.Value < dtpVoziloOd.Value)
                return;

            JeZaduzen jz = new JeZaduzen();
            jz.Centar = DTOManager.getCentar(centar.Id);
            jz.MenadzerCentra = DTOManager.getMenadzer((combo.SelectedItem as MenadzerView).Id);
            jz.ZaduzenDo = dtpVoziloDo.Value;
            jz.ZaduzenOd = dtpVoziloOd.Value;

            DTOManager.addJeZaduzen(jz);
            Prikazi();

        }
    }
}
