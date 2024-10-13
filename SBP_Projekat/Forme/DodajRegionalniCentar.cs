using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using SBP_Projekat.Entiteti;
using SBP_Projekat.DTOs;

namespace SBP_Projekat.Forme
{
    public partial class DodajRegionalniCentar : MetroForm
    {

        #region Atributi

        private RegionalniCentarView centar;
        private HashSet<StringValue> brojevi;
        private HashSet<StringValue> gradovi;
        private bool kreiraj;

        #endregion

        #region Konstruktori

        public DodajRegionalniCentar()
        {
            InitializeComponent();
            brojevi = new HashSet<StringValue>();
            gradovi = new HashSet<StringValue>();
            btnVozila.Visible = false;
            kreiraj = true;
        }

        public DodajRegionalniCentar(int id)
        {
            InitializeComponent();
            brojevi = new HashSet<StringValue>();
            gradovi = new HashSet<StringValue>();
            centar = DTOManager.getCentarView(id);
            kreiraj = false;
            PopuniKontrole();
        }

        #endregion

        #region Dogadjaji

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (dgvBrojevi.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvBrojevi.SelectedRows)
            {
                brojevi.Remove(((StringValue)dgvBrojevi.SelectedRows[0].DataBoundItem));

            }
            PrikaziBrojeve();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (dgvGradovi.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvGradovi.SelectedRows)
            {
                gradovi.Remove(((StringValue)dgvGradovi.SelectedRows[0].DataBoundItem));

            }
            PrikaziGradove();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBrojevi.Text))
            {
                return;
            }
            brojevi.Add(new StringValue(txtBrojevi.Text));
            txtBrojevi.Text = "";
            PrikaziBrojeve();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGradovi.Text))
            {
                return;
            }
            gradovi.Add(new StringValue(txtGradovi.Text));
            txtGradovi.Text = "";
            PrikaziGradove();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            var Forma = new PrikaziVozilaCentra(centar);
            Forma.ShowDialog();

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kreiraj)
            {
                if (!Validacija())
                    return;

                RegionalniCentar z = new RegionalniCentar();

                z.Adresa = txtAdresa.Text;
                
                DTOManager.AddRegionalniCentar(z);

                if (brojevi.Count() > 0)
                {
                    if (z.Telefoni == null)
                    {
                        z.Telefoni = new List<BrojTelefona>();
                    }
                    foreach (var b in brojevi)
                    {

                        if (z.Telefoni.Where(x => x.BrTel == b.Value).ToList().Count() > 0)
                            continue;

                        DTOManager.addBrojTelefona(z.Id, b.Value);

                    }
                }
                foreach (var b in z.Telefoni)
                {
                    if (brojevi.Where(x => x.Value == b.BrTel).ToList().Count() == 0)
                        DTOManager.deleteTelefon(b.Id);

                }

                if (gradovi.Count() > 0)
                {
                    if (z.Gradovi == null)
                    {
                        z.Gradovi = new List<GradCentar>();
                    }
                    foreach (var g in gradovi)
                    {
                        if (z.Gradovi.Where(x => x.Grad == g.Value).ToList().Count() > 0)
                            continue;
                        else
                        {
                            DTOManager.addGradCentar(z.Id, g.Value);
                        }
                    }
                }
                foreach (var g in z.Gradovi)
                {
                    if (gradovi.Where(x => x.Value == g.Grad).ToList().Count() == 0)
                        DTOManager.deleteGradCentar(g.Id);
                }

                DTOManager.updateRegionalniCentar(new RegionalniCentarView(z));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (!Validacija())
                    return;
                
                centar.Adresa = txtAdresa.Text;

                DTOManager.updateRegionalniCentar(centar);

                if (brojevi.Count() > 0)
                {
                    foreach (var b in brojevi)
                    {
                        if (centar.Telefoni.Where(x => x.BrTel == b.Value).ToList().Count() > 0)
                            continue;
                        else
                        {
                            DTOManager.addBrojTelefona(centar.Id, b.Value);
                        }
                    }
                }

                foreach (var b in centar.Telefoni)
                {
                    if (brojevi.Where(x => x.Value == b.BrTel).ToList().Count() == 0)
                        DTOManager.deleteTelefon(b.Id);
                }

                if (gradovi.Count() > 0)
                {
                    foreach (var g in gradovi)
                    {
                        if (centar.Gradovi.Where(x => x.Grad == g.Value).ToList().Count() > 0)
                            continue;
                        else
                        {
                            DTOManager.addGradCentar(centar.Id, g.Value);
                        }
                    }
                }
                foreach (var g in centar.Gradovi)
                {
                    if (gradovi.Where(x => x.Value == g.Grad).ToList().Count() == 0)
                        DTOManager.deleteGradCentar(g.Id);
                }                
                this.DialogResult = DialogResult.OK;
            }
        }

        #region KeyPressEvents

        private void txtAdresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }

        private void txtBorilackaVestina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        #endregion

        #endregion

        #region Funkcije

        public bool Validacija()
        {
            if (string.IsNullOrEmpty(txtAdresa.Text))
            {
                return false;
            }
            return true;
        }

        public void PopuniKontrole()
        {

            txtAdresa.Text = centar.Adresa;
            
            txtBrojevi.Text = "";
            txtGradovi.Text = "";
            if (centar.Telefoni.Count > 0)
            {
                foreach (BrojTelefonaView b in centar.Telefoni)
                {
                    brojevi.Add(new StringValue(b.BrTel));
                }
            }
            if (centar.Gradovi.Count > 0)
            {
                foreach (GradCentarView g in centar.Gradovi)
                {
                    gradovi.Add(new StringValue(g.Grad));
                }
            }
            PrikaziBrojeve();
            PrikaziGradove();

        }

        public void PrikaziGradove()
        {
            dgvGradovi.DataSource = gradovi.ToList();
            dgvGradovi.Columns[0].HeaderText = "Grad";
        }

        public void PrikaziBrojeve()
        {
            dgvBrojevi.DataSource = brojevi.ToList() ;
            dgvBrojevi.Columns[0].HeaderText = "Broj telefona";
        }


        #endregion

        
    }
}
