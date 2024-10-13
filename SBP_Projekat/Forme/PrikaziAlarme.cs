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
    public partial class PrikaziAlarme : MetroForm
    {
        #region Atributi

        private List<AlarmView> alarmi;
        private ObjekatView objekat;

        #endregion

        #region Konstruktori

        public PrikaziAlarme()
        {
            InitializeComponent();
            objekat = new ObjekatView();
            alarmi = new List<AlarmView>();
            Prikazi();
        }

        public PrikaziAlarme(ObjekatView o)
        {
            InitializeComponent();
            objekat = o;
            Prikazi();
        }

        #endregion

        #region Funkcije

        public void Prikazi()
        {
            alarmi = DTOManager.getAlarmi(objekat.Id);
            dgvAlarmi.DataSource = alarmi;
            dgvAlarmi.Columns[3].Visible = false;
            dgvAlarmi.Columns[4].Visible = false;
            dgvAlarmi.Columns[5].Visible = false;
            dgvAlarmi.Columns[6].Visible = false;
        }

        #endregion

        #region Dogadjaji
        
        private void btnDodajAlarm_Click(object sender, EventArgs e)
        {
            var Forma = new DodajAlarm(objekat);
            Forma.ShowDialog();
            Prikazi();
        }

        private void btnObrisiAlarm_Click(object sender, EventArgs e)
        {
            if (dgvAlarmi.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvAlarmi.SelectedRows)
            {
                int id = ((AlarmView)dgvAlarmi.SelectedRows[0].DataBoundItem).Id;
                DTOManager.deleteAlarm(id);

            }
            Prikazi();
        }

        #endregion


    }
}
