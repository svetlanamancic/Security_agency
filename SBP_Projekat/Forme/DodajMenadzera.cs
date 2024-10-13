using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using SBP_Projekat.DTOs;
using SBP_Projekat.Entiteti;

namespace SBP_Projekat.Forme
{
    public partial class DodajMenadzera : MetroForm
    {
        #region Atributi

        private HashSet<StringValue> listaGradova;
        private bool kreiraj = true;
        private MenadzerView menadzer;

        #endregion

        #region Konstruktori
        public DodajMenadzera()
        {
            Init();
            kreiraj = true;
           
        }

        public DodajMenadzera(int id)            
        {
            Init();
            kreiraj = false;
            menadzer = DTOManager.getMenadzerView(id);
            PopuniKontrole();
            PrikaziGradove();
        }

        public void Init()
        {
            InitializeComponent();
            listaGradova = new HashSet<StringValue>();
            
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

        private void txtGradovi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region Funkcije

        public void PopuniKontrole()
        {
            txtIme.Text = menadzer.Ime; 
            txtJMBG.Text = menadzer.Jmbg;
            txtPrezime.Text = menadzer.Prezime;
            if (menadzer.Pol == 'M')
                radioM.Checked = true;
            else
                radioZ.Checked = true;
            dtpRodjenja.Value = menadzer.DatRodj;
            dgvGradovi.DataSource = listaGradova.ToList();
            dgvGradovi.Columns[0].HeaderText = "Grad";
           
            foreach(GradMenadzerView g in menadzer.Gradovi)
            {
                listaGradova.Add(new StringValue( g.Grad));
            }

            
            
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
            else if (string.IsNullOrEmpty(txtJMBG.Text))
            {
                return false;
            }
            else if (!(radioZ.Checked || radioM.Checked))
            {
                return false;
            }
            return true;
        }

        public void PrikaziGradove()
        {
            dgvGradovi.DataSource = listaGradova.ToList();
            dgvGradovi.Columns[0].HeaderText = "Grad";
        }
        #endregion

        #region Dogadjaji

        private void btnSacuvajGrad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGradovi.Text))
            {
                return;
            }
            listaGradova.Add(new StringValue(txtGradovi.Text));
            txtGradovi.Text = "";
            PrikaziGradove();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (kreiraj)
            {
                if (!Validacija())
                    return;

                Menadzer z = new Menadzer();

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
                z.Pozicija = "Menadzer";

                

                DTOManager.AddMenadzer(z);

                if (listaGradova.Count != 0)
                {
                    foreach (var grad in listaGradova)
                    {
                        if (z.Gradovi.Where(x => x.Grad == grad.Value).ToList().Count() > 0)
                            continue;
                        else
                        {
                            DTOManager.addGradMenadzer(z.Id, grad.Value);
                        }
                    }
                    foreach (var grad in z.Gradovi)
                    {
                        if (listaGradova.Where(x => x.Value == grad.Grad).ToList().Count() == 0)
                            DTOManager.deleteGradMenadzer(grad.Id);

                    }

                }
                DTOManager.updateMenadzer(menadzer);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (!Validacija())
                    return;
                
                menadzer.Ime = txtIme.Text;
                menadzer.Prezime = txtPrezime.Text;
                menadzer.Jmbg = txtJMBG.Text;
                menadzer.DatRodj = dtpRodjenja.Value;
                if (radioZ.Checked)
                {
                    menadzer.Pol = 'Z';
                }
                else
                {
                    menadzer.Pol = 'M';
                }
                if (listaGradova.Count != 0)
                {
                    foreach (var grad in listaGradova)
                    {
                        if (menadzer.Gradovi.Where(x => x.Grad == grad.Value).ToList().Count() > 0)
                            continue;
                        else
                        {
                            DTOManager.addGradMenadzer(menadzer.Id, grad.Value);
                        }
                    }
                    foreach (var grad in menadzer.Gradovi)
                    {
                        if (listaGradova.Where(x => x.Value == grad.Grad).ToList().Count() == 0)
                            DTOManager.deleteGradMenadzer(grad.Id);

                    }

                }
                DTOManager.updateMenadzer(menadzer);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void btnDeleteGrad_Click(object sender, EventArgs e)
        {
            if (dgvGradovi.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvGradovi.SelectedRows)
            {
                listaGradova.Remove(((StringValue)dgvGradovi.SelectedRows[0].DataBoundItem));

            }
            PrikaziGradove();
        }

        #endregion




    }
}
