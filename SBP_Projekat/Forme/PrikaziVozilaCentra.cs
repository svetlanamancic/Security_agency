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
    public partial class PrikaziVozilaCentra : MetroForm
    {

        #region Atributi

        private List<VoziloView> vozila;
        private RegionalniCentarView centar;

        #endregion

        #region Kontruktori

        public PrikaziVozilaCentra()
        {
            InitializeComponent();
            centar = new RegionalniCentarView();
            vozila = new List<VoziloView>();
        }

        public PrikaziVozilaCentra(RegionalniCentarView r)
        {
            InitializeComponent();
            centar = r;
            PrikaziVozila();
        }

        #endregion

        #region Funkcije

        public void PrikaziVozila()
        {
            vozila = DTOManager.getVozilaCentra(centar.Id);
            dgvVozila.DataSource = vozila;
        }

        #endregion

        #region Dogadjaji

        private void btnAddVozilo_Click(object sender, EventArgs e)
        {
            var Forma = new DodajVoziloURegCentar(centar);
            Forma.ShowDialog();
            PrikaziVozila();
        }

        private void dgvVozila_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Forma = new DodajVoziloURegCentar(((VoziloView)dgvVozila.Rows[e.RowIndex].DataBoundItem));
            DialogResult dr = Forma.ShowDialog();
            if (dr == DialogResult.OK)
                PrikaziVozila();
        }
        #endregion
    }
}
