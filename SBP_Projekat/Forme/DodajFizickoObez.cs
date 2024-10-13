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
    public partial class DodajFizickoObez : MetroForm
    {
        #region Atributi

        private HashSet<StringValue> listaVestina;
        private bool kreiraj = true;
        private FizickoObezbedjenjeView fizickoObezbedjenje;

        #endregion

        #region Konstruktori

        public DodajFizickoObez()
        {
            Init();
            kreiraj = true;
        }

        public DodajFizickoObez(int id)
        {
            Init();
            kreiraj = false;
            fizickoObezbedjenje = DTOManager.getFizickoObezbedjenjeView(id);
            PopuniKontrole();
        }

        public void Init()
        {
            InitializeComponent();
            listaVestina = new HashSet<StringValue>();
            dgvVestine.DataSource = listaVestina.ToList();
            dgvVestine.Columns[0].HeaderText = "Borilacke vestine";
        }
        #endregion

        #region KeyPressEvents

        private void txtJMBG_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }

        private void txtPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }

        private void txtBorilackaVestina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region Funkcije

        public void PopuniKontrole()
        {
            txtIme.Text = fizickoObezbedjenje.Ime;
            txtJMBG.Text = fizickoObezbedjenje.Jmbg;
            txtPrezime.Text = fizickoObezbedjenje.Prezime;
            if (fizickoObezbedjenje.Pol == 'M')
                radioM.Checked = true;
            else
                radioZ.Checked = true;
            dtpRodjenja.Value = fizickoObezbedjenje.DatRodj;
            if (fizickoObezbedjenje.BorilackeVestine != null && fizickoObezbedjenje.BorilackeVestine.Count > 0)
            {
                foreach (var bv in fizickoObezbedjenje.BorilackeVestine)
                    listaVestina.Add(new StringValue(bv.Vestina));
            }
            dgvVestine.DataSource = listaVestina.ToList();
            dgvVestine.Columns[0].HeaderText = "Borilacke vestine";
        }

        public bool Validacija()
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(txtPrezime.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(txtJMBG.Text))//|| txtJMBG.Text.Length != 13
            {
                return false;
            }
            else if (!(radioZ.Checked || radioM.Checked))
            {
                return false;
            }
            return true;
        }

        public void PrikaziVestine()
        {
            dgvVestine.DataSource = listaVestina.ToList();
            dgvVestine.Columns[0].HeaderText = "Borilacke vestine";
        }
        #endregion

        #region Dogadjaji

        private void btnDeleteVestina_Click(object sender, EventArgs e)
        {
            if (dgvVestine.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvVestine.SelectedRows)
            {
                listaVestina.Remove(((StringValue)dgvVestine.SelectedRows[0].DataBoundItem));

            }
            PrikaziVestine();
        }

        private void btnSacuvajVestinu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBorilackaVestina.Text))
            {
                return;
            }
            listaVestina.Add(new StringValue(txtBorilackaVestina.Text));
            txtBorilackaVestina.Text = "";
            PrikaziVestine();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (kreiraj)
            {
                if (!Validacija())
                    return;

                FizickoObezbedjenje z = new FizickoObezbedjenje();

                z.Ime = txtIme.Text;
                z.Prezime = txtPrezime.Text;
                z.JMBG = txtJMBG.Text;
                z.DatRodj = dtpRodjenja.Value;
                if (radioZ.Checked)
                {
                    z.Pol = 'Z';
                }
                else
                {
                    z.Pol = 'M';
                }
                z.Pozicija = "Fizicko obezbedjenje";
                
                DTOManager.AddFizickoObezbedjenje(z);

                if (listaVestina.Count != 0)
                {
                    foreach (var vestina in listaVestina)
                    {
                        if (z.BorilackeVestine.Where(x => x.Vestina == vestina.Value).ToList().Count() > 0)
                            continue;
                        else
                        {
                            DTOManager.addBorilackaVestina(z.Id, vestina.Value);
                        }
                    }
                    foreach (var vestina in z.BorilackeVestine)
                    {
                        if (listaVestina.Where(x => x.Value == vestina.Vestina).ToList().Count() == 0)
                            DTOManager.deleteBorilackaVestina(vestina.Id);
                    }

                }
                DTOManager.updateFizickoObezbedjenje(new FizickoObezbedjenjeView(z));

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (!Validacija())
                    return;

                fizickoObezbedjenje.Ime = txtIme.Text;
                fizickoObezbedjenje.Prezime = txtPrezime.Text;
                fizickoObezbedjenje.Jmbg = txtJMBG.Text;
                fizickoObezbedjenje.DatRodj = dtpRodjenja.Value;
                if (radioZ.Checked)
                {
                    fizickoObezbedjenje.Pol = 'Z';
                }
                else
                {
                    fizickoObezbedjenje.Pol = 'M';
                }
                if (listaVestina.Count != 0)
                {
                    foreach (var vestina in listaVestina)
                    {
                        if (fizickoObezbedjenje.BorilackeVestine.Where(x => x.Vestina == vestina.Value).ToList().Count() > 0)
                            continue;
                        else
                        {
                            DTOManager.addBorilackaVestina(fizickoObezbedjenje.Id, vestina.Value);
                        }
                    }
                    foreach (var vestina in fizickoObezbedjenje.BorilackeVestine)
                    {
                        if (listaVestina.Where(x => x.Value == vestina.Vestina).ToList().Count() == 0)
                            DTOManager.deleteBorilackaVestina(vestina.Id);                        
                    }
                }
                DTOManager.updateFizickoObezbedjenje(fizickoObezbedjenje);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }
        #endregion

        
    }
}

