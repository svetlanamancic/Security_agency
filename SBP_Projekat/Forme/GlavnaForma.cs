using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using SBP_Projekat.DTOs;

namespace SBP_Projekat.Forme
{
    public partial class GlavnaForma : MetroForm
    {

        #region Kontruktori

        public GlavnaForma()
        {
            InitializeComponent();
            this.radioMenadzer.Checked = true;
        }

        #endregion

        #region Funkcije
        public void Prikazi()
        {
            if (this.tabovi.SelectedTab == tabObjektiii)
            {
                dgvObjekti.DataSource = DTOManager.getObjekte();
                dgvObjekti.Columns[4].Visible = false;
            }
            else if (this.tabovi.SelectedTab == tabZaposleniii)
            {
                if (this.radioMenadzer.Checked == true)
                {
                    dgvZaposleni.DataSource = DTOManager.getMenadzere();
                }
                else if (this.radioFizicko.Checked == true)
                {
                    dgvZaposleni.DataSource = DTOManager.getFizickoObezbedjenje();
                }
                else if (this.radioTehnicka.Checked == true)
                {
                    dgvZaposleni.DataSource = DTOManager.getTehnicari();
                }
            }
            else if (this.tabovi.SelectedTab == tabRegCentriii)
            {               
                dgvRegCentri.DataSource = DTOManager.getCentre();
                dgvRegCentri.Columns[2].Visible = false;
                dgvRegCentri.Columns[3].Visible = false;
            }
        }

        #endregion

        #region Dogadjaji

        private void GlavnaForma_Load(object sender, EventArgs e)
        {        
            this.Prikazi();
            tabovi.SelectedTab = tabZaposleniii;          
        }

        private void Radio_Changed(object sender, EventArgs e)
        {
            this.Prikazi();
            if (radioFizicko.Checked == true)
            {
                btnDodajRadnika.Text = "Dodaj fizičko obezbeđenje";
                
                btnEkipe.Visible = true;
            }
            else if (radioTehnicka.Checked)
            {
                btnDodajRadnika.Text = "Dodaj tehničko lice";
               
                btnEkipe.Visible = false;
            }
            else
            {
                btnDodajRadnika.Text = "Dodaj menadžera";
               
                btnEkipe.Visible = false;
            }
        }

        #region ButtonClick

        private void btnDodajRadnika_Click(object sender, EventArgs e)
        {

            if(radioMenadzer.Checked)
            {
                var Forma = new DodajMenadzera();
                Forma.ShowDialog();
            }
            else if (radioFizicko.Checked)
            {
                var Forma = new DodajFizickoObez();
                Forma.ShowDialog();
            }

            else if(radioTehnicka.Checked)
            {
                var Forma = new DodajTehnickoLice();
                Forma.ShowDialog();
            }
            Prikazi();
        }

        private void btnDodajCentar_Click(object sender, EventArgs e)
        {
            var Forma = new DodajRegionalniCentar();
            Forma.ShowDialog();
            Prikazi();
        }

        private void btnDodajObjekat_Click(object sender, EventArgs e)
        {
            var Form = new DodajObjekat();
            Form.ShowDialog();          
        }

        private void btnEkipe_Click(object sender, EventArgs e)
        {
            var Forme = new VidiEkipu();
            Forme.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvRegCentri.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvRegCentri.SelectedRows)
            {
                int id = ((RegionalniCentarView)dgvRegCentri.SelectedRows[0].DataBoundItem).Id;
                if (id < 1)
                {
                    return;
                }
                DTOManager.deleteRegionalniCentar(id);
            }
            Prikazi();


        }

        private void btnObrisiO_Click(object sender, EventArgs e)
        {
            if (dgvObjekti.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvObjekti.SelectedRows)
            {
                int id = ((ObjekatView)dgvObjekti.SelectedRows[0].DataBoundItem).Id;
                if (id < 1)
                {
                    return;
                }
                DTOManager.deleteObjekat(id);
            }
            Prikazi();

        }

        private void btnPoveziSaMenadzerom_Click(object sender, EventArgs e)
        {
            if (dgvRegCentri.SelectedRows.Count != 1)
                return;
            else if (dgvRegCentri.SelectedRows.Count == 1)
            {
                RegionalniCentarView reg = ((RegionalniCentarView)dgvRegCentri.SelectedRows[0].DataBoundItem);
                var Forma = new PovezivanjeRegCenSaMenadzerom(reg);
                Forma.ShowDialog();
            }
        }

        private void btnObrisiOznacenog_Click(object sender, EventArgs e)
        {
            if (dgvZaposleni.SelectedRows.Count == 0)
            {
                return;
            }
            if (radioMenadzer.Checked)
            {
                foreach (DataGridViewRow row in dgvZaposleni.SelectedRows)
                {
                    int id = ((ZaposleniView)dgvZaposleni.SelectedRows[0].DataBoundItem).Id;
                    if (id < 1)
                    {
                        return;
                    }
                    DTOManager.deleteMenadzer(id);
                }

            }
            else if (radioFizicko.Checked)
            {
                foreach (DataGridViewRow row in dgvZaposleni.SelectedRows)
                {
                    int id = ((ZaposleniView)dgvZaposleni.SelectedRows[0].DataBoundItem).Id;
                    if (id < 1)
                    {
                        return;
                    }
                    DTOManager.deleteFizickoObezbedjenje(id);
                }
            }

            else if (radioTehnicka.Checked)
            {
                foreach (DataGridViewRow row in dgvZaposleni.SelectedRows)
                {
                    int id = ((ZaposleniView)dgvZaposleni.SelectedRows[0].DataBoundItem).Id;
                    if (id < 1)
                    {
                        return;
                    }
                    DTOManager.deleteTehnickoLice(id);
                }
            }
            Prikazi();
        }

        #endregion

        private void dgvZaposleni_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioMenadzer.Checked)
            {
                
                var Forma = new DodajMenadzera(((ZaposleniView)dgvZaposleni.Rows[e.RowIndex].DataBoundItem).Id);
                DialogResult dr = Forma.ShowDialog();
                if (dr == DialogResult.OK)
                    Prikazi();
            }
            else if (this.radioFizicko.Checked == true)
            {
                var Forma = new DodajFizickoObez(((ZaposleniView)dgvZaposleni.Rows[e.RowIndex].DataBoundItem).Id);
                DialogResult dr = Forma.ShowDialog();
                if (dr == DialogResult.OK)
                    Prikazi();
            }
            else if (this.radioTehnicka.Checked == true)
            {
                var Forma = new DodajTehnickoLice(((ZaposleniView)dgvZaposleni.Rows[e.RowIndex].DataBoundItem).Id);
                DialogResult dr = Forma.ShowDialog();
                if (dr == DialogResult.OK)
                    Prikazi();
            }
        }

        

        private void tabovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Prikazi();
        }

       

        private void dgvRegCentri_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Forma = new DodajRegionalniCentar(((RegionalniCentarView)dgvRegCentri.Rows[e.RowIndex].DataBoundItem).Id);
            DialogResult dr = Forma.ShowDialog();
            if (dr == DialogResult.OK)
                Prikazi();
        }

        private void dgvObjekti_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Forma = new DodajObjekat(((ObjekatView)dgvObjekti.Rows[e.RowIndex].DataBoundItem).Id);
            DialogResult dr = Forma.ShowDialog();
            if (dr == DialogResult.OK)
                Prikazi();
        }
        #endregion

        
    }
}
