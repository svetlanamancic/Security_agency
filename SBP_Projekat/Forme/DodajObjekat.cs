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
    public partial class DodajObjekat : MetroForm
    {
        #region Atributi

        public HashSet<StringValue> listaTelefona;
        private ObjekatView objekat;
        private bool izmena;

        #endregion

        #region Konstruktori

        public DodajObjekat()
        {
            InitializeComponent();
            listaTelefona = new HashSet<StringValue>();
            dgvTelefoni.DataSource = listaTelefona;
            izmena = false;
            btnAlarmi.Visible = false;
        }

        public DodajObjekat(int id)
        { 
            InitializeComponent();
            listaTelefona = new HashSet<StringValue>();
            dgvTelefoni.DataSource = listaTelefona;
               
            objekat = DTOManager.getObjekatView(id);
            izmena = true;
            PopuniKontrole();
        }

        #endregion

        #region Funkcije

        private void PopuniKontrole()
        {
            txtTip.Text = objekat.Tip;
            txtAdresa.Text = objekat.Adresa;
            txtPovrsina.Text = objekat.Povrsina.ToString();

            if (objekat.Telefoni != null && objekat.Telefoni.Count > 0) 
            {
                foreach (var tel in objekat.Telefoni)
                    listaTelefona.Add(new StringValue( tel.Telefon));
            }
            dgvTelefoni.DataSource = listaTelefona.ToList();
            dgvTelefoni.Columns[0].HeaderText = "Telefon";
            
        }

        private new bool Validate()
        {
            if (string.IsNullOrEmpty(txtTip.Text))
                return false;
            if (string.IsNullOrEmpty(txtAdresa.Text))
                return false;
            if (string.IsNullOrEmpty(txtAdresa.Text))
                return false;

            return true;
        }
            
        #endregion

        #region Dogadjaji

        private void btnDodajTelefon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefoni.Text))
                return;
            listaTelefona.Add(new StringValue( txtTelefoni.Text));
            txtTelefoni.Text = "";
            dgvTelefoni.DataSource = listaTelefona.ToList();
            dgvTelefoni.Columns[0].HeaderText = "Telefon";
        }

        private void btnSacuvaj1_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            if(izmena)
            {
                objekat.Adresa = txtAdresa.Text;
                objekat.Povrsina = float.Parse(txtPovrsina.Text);
                objekat.Tip = txtTip.Text;

                if (listaTelefona.Count > 0)
                {
                    foreach(var telefon in listaTelefona)
                    {
                        if (objekat.Telefoni.Where(x => x.Telefon == telefon.Value).ToList().Count > 0)
                            continue;
                        DTOManager.addKontaktTelefon(objekat.Id, telefon.Value);
                    }
                }
                DTOManager.updateObjekat(objekat);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Objekat o = new Objekat();

                o.Adresa = txtAdresa.Text;
                o.Povrsina = float.Parse(txtPovrsina.Text);
                o.Tip = txtTip.Text;

                DTOManager.addObjekat(o);

                if (listaTelefona.Count > 0)
                {
                    foreach(var telefon in listaTelefona)
                    {
                        DTOManager.addKontaktTelefon(o.Id, telefon.Value);
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnOdustani1_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void btnAlarmi_Click(object sender, EventArgs e)
        {
            var Form = new PrikaziAlarme(objekat);
            Form.ShowDialog();
        }

        #endregion
        
        #region KeyPressEvents

        private void txtTip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }

        private void txtAdresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }

        private void txtPovrsina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTelefoni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

#endregion
    }
}
