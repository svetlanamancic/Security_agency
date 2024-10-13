using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroFramework.Forms;
using SBP_Projekat.Entiteti;
using SBP_Projekat.DTOs;

namespace SBP_Projekat.Forme
{
    public partial class VidiEkipu : MetroForm
    {
        private IntervencijaView intervencija;
        private bool izmena = false;       // =0
        private int idSmene;
        private bool kreirajEkipu = false;      // =0
        private int idEk = -10;

        public VidiEkipu()
        {
            InitializeComponent();
            //izmena = false;
        }

        private void VidiEkipu_Load(object sender, EventArgs e)
        {
            this.Prikazi();
        }

        private void Prikazi()
        {
            if(this.TabControl.SelectedTab == tabIntervencije)
            {
                dgvIntervencije.DataSource = DTOManager.getintervencije();
                comboObjekatIntervencija.DataSource = DTOManager.getObjekte();
                comboEkipaIntervencija.DataSource = DTOManager.getEkipe();
                comboObjekatIntervencija.SelectedItem = comboEkipaIntervencija.SelectedItem = null;
            }
            else if(this.TabControl.SelectedTab == tabSmene)
            {
                dgvSmene.DataSource = DTOManager.getSmene();
            }
            else if(this.TabControl.SelectedTab == tabEkipe)
            {
                dgvPregledEkipa.DataSource = DTOManager.getEkipe();
                dgvNerasporedjeni.DataSource = DTOManager.getNerasporedjeni();             
            }
            else if(TabControl.SelectedTab==tabZaduzenja)
            {
                comboEkipa.DataSource = DTOManager.getEkipe();
                comboObjekti.DataSource = DTOManager.getObjekte();
                comboVozila.DataSource = DTOManager.getVozila();
                comboSmene.DataSource = DTOManager.getSmene();

            }
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Prikazi();
        }

        #region Smene

