namespace SBP_Projekat.Forme
{
    partial class GlavnaForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabovi = new MetroFramework.Controls.MetroTabControl();
            this.tabZaposleniii = new MetroFramework.Controls.MetroTabPage();
            this.btnEkipe = new MetroFramework.Controls.MetroButton();
            this.btnObrisiOznacenog = new MetroFramework.Controls.MetroButton();
            this.btnDodajRadnika = new MetroFramework.Controls.MetroButton();
            this.radioTehnicka = new MetroFramework.Controls.MetroRadioButton();
            this.radioFizicko = new MetroFramework.Controls.MetroRadioButton();
            this.radioMenadzer = new MetroFramework.Controls.MetroRadioButton();
            this.lblVidi = new MetroFramework.Controls.MetroLabel();
            this.dgvZaposleni = new MetroFramework.Controls.MetroGrid();
            this.tabRegCentriii = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnPoveziSaMenadzerom = new MetroFramework.Controls.MetroButton();
            this.btnObrisi = new MetroFramework.Controls.MetroButton();
            this.btnDodajCentar = new MetroFramework.Controls.MetroButton();
            this.dgvRegCentri = new MetroFramework.Controls.MetroGrid();
            this.tabObjektiii = new MetroFramework.Controls.MetroTabPage();
            this.btnObrisiO = new MetroFramework.Controls.MetroButton();
            this.btnDodajObjekat = new MetroFramework.Controls.MetroButton();
            this.dgvObjekti = new MetroFramework.Controls.MetroGrid();
            this.tabovi.SuspendLayout();
            this.tabZaposleniii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).BeginInit();
            this.tabRegCentriii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegCentri)).BeginInit();
            this.tabObjektiii.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).BeginInit();
            this.SuspendLayout();
            // 
            // tabovi
            // 
            this.tabovi.Controls.Add(this.tabZaposleniii);
            this.tabovi.Controls.Add(this.tabRegCentriii);
            this.tabovi.Controls.Add(this.tabObjektiii);
            this.tabovi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabovi.ItemSize = new System.Drawing.Size(68, 34);
            this.tabovi.Location = new System.Drawing.Point(27, 74);
            this.tabovi.Margin = new System.Windows.Forms.Padding(4);
            this.tabovi.Multiline = true;
            this.tabovi.Name = "tabovi";
            this.tabovi.SelectedIndex = 2;
            this.tabovi.Size = new System.Drawing.Size(1013, 455);
            this.tabovi.TabIndex = 0;
            this.tabovi.UseSelectable = true;
            this.tabovi.SelectedIndexChanged += new System.EventHandler(this.tabovi_SelectedIndexChanged);
            // 
            // tabZaposleniii
            // 
            this.tabZaposleniii.Controls.Add(this.btnEkipe);
            this.tabZaposleniii.Controls.Add(this.btnObrisiOznacenog);
            this.tabZaposleniii.Controls.Add(this.btnDodajRadnika);
            this.tabZaposleniii.Controls.Add(this.radioTehnicka);
            this.tabZaposleniii.Controls.Add(this.radioFizicko);
            this.tabZaposleniii.Controls.Add(this.radioMenadzer);
            this.tabZaposleniii.Controls.Add(this.lblVidi);
            this.tabZaposleniii.Controls.Add(this.dgvZaposleni);
            this.tabZaposleniii.HorizontalScrollbarBarColor = true;
            this.tabZaposleniii.HorizontalScrollbarHighlightOnWheel = false;
            this.tabZaposleniii.HorizontalScrollbarSize = 12;
            this.tabZaposleniii.Location = new System.Drawing.Point(4, 38);
            this.tabZaposleniii.Margin = new System.Windows.Forms.Padding(4);
            this.tabZaposleniii.Name = "tabZaposleniii";
            this.tabZaposleniii.Size = new System.Drawing.Size(1005, 413);
            this.tabZaposleniii.TabIndex = 4;
            this.tabZaposleniii.Text = "Zaposleni";
            this.tabZaposleniii.VerticalScrollbarBarColor = true;
            this.tabZaposleniii.VerticalScrollbarHighlightOnWheel = false;
            this.tabZaposleniii.VerticalScrollbarSize = 13;
            // 
            // btnEkipe
            // 
            this.btnEkipe.Location = new System.Drawing.Point(301, 380);
            this.btnEkipe.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkipe.Name = "btnEkipe";
            this.btnEkipe.Size = new System.Drawing.Size(148, 28);
            this.btnEkipe.TabIndex = 3;
            this.btnEkipe.Text = "Ekipe";
            this.btnEkipe.UseSelectable = true;
            this.btnEkipe.Click += new System.EventHandler(this.btnEkipe_Click);
            // 
            // btnObrisiOznacenog
            // 
            this.btnObrisiOznacenog.Location = new System.Drawing.Point(851, 380);
            this.btnObrisiOznacenog.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiOznacenog.Name = "btnObrisiOznacenog";
            this.btnObrisiOznacenog.Size = new System.Drawing.Size(148, 28);
            this.btnObrisiOznacenog.TabIndex = 5;
            this.btnObrisiOznacenog.Text = "Obriši označenog";
            this.btnObrisiOznacenog.UseSelectable = true;
            this.btnObrisiOznacenog.Click += new System.EventHandler(this.btnObrisiOznacenog_Click);
            // 
            // btnDodajRadnika
            // 
            this.btnDodajRadnika.Location = new System.Drawing.Point(513, 380);
            this.btnDodajRadnika.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajRadnika.Name = "btnDodajRadnika";
            this.btnDodajRadnika.Size = new System.Drawing.Size(271, 28);
            this.btnDodajRadnika.TabIndex = 4;
            this.btnDodajRadnika.Text = "Dodaj radnika";
            this.btnDodajRadnika.UseSelectable = true;
            this.btnDodajRadnika.Click += new System.EventHandler(this.btnDodajRadnika_Click);
            // 
            // radioTehnicka
            // 
            this.radioTehnicka.AutoSize = true;
            this.radioTehnicka.Location = new System.Drawing.Point(616, 10);
            this.radioTehnicka.Margin = new System.Windows.Forms.Padding(4);
            this.radioTehnicka.Name = "radioTehnicka";
            this.radioTehnicka.Size = new System.Drawing.Size(96, 17);
            this.radioTehnicka.TabIndex = 2;
            this.radioTehnicka.Text = "Tehnička lica";
            this.radioTehnicka.UseSelectable = true;
            this.radioTehnicka.CheckedChanged += new System.EventHandler(this.Radio_Changed);
            // 
            // radioFizicko
            // 
            this.radioFizicko.AutoSize = true;
            this.radioFizicko.Location = new System.Drawing.Point(379, 10);
            this.radioFizicko.Margin = new System.Windows.Forms.Padding(4);
            this.radioFizicko.Name = "radioFizicko";
            this.radioFizicko.Size = new System.Drawing.Size(142, 17);
            this.radioFizicko.TabIndex = 1;
            this.radioFizicko.Text = "Fizičko obezbeđenje";
            this.radioFizicko.UseSelectable = true;
            this.radioFizicko.CheckedChanged += new System.EventHandler(this.Radio_Changed);
            // 
            // radioMenadzer
            // 
            this.radioMenadzer.AutoSize = true;
            this.radioMenadzer.Location = new System.Drawing.Point(151, 10);
            this.radioMenadzer.Margin = new System.Windows.Forms.Padding(4);
            this.radioMenadzer.Name = "radioMenadzer";
            this.radioMenadzer.Size = new System.Drawing.Size(90, 17);
            this.radioMenadzer.TabIndex = 0;
            this.radioMenadzer.Text = "Menadžere";
            this.radioMenadzer.UseSelectable = true;
            this.radioMenadzer.CheckedChanged += new System.EventHandler(this.Radio_Changed);
            // 
            // lblVidi
            // 
            this.lblVidi.AutoSize = true;
            this.lblVidi.Location = new System.Drawing.Point(39, 5);
            this.lblVidi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVidi.Name = "lblVidi";
            this.lblVidi.Size = new System.Drawing.Size(35, 20);
            this.lblVidi.TabIndex = 8;
            this.lblVidi.Text = "Vidi:";
            // 
            // dgvZaposleni
            // 
            this.dgvZaposleni.AllowUserToResizeRows = false;
            this.dgvZaposleni.BackgroundColor = System.Drawing.Color.White;
            this.dgvZaposleni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvZaposleni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvZaposleni.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposleni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZaposleni.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZaposleni.EnableHeadersVisualStyles = false;
            this.dgvZaposleni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvZaposleni.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvZaposleni.Location = new System.Drawing.Point(-1, 49);
            this.dgvZaposleni.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZaposleni.Name = "dgvZaposleni";
            this.dgvZaposleni.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZaposleni.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvZaposleni.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvZaposleni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposleni.Size = new System.Drawing.Size(1004, 315);
            this.dgvZaposleni.TabIndex = 7;
            this.dgvZaposleni.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZaposleni_CellContentDoubleClick);
            // 
            // tabRegCentriii
            // 
            this.tabRegCentriii.Controls.Add(this.metroLabel1);
            this.tabRegCentriii.Controls.Add(this.btnPoveziSaMenadzerom);
            this.tabRegCentriii.Controls.Add(this.btnObrisi);
            this.tabRegCentriii.Controls.Add(this.btnDodajCentar);
            this.tabRegCentriii.Controls.Add(this.dgvRegCentri);
            this.tabRegCentriii.HorizontalScrollbarBarColor = true;
            this.tabRegCentriii.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRegCentriii.HorizontalScrollbarSize = 12;
            this.tabRegCentriii.Location = new System.Drawing.Point(4, 38);
            this.tabRegCentriii.Margin = new System.Windows.Forms.Padding(4);
            this.tabRegCentriii.Name = "tabRegCentriii";
            this.tabRegCentriii.Size = new System.Drawing.Size(1005, 413);
            this.tabRegCentriii.TabIndex = 5;
            this.tabRegCentriii.Text = "Regionalni Centri";
            this.tabRegCentriii.VerticalScrollbarBarColor = true;
            this.tabRegCentriii.VerticalScrollbarHighlightOnWheel = false;
            this.tabRegCentriii.VerticalScrollbarSize = 13;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(520, 41);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(372, 20);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Selektujte Reg. centar kome zelite da dodelite rukovodioca";
            // 
            // btnPoveziSaMenadzerom
            // 
            this.btnPoveziSaMenadzerom.Location = new System.Drawing.Point(688, 71);
            this.btnPoveziSaMenadzerom.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoveziSaMenadzerom.Name = "btnPoveziSaMenadzerom";
            this.btnPoveziSaMenadzerom.Size = new System.Drawing.Size(155, 28);
            this.btnPoveziSaMenadzerom.TabIndex = 0;
            this.btnPoveziSaMenadzerom.Text = "Dodela\r\n";
            this.btnPoveziSaMenadzerom.UseSelectable = true;
            this.btnPoveziSaMenadzerom.Click += new System.EventHandler(this.btnPoveziSaMenadzerom_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(777, 223);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(149, 28);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši označenog";
            this.btnObrisi.UseSelectable = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodajCentar
            // 
            this.btnDodajCentar.Location = new System.Drawing.Point(609, 223);
            this.btnDodajCentar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajCentar.Name = "btnDodajCentar";
            this.btnDodajCentar.Size = new System.Drawing.Size(147, 28);
            this.btnDodajCentar.TabIndex = 1;
            this.btnDodajCentar.Text = "Dodaj CENTAR";
            this.btnDodajCentar.UseSelectable = true;
            this.btnDodajCentar.Click += new System.EventHandler(this.btnDodajCentar_Click);
            // 
            // dgvRegCentri
            // 
            this.dgvRegCentri.AllowUserToResizeRows = false;
            this.dgvRegCentri.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegCentri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegCentri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRegCentri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegCentri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegCentri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegCentri.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRegCentri.EnableHeadersVisualStyles = false;
            this.dgvRegCentri.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRegCentri.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRegCentri.Location = new System.Drawing.Point(4, 27);
            this.dgvRegCentri.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRegCentri.Name = "dgvRegCentri";
            this.dgvRegCentri.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegCentri.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRegCentri.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRegCentri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegCentri.Size = new System.Drawing.Size(479, 302);
            this.dgvRegCentri.TabIndex = 3;
            this.dgvRegCentri.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegCentri_CellContentDoubleClick);
            // 
            // tabObjektiii
            // 
            this.tabObjektiii.Controls.Add(this.btnObrisiO);
            this.tabObjektiii.Controls.Add(this.btnDodajObjekat);
            this.tabObjektiii.Controls.Add(this.dgvObjekti);
            this.tabObjektiii.HorizontalScrollbarBarColor = true;
            this.tabObjektiii.HorizontalScrollbarHighlightOnWheel = false;
            this.tabObjektiii.HorizontalScrollbarSize = 12;
            this.tabObjektiii.Location = new System.Drawing.Point(4, 38);
            this.tabObjektiii.Margin = new System.Windows.Forms.Padding(4);
            this.tabObjektiii.Name = "tabObjektiii";
            this.tabObjektiii.Size = new System.Drawing.Size(1005, 413);
            this.tabObjektiii.TabIndex = 6;
            this.tabObjektiii.Text = "Objekti";
            this.tabObjektiii.VerticalScrollbarBarColor = true;
            this.tabObjektiii.VerticalScrollbarHighlightOnWheel = false;
            this.tabObjektiii.VerticalScrollbarSize = 13;
            // 
            // btnObrisiO
            // 
            this.btnObrisiO.Location = new System.Drawing.Point(471, 258);
            this.btnObrisiO.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiO.Name = "btnObrisiO";
            this.btnObrisiO.Size = new System.Drawing.Size(204, 28);
            this.btnObrisiO.TabIndex = 2;
            this.btnObrisiO.Text = "Obrisi oznacenog";
            this.btnObrisiO.UseSelectable = true;
            this.btnObrisiO.Click += new System.EventHandler(this.btnObrisiO_Click);
            // 
            // btnDodajObjekat
            // 
            this.btnDodajObjekat.Location = new System.Drawing.Point(91, 260);
            this.btnDodajObjekat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajObjekat.Name = "btnDodajObjekat";
            this.btnDodajObjekat.Size = new System.Drawing.Size(225, 28);
            this.btnDodajObjekat.TabIndex = 1;
            this.btnDodajObjekat.Text = "Dodaj OBJEKAT";
            this.btnDodajObjekat.UseSelectable = true;
            this.btnDodajObjekat.Click += new System.EventHandler(this.btnDodajObjekat_Click);
            // 
            // dgvObjekti
            // 
            this.dgvObjekti.AllowUserToResizeRows = false;
            this.dgvObjekti.BackgroundColor = System.Drawing.Color.White;
            this.dgvObjekti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvObjekti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvObjekti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjekti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvObjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjekti.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvObjekti.EnableHeadersVisualStyles = false;
            this.dgvObjekti.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvObjekti.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvObjekti.Location = new System.Drawing.Point(17, 30);
            this.dgvObjekti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvObjekti.Name = "dgvObjekti";
            this.dgvObjekti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjekti.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvObjekti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvObjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjekti.Size = new System.Drawing.Size(657, 185);
            this.dgvObjekti.TabIndex = 0;
            this.dgvObjekti.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjekti_CellContentDoubleClick);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabovi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GlavnaForma";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "SECURITY";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.tabovi.ResumeLayout(false);
            this.tabZaposleniii.ResumeLayout(false);
            this.tabZaposleniii.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposleni)).EndInit();
            this.tabRegCentriii.ResumeLayout(false);
            this.tabRegCentriii.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegCentri)).EndInit();
            this.tabObjektiii.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabovi;
        private MetroFramework.Controls.MetroTabPage tabZaposleniii;
        private MetroFramework.Controls.MetroTabPage tabRegCentriii;
        private MetroFramework.Controls.MetroTabPage tabObjektiii;
        private MetroFramework.Controls.MetroButton btnObrisiOznacenog;
        private MetroFramework.Controls.MetroButton btnDodajRadnika;
        private MetroFramework.Controls.MetroGrid dgvZaposleni;
        private MetroFramework.Controls.MetroRadioButton radioTehnicka;
        private MetroFramework.Controls.MetroRadioButton radioFizicko;
        private MetroFramework.Controls.MetroRadioButton radioMenadzer;
        private MetroFramework.Controls.MetroLabel lblVidi;
        private MetroFramework.Controls.MetroGrid dgvRegCentri;
        private MetroFramework.Controls.MetroButton btnObrisi;
        private MetroFramework.Controls.MetroButton btnDodajCentar;
        private MetroFramework.Controls.MetroButton btnDodajObjekat;
        private MetroFramework.Controls.MetroGrid dgvObjekti;
        private MetroFramework.Controls.MetroButton btnObrisiO;
        private MetroFramework.Controls.MetroButton btnEkipe;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnPoveziSaMenadzerom;
    }
}