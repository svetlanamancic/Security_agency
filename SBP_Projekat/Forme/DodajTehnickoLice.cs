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
    public partial class DodajTehnickoLice : MetroForm
    {
        #region Atributi

        private HashSet<StringValue> listaStrSprema;
        private HashSet<StringValue> listaOblasti;
        private bool kreiraj = true;
        private TehnickoLiceView tehnickoLice;

        #endregion

        #region Kontruktori

        public DodajTehnickoLice()
        {
            Init();
            kreiraj = true;            
        }
        public DodajTehnickoLice(int idt)
        {
            Init();
            kreiraj = false;            
            tehnickoLice = DTOManager.getTehnickoLiceView(idt);
            PopuniKontrole();
        }
        public void Init()
        {
            InitializeComponent();
            listaOblasti = new HashSet<StringValue>();
            listaStrSprema = new HashSet<StringValue>();
            PrikaziOblasti();
            PrikaziStrucneSpreme();
        }
        #endregion

        #region Funkcije

        public void PopuniKontrole()
        {
            txtIme.Text = tehnickoLice.Ime;
            txtJMBG.Text = tehnickoLice.Jmbg;
            txtPrezime.Text = tehnickoLice.Prezime;
            if (tehnickoLice.Pol == 'M')
                radioM.Checked = true;
            else
                radioZ.Checked = true;
            if (tehnickoLice.OblastiTehnike.Count > 0)
            {
                foreach (OblastTehnikeView g in tehnickoLice.OblastiTehnike)
                {
                    listaOblasti.Add(new StringValue(g.Oblast));
                }
            }
            if (tehnickoLice.StrucneSpreme.Count > 0)
            {
                foreach (StrucnaSpremaView g in tehnickoLice.StrucneSpreme)
                {
                    listaStrSprema.Add(new StringValue(g.Struka));
                }
            }
            dtpRodjenja.Value = tehnickoLice.DatRodj;
            dgvOblasti.DataSource = listaOblasti.ToList();
            dgvStruke.DataSource =listaStrSprema.ToList();
            dgvOblasti.Columns[0].HeaderText = "Oblast tehnike";
            dgvStruke.Columns[0].HeaderText = "Strucna sprema";
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

        public void PrikaziOblasti()
        {
            dgvOblasti.DataSource = listaOblasti.ToList();
            dgvOblasti.Columns[0].HeaderText = "Oblast tehnike";
        }

        public void PrikaziStrucneSpreme()
        {
            dgvStruke.DataSource = listaStrSprema.ToList();
            dgvStruke.Columns[0].HeaderText = "Strucna sprema";
        }
        #endregion

        #region KeyPressEvents

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtOblastTehnike_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }


        private void txtStrucnaSprema_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region Dogadjaji

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (dgvStruke.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvStruke.SelectedRows)
            {
                listaStrSprema.Remove(((StringValue)dgvStruke.SelectedRows[0].DataBoundItem));

            }
            PrikaziStrucneSpreme();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (dgvOblasti.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvOblasti.SelectedRows)
            {
                listaOblasti.Remove(((StringValue)dgvOblasti.SelectedRows[0].DataBoundItem));

            }
            PrikaziOblasti();
        }

        private void btnSacuvajStrucnuSpremu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStrucnaSprema.Text))
            {
                return;
            }
            listaStrSprema.Add(new StringValue(txtStrucnaSprema.Text));
            txtStrucnaSprema.Text = "";
            PrikaziStrucneSpreme();
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            if (kreiraj)
            {
                if (!Validacija())
                    return;

                TehnickoLice z = new TehnickoLice();

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
                z.Pozicija = "Tehnicko lice";
                
                DTOManager.AddTehnickoLice(z);

                if (listaOblasti.Count != 0)
                {
                    foreach (var oblast in listaOblasti)
                    {
                        if (z.OblastiTehnike.Where(x => x.ObTeh == oblast.Value).ToList().Count() > 0)
                            continue;
                        else
                        {
                            DTOManager.addOblastTehnike(z.Id, oblast.Value);
                        }
                    }
                    foreach (var oblast in z.OblastiTehnike)
                    {
                        if (listaOblasti.Where(x => x.Value == oblast.ObTeh).ToList().Count() == 0)
                            DTOManager.deleteOblastTehnike(oblast.Id);
                    }
                }

                if (listaStrSprema.Count != 0)
                {
                    foreach (var struka in listaStrSprema)
                    {
                        if (z.StrucneSpreme.Where(x => x.StrucnaSpremaTehnicara == struka.Value).ToList().Count() > 0)
                            continue;
                        else
                        {
                            DTOManager.addStrucnaSprema(z.Id, struka.Value);
                        }
                    }
                    foreach (var struka in z.StrucneSpreme)
                    {
                        if (listaStrSprema.Where(x => x.Value == struka.StrucnaSpremaTehnicara).ToList().Count() == 0)
                            DTOManager.deleteStrucnaSprema(struka.Id);
                    }
                }

                DTOManager.updateTehnickoLice(new TehnickoLiceView(z));

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (!Validacija())
                    return;

                tehnickoLice.Ime = txtIme.Text;
                tehnickoLice.Prezime = txtPrezime.Text;
                tehnickoLice.Jmbg = txtJMBG.Text;
                tehnickoLice.DatRodj = dtpRodjenja.Value;
                if (radioZ.Checked)
                {
                    tehnickoLice.Pol = 'Z';
                }
                else
                {
                    tehnickoLice.Pol = 'M';
                }
                if (listaOblasti.Count != 0)
                {
                    foreach (var oblast in listaOblasti)
                    {
                        if (tehnickoLice.OblastiTehnike.Where(x => x.Oblast == oblast.Value).ToList().Count() > 0)
                            continue;
                        else
                        {
                            DTOManager.addOblastTehnike(tehnickoLice.Id, oblast.Value);
                        }
                    }
                    foreach (var oblast in tehnickoLice.OblastiTehnike)
                    {
                        if (listaOblasti.Where(x => x.Value == oblast.Oblast).ToList().Count() == 0)
                            DTOManager.deleteOblastTehnike(oblast.Id);
                    }
                }

                if (listaStrSprema.Count != 0)
                {
                    foreach (var struka in listaStrSprema)
                    {
                        if (tehnickoLice.StrucneSpreme.Where(x => x.Struka == struka.Value).ToList().Count() > 0)
                            continue;
                        else
                        {
                            DTOManager.addStrucnaSprema(tehnickoLice.Id, struka.Value);
                        }
                    }
                    foreach (var struka in tehnickoLice.StrucneSpreme)
                    {
                        if (listaStrSprema.Where(x => x.Value == struka.Struka).ToList().Count() == 0)
                            DTOManager.deleteStrucnaSprema(struka.Id);
                    }
                }

                DTOManager.updateTehnickoLice(tehnickoLice);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnSacuvajOblastTehnike_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOblastTehnike.Text))
            {
                return;
            }
            listaOblasti.Add(new StringValue( txtOblastTehnike.Text));
            txtOblastTehnike.Text = "";
            PrikaziOblasti();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        #endregion

        
    }
}