        private void btnSacuvajSmenu_Click(object sender, EventArgs e)
        {
            if (izmena == false)
            {
                Smena sm = new Smena();
                DateTime vremePoc = DateTime.ParseExact(txtPocetakSmene.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                DateTime vremeKraj = DateTime.ParseExact(txtKrajSmene.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);

                sm.Pocetak = vremePoc;
                sm.Kraj = vremeKraj;
                DTOManager.AddSmene(sm);
                Prikazi();
            }
            else 
            {
                DateTime Poc = DateTime.ParseExact(txtPocetakSmene.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                DateTime Kraj = DateTime.ParseExact(txtKrajSmene.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                DTOManager.updateSmena(Poc, Kraj, idSmene);
                Prikazi();
            }
        }

        private void dgvSmene_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime dtt = (((SmenaView)dgvSmene.Rows[e.RowIndex].DataBoundItem).Pocetak);
            string vremePoc = dtt.ToString("HH:mm");
            this.txtPocetakSmene.Text = vremePoc;

            DateTime d = (((SmenaView)dgvSmene.Rows[e.RowIndex].DataBoundItem).Kraj);
            string vremeKraj = d.ToString("HH:mm");
            this.txtKrajSmene.Text = vremeKraj;

            this.metroLabel10.Text = "Izmena smene";
            this.izmena = true; ; //1 za izmenu
            this.idSmene = (((SmenaView)dgvSmene.Rows[e.RowIndex].DataBoundItem).Id);
            Prikazi();
        }

        #endregion

        #region intervencija
        private void btnCancelIntervencija_Click(object sender, EventArgs e)
        {
            txtVreme.Text = "";
            txtOpisTipa.Text = "";
            comboEkipaIntervencija.SelectedItem = null;
            comboObjekatIntervencija.SelectedItem = null;
            dtpIntervencija.Value = DateTime.Today;

            izmena = false;
        }

        private bool ValidacijaIntervencije()
        {
            if (String.IsNullOrEmpty(txtOpisTipa.Text))
                return false;
            if (String.IsNullOrEmpty(txtVreme.Text))
                return false;
            if (comboEkipaIntervencija.SelectedItem == null)
                return false;
            if (comboObjekatIntervencija.SelectedItem == null)
                return false;
            if (dtpIntervencija.Value > DateTime.Now)
                return false;
            if (DateTime.ParseExact(txtVreme.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture) == null)
                return false;

            return true;
        }

        private void btnSaveIntervencija_Click(object sender, EventArgs e)
        {
            if (!ValidacijaIntervencije())
                return;
            if(izmena)
            {
                intervencija.Datum = dtpIntervencija.Value;
                intervencija.Vreme = DateTime.ParseExact(txtVreme.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                intervencija.OpisTipa = txtOpisTipa.Text;
                intervencija.Ekipica = DTOManager.getEkipaView((comboEkipaIntervencija.SelectedItem as EkipaView).Id);
                intervencija.Objektic= DTOManager.getObjekatView((comboObjekatIntervencija.SelectedItem as ObjekatView).Id);
                DTOManager.updateIntervencija(intervencija);
            }
            else
            {
                VrsiIntervenciju interv = new VrsiIntervenciju();
                interv.Datum = dtpIntervencija.Value;
                interv.Vreme = DateTime.ParseExact(txtVreme.Text, "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                interv.OpisTipa = txtOpisTipa.Text;
                interv.VrsiEkipa = DTOManager.getEkipa((comboEkipaIntervencija.SelectedItem as EkipaView).Id);
                interv.UObjektu = DTOManager.getObjekat((comboObjekatIntervencija.SelectedItem as ObjekatView).Id);

                DTOManager.addIntervencija(interv);
                
            }
            btnCancelIntervencija_Click(null, null);
            Prikazi();
            izmena = false;
        }

        private void dgvIntervencije_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            izmena = true;
            int id = (dgvIntervencije.Rows[e.RowIndex].DataBoundItem as IntervencijaView).Id;
            intervencija = DTOManager.getIntervencijaView(id);
            PopuniZaIntervenciju();
        }

        private void PopuniZaIntervenciju()
        {
            dtpIntervencija.Value = intervencija.Datum;
            txtVreme.Text = intervencija.Vreme.ToShortTimeString();
            txtOpisTipa.Text = intervencija.OpisTipa;
            comboEkipaIntervencija.SelectedItem = (comboEkipaIntervencija.DataSource as List<EkipaView>).Find(x => x.Id == intervencija.Ekipica.Id);
            comboObjekatIntervencija.SelectedItem = (comboObjekatIntervencija.DataSource as List<ObjekatView>).Find(x => x.Id == intervencija.Objektic.Id);
        }

        #endregion

        #region Ekipa
        private void btnGotovoKreiranje_Click(object sender, EventArgs e)
        {
            if (this.kreirajEkipu == false)
            {
                this.txtVodja.Text = "";
                this.txtClan1.Text = "";
                this.metroTextBox1.Text = "";
                this.metroTextBox2.Text = "";
            }
        }

        private void btnDodajEkipu_Click_1(object sender, EventArgs e)
        {
            if (this.kreirajEkipu == false && dgvNerasporedjeni.SelectedRows.Count == 1)
            {
                this.lblPrikaz.Text = "Kreirana ekipa, selektujte clanove";
                this.kreirajEkipu = true;
                Ekipa ekipa = new Ekipa();
                //////////////////////////////////////
                ekipa.Vodja = DTOManager.getFizickoObezbedjenje(((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Id);
                /////////////////////////////////////////////////

                DTOManager.addEkipa(ekipa);
                DTOManager.addClanaEkipe(ekipa.Id, ekipa.Vodja.Id);

                this.idEk = ekipa.Id;

                this.txtVodja.Text = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Ime + " " + ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Prezime;
                Prikazi();
            }
            else
                return;
        }

        private void btnDodajClanove_Click(object sender, EventArgs e)
        {
            if (this.kreirajEkipu = true && dgvNerasporedjeni.SelectedRows.Count > 0 && dgvNerasporedjeni.SelectedRows.Count < 4)
            {
                this.lblPrikaz.Text = "KREIRANA EKIPA U SLEDECEM SASTAVU:";
                int brojClana = dgvNerasporedjeni.SelectedRows.Count;
                if (brojClana == 1)
                {
                    int id = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Id;//(row.DataBoundItem as BasicZaposleniView).Id;
                    DTOManager.addClanaEkipe(idEk, id);
                    this.txtClan1.Text = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Ime + "" + ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Prezime;
                    this.kreirajEkipu = false;
                }
                else if (brojClana == 2)
                {
                    int id = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Id;//(row.DataBoundItem as BasicZaposleniView).Id;
                    DTOManager.addClanaEkipe(idEk, id);
                    this.txtClan1.Text = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Ime + "" + ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Prezime;

                    int id2 = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[1].DataBoundItem).Id;//(row.DataBoundItem as BasicZaposleniView).Id;
                    DTOManager.addClanaEkipe(idEk, id2);
                    this.metroTextBox1.Text = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[1].DataBoundItem).Ime + "" + ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[1].DataBoundItem).Prezime;
                    this.kreirajEkipu = false;
                }
                else if (brojClana == 3)
                {
                    int id = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Id;//(row.DataBoundItem as BasicZaposleniView).Id;
                    DTOManager.addClanaEkipe(idEk, id);
                    this.txtClan1.Text = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Ime + "" + ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[0].DataBoundItem).Prezime;

                    int id2 = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[1].DataBoundItem).Id;//(row.DataBoundItem as BasicZaposleniView).Id;
                    DTOManager.addClanaEkipe(idEk, id2);
                    this.metroTextBox1.Text = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[1].DataBoundItem).Ime + "" + ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[1].DataBoundItem).Prezime;

                    int id3 = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[2].DataBoundItem).Id;//(row.DataBoundItem as BasicZaposleniView).Id;
                    DTOManager.addClanaEkipe(idEk, id3);
                    this.metroTextBox2.Text = ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[2].DataBoundItem).Ime + "" + ((BasicZaposleniView)dgvNerasporedjeni.SelectedRows[2].DataBoundItem).Prezime;
                    this.kreirajEkipu = false;
                }
                Prikazi();
            }
        }

        #endregion

        private void btnOdustaniIzmena_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.Cancel;
        }

        #region Zaduzenja

        private void PopuniGridove()
        {
            EkipaView ekipa = comboEkipa.SelectedItem as EkipaView;
            if (ekipa!=null)
            {
                dgvSmeneEkipa.DataSource = DTOManager.getSmeneEkipa(ekipa.Id);
                dgvObjekti.DataSource = DTOManager.getObjekteZaEkipu(ekipa.Id);
                dgvObjekti.Columns[4].Visible = false;
                dgvVozila.DataSource = DTOManager.getVozilaEkipe(ekipa.Id);
            }
        }

        private void comboEkipa_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopuniGridove();
        }


        private void btnDodajObjekat_Click(object sender, EventArgs e)
        {
            EkipaView ekipa = comboEkipa.SelectedItem as EkipaView;
            ObjekatView objekat = comboObjekti.SelectedItem as ObjekatView;
            if (objekat == null || ekipa == null)
                return;
            DTOManager.addObjekatEkipi(objekat.Id, ekipa.Id);
            PopuniGridove();
        }

        

        private void btnDodajSmenu_Click(object sender, EventArgs e)
        {
            EkipaView ekipa = comboEkipa.SelectedItem as EkipaView;
            SmenaView smena = comboSmene.SelectedItem as SmenaView;

            if (ekipa == null || smena == null)
                return;
            DTOManager.addSmenaEkipi(smena.Id, ekipa.Id);
            PopuniGridove();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            EkipaView ekipa = comboEkipa.SelectedItem as EkipaView;
            VoziloView vozilo = comboVozila.SelectedItem as VoziloView;

            if (ekipa == null || vozilo == null)
                return;
            if (dtpVoziloDo.Value < dtpVoziloOd.Value)
                return;
            Duzi d = new Duzi();
            d.Do = dtpVoziloDo.Value;
            d.Od = dtpVoziloOd.Value;
            d.UzelaEkipa = DTOManager.getEkipa(ekipa.Id);
            d.UzetoVozilo = DTOManager.getVozilo(vozilo.Id);

            DTOManager.addDuzi(d);
            PopuniGridove();
            
        }

        #endregion
    }
}
