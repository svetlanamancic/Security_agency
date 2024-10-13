using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using SBP_Projekat.Entiteti;
using SBP_Projekat.DTOs;
using System.Collections.Generic;

namespace SBP_Projekat.Forme
{
    public partial class DodajAlarm : MetroForm
    {
        #region Atributi

        private List<TehnickoLiceView> lista;
        private ObjekatView o;

        #endregion

        #region Konstruktori

        public DodajAlarm(ObjekatView obj)
        {
            InitializeComponent();
            o = obj;
            lista = new List<TehnickoLiceView>();
            comboTehnicko.DataSource = DTOManager.getTehnickoLiceViews();
            rbnDetektorPokreta.Checked = true;
        }

        #endregion

        #region Funkcije

        private new bool Validate()
        {
            if (String.IsNullOrEmpty(txtGodina.Text))
                return false;
            if (String.IsNullOrEmpty(txtProizvodjac.Text))
                return false;
            if (lista.Count == 0)
                return false;

            if (rbnDetektorPokreta.Checked)
            {
                if (String.IsNullOrEmpty(txtOsetljivost.Text))
                    return false;
            }
            else if (rbnUltrazvucni.Checked)
            {
                if (String.IsNullOrEmpty(txtOpsegOd.Text))
                    return false;
                if (String.IsNullOrEmpty(txtOpsegDo.Text))
                    return false;
            }
            else
            {
                if (String.IsNullOrEmpty(txtVertikalna.Text))
                    return false;
                if (String.IsNullOrEmpty(txtHorizontalna.Text))
                    return false;
            }
            return true;
        }

        private void RefreshTehnicare()
        {
            dgvTehnicari.DataSource = lista;
            dgvTehnicari.Columns[0].Visible = false;
            dgvTehnicari.Columns[1].Visible = false;
        }

        #endregion

        #region Dogadjaji

        private void radioChecked_changed(object sender, EventArgs e)
        {
            if(rbnDetektorPokreta.Checked)
            {
                txtOsetljivost.Enabled = true;

                txtOpsegOd.Enabled = false;
                txtOpsegDo.Enabled = false;

                txtHorizontalna.Enabled = false;
                txtVertikalna.Enabled = false;
            }
            else if (rbnToplotni.Checked)
            {
                txtOsetljivost.Enabled = false;

                txtOpsegOd.Enabled = false;
                txtOpsegDo.Enabled = false;

                txtHorizontalna.Enabled = true;
                txtVertikalna.Enabled = true;
            }
            else
            {
                txtOsetljivost.Enabled = false;

                txtOpsegOd.Enabled = true;
                txtOpsegDo.Enabled = true;

                txtHorizontalna.Enabled = false;
                txtVertikalna.Enabled = false;
            }
        } 
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            if(rbnDetektorPokreta.Checked)
            {
                DetektorPokreta alarm = new DetektorPokreta();
                alarm.GodinaProizvodnje = Int32.Parse(txtGodina.Text);
                alarm.Proizvodjac = txtProizvodjac.Text;
                alarm.Tip = "Detektor pokreta";
                alarm.Osetljivost = Int32.Parse(txtOsetljivost.Text);
                
                DTOManager.addDetektorPokreta(alarm);
                DTOManager.addInstaliran(o, alarm.Id);

                foreach (var teh in lista)
                {
                    DTOManager.addTehnicarAlarm(teh.Id, alarm.Id);
                }
                
            }
            else if(rbnToplotni.Checked)
            {
                ToplotniOdraz alarm = new ToplotniOdraz();
                alarm.GodinaProizvodnje = Int32.Parse(txtGodina.Text);
                alarm.Proizvodjac = txtProizvodjac.Text;
                alarm.Tip = "Toplotni odraz";
                alarm.HorizontalnaRezolucija = Int32.Parse(txtHorizontalna.Text);
                alarm.VertikalnaRezolucija = Int32.Parse(txtVertikalna.Text);
                
                DTOManager.addToplotniOdraz(alarm);
                DTOManager.addInstaliran(o, alarm.Id);


                foreach (var teh in lista)
                {
                    DTOManager.addTehnicarAlarm(teh.Id, alarm.Id);
                }
            }
            else
            {
                UltrazvucniAlarm alarm = new UltrazvucniAlarm();
                alarm.GodinaProizvodnje = Int32.Parse(txtGodina.Text);
                alarm.Proizvodjac = txtProizvodjac.Text;
                alarm.Tip = "Ultrazvucni alarm";
                alarm.Od = Int32.Parse(txtOpsegOd.Text);
                alarm.Do = Int32.Parse(txtOpsegDo.Text);
                
                DTOManager.addUltrazvucniAlarm(alarm);
                DTOManager.addInstaliran(o, alarm.Id);

                foreach (var teh in lista)
                {
                    DTOManager.addTehnicarAlarm(teh.Id, alarm.Id);
                }
            }
            
            DTOManager.updateObjekat(o);
            this.DialogResult = DialogResult.OK;
        }

        private void btnDodajTehnicara_Click(object sender, EventArgs e)
        {
            if (comboTehnicko.SelectedItem == null)
                return;
           
            lista.Add(comboTehnicko.SelectedItem as TehnickoLiceView);
            RefreshTehnicare();
        }

        #endregion

        #region KeyPressEvents

        private void txtOsetljivost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtOpsegOd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtOpsegDo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtHorizontalna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtVertikalna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGodina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) )
                e.Handled = true;
        }

        #endregion
    }
}
