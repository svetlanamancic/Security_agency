using MetroFramework.Forms;
using SBP_Projekat.DTOs;
using SBP_Projekat.Entiteti;
using System;
using System.Windows.Forms;


namespace SBP_Projekat.Forme
{
    public partial class DodajVoziloURegCentar : MetroForm
    {

        #region Atributi

        private RegionalniCentarView centar;
        private VoziloView vozilo;
        private bool kreiraj;

        #endregion

        #region Kontruktori

        public DodajVoziloURegCentar()
        {
            Init();
        }

        public DodajVoziloURegCentar(RegionalniCentarView r)
        {
            Init();
            centar = r;
            kreiraj = true;
        }

        public DodajVoziloURegCentar(VoziloView v)
        {
            Init();
            kreiraj = false;
            vozilo = v;
            PopuniKontrole();
        }

        public void Init()
        {
            InitializeComponent();
            centar = new RegionalniCentarView();
            vozilo = new VoziloView();
        }

        #endregion
        
        #region Funkcije

        public void PopuniKontrole()
        {
            txtBoja.Text = vozilo.Boja;
            txtModel.Text = vozilo.Model;
            txtProizvodjac.Text = vozilo.Proizvodjac;
            txtRegOznaka.Text = vozilo.RegistarskaOznaka;
            txtTip.Text = vozilo.Tip;
        }

        public bool Validacija()
        {
            if(string.IsNullOrEmpty(txtBoja.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(txtModel.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(txtProizvodjac.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(txtRegOznaka.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(txtTip.Text))
            {
                return false;
            }
            return true;
        }

        #endregion

        #region KeyPressEvents

        private void txtRegOznaka_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtModel_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }

        private void txtTip_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }

        private void txtProizvodjac_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }

        private void txtBoja_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSeparator(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #region Dogadjaji

        private void btnOdustani_Click(object sender, System.EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kreiraj)
            {
                if (!Validacija())
                    return;

                Vozilo z = new Vozilo();

                z.RegistarskaOznaka = txtRegOznaka.Text;
                z.Tip = txtTip.Text;
                z.Model = txtModel.Text;
                z.Boja = txtBoja.Text;
                z.Proizvodjac = txtProizvodjac.Text;
                z.PripadaCentru = DTOManager.getCentar(centar.Id);
                
                DTOManager.AddVozilo(z);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (!Validacija())
                    return;

                vozilo.RegistarskaOznaka = txtRegOznaka.Text;
                vozilo.Tip = txtTip.Text;
                vozilo.Model = txtModel.Text;
                vozilo.Boja = txtBoja.Text;
                vozilo.Proizvodjac = txtProizvodjac.Text;
                
                
                DTOManager.updateVozilo(vozilo);
                this.DialogResult = DialogResult.OK;
            }
        }
        #endregion
    }
}
