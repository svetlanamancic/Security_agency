namespace SBP_Projekat.Forme
{
    partial class DodajTehnickoLice
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
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dtpRodjenja = new MetroFramework.Controls.MetroDateTime();
            this.radioM = new MetroFramework.Controls.MetroRadioButton();
            this.txtJMBG = new MetroFramework.Controls.MetroTextBox();
            this.radioZ = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPrezime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIme = new MetroFramework.Controls.MetroTextBox();
            this.lbloblasttehnike = new MetroFramework.Controls.MetroLabel();
            this.lblstrucnasprema = new MetroFramework.Controls.MetroLabel();
            this.btnSacuvajOblastTehnike = new MetroFramework.Controls.MetroButton();
            this.txtOblastTehnike = new MetroFramework.Controls.MetroTextBox();
            this.btnSacuvajStrucnuSpremu = new MetroFramework.Controls.MetroButton();
            this.txtStrucnaSprema = new MetroFramework.Controls.MetroTextBox();
            this.dgvOblasti = new MetroFramework.Controls.MetroGrid();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.dgvStruke = new MetroFramework.Controls.MetroGrid();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOblasti)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStruke)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(765, 645);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 62);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Sačuvaj";
            this.btnOK.UseSelectable = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(656, 645);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 62);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.dtpRodjenja);
            this.metroPanel1.Controls.Add(this.radioM);
            this.metroPanel1.Controls.Add(this.txtJMBG);
            this.metroPanel1.Controls.Add(this.radioZ);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtPrezime);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtIme);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(20, 82);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(848, 329);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // dtpRodjenja
            // 
            this.dtpRodjenja.CustomFormat = "dd.MM.yyyy.";
            this.dtpRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRodjenja.Location = new System.Drawing.Point(400, 224);
            this.dtpRodjenja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRodjenja.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpRodjenja.Name = "dtpRodjenja";
            this.dtpRodjenja.Size = new System.Drawing.Size(208, 30);
            this.dtpRodjenja.TabIndex = 5;
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(484, 183);
            this.radioM.Margin = new System.Windows.Forms.Padding(4);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(36, 17);
            this.radioM.TabIndex = 4;
            this.radioM.Text = "M";
            this.radioM.UseSelectable = true;
            // 
            // txtJMBG
            // 
            // 
            // 
            // 
            this.txtJMBG.CustomButton.Image = null;
            this.txtJMBG.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.txtJMBG.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtJMBG.CustomButton.Name = "";
            this.txtJMBG.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtJMBG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtJMBG.CustomButton.TabIndex = 1;
            this.txtJMBG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtJMBG.CustomButton.UseSelectable = true;
            this.txtJMBG.CustomButton.Visible = false;
            this.txtJMBG.Lines = new string[0];
            this.txtJMBG.Location = new System.Drawing.Point(400, 52);
            this.txtJMBG.Margin = new System.Windows.Forms.Padding(4);
            this.txtJMBG.MaxLength = 32767;
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.PasswordChar = '\0';
            this.txtJMBG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJMBG.SelectedText = "";
            this.txtJMBG.SelectionLength = 0;
            this.txtJMBG.SelectionStart = 0;
            this.txtJMBG.ShortcutsEnabled = true;
            this.txtJMBG.Size = new System.Drawing.Size(209, 28);
            this.txtJMBG.TabIndex = 0;
            this.txtJMBG.UseSelectable = true;
            this.txtJMBG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtJMBG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
            // 
            // radioZ
            // 
            this.radioZ.AutoSize = true;
            this.radioZ.Location = new System.Drawing.Point(400, 183);
            this.radioZ.Margin = new System.Windows.Forms.Padding(4);
            this.radioZ.Name = "radioZ";
            this.radioZ.Size = new System.Drawing.Size(31, 17);
            this.radioZ.TabIndex = 3;
            this.radioZ.Text = "Ž";
            this.radioZ.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(227, 98);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 20);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Ime:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(227, 224);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(104, 20);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Datum rođenja:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(227, 138);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 20);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Prezime: ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(227, 178);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(30, 20);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Pol:";
            // 
            // txtPrezime
            // 
            // 
            // 
            // 
            this.txtPrezime.CustomButton.Image = null;
            this.txtPrezime.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.txtPrezime.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.CustomButton.Name = "";
            this.txtPrezime.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPrezime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrezime.CustomButton.TabIndex = 1;
            this.txtPrezime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrezime.CustomButton.UseSelectable = true;
            this.txtPrezime.CustomButton.Visible = false;
            this.txtPrezime.Lines = new string[0];
            this.txtPrezime.Location = new System.Drawing.Point(400, 135);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.MaxLength = 32767;
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.PasswordChar = '\0';
            this.txtPrezime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrezime.SelectedText = "";
            this.txtPrezime.SelectionLength = 0;
            this.txtPrezime.SelectionStart = 0;
            this.txtPrezime.ShortcutsEnabled = true;
            this.txtPrezime.Size = new System.Drawing.Size(209, 28);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.UseSelectable = true;
            this.txtPrezime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrezime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrezime_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(227, 52);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "JMBG:";
            // 
            // txtIme
            // 
            // 
            // 
            // 
            this.txtIme.CustomButton.Image = null;
            this.txtIme.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.txtIme.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.CustomButton.Name = "";
            this.txtIme.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtIme.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIme.CustomButton.TabIndex = 1;
            this.txtIme.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIme.CustomButton.UseSelectable = true;
            this.txtIme.CustomButton.Visible = false;
            this.txtIme.Lines = new string[0];
            this.txtIme.Location = new System.Drawing.Point(400, 98);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.MaxLength = 32767;
            this.txtIme.Name = "txtIme";
            this.txtIme.PasswordChar = '\0';
            this.txtIme.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIme.SelectedText = "";
            this.txtIme.SelectionLength = 0;
            this.txtIme.SelectionStart = 0;
            this.txtIme.ShortcutsEnabled = true;
            this.txtIme.Size = new System.Drawing.Size(209, 28);
            this.txtIme.TabIndex = 1;
            this.txtIme.UseSelectable = true;
            this.txtIme.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIme.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIme_KeyPress);
            // 
            // lbloblasttehnike
            // 
            this.lbloblasttehnike.AutoSize = true;
            this.lbloblasttehnike.Location = new System.Drawing.Point(4, 12);
            this.lbloblasttehnike.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloblasttehnike.Name = "lbloblasttehnike";
            this.lbloblasttehnike.Size = new System.Drawing.Size(101, 20);
            this.lbloblasttehnike.TabIndex = 0;
            this.lbloblasttehnike.Text = "Oblast tehnike:";
            // 
            // lblstrucnasprema
            // 
            this.lblstrucnasprema.AutoSize = true;
            this.lblstrucnasprema.Location = new System.Drawing.Point(0, 18);
            this.lblstrucnasprema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstrucnasprema.Name = "lblstrucnasprema";
            this.lblstrucnasprema.Size = new System.Drawing.Size(108, 20);
            this.lblstrucnasprema.TabIndex = 0;
            this.lblstrucnasprema.Text = "Stručna sprema:";
            // 
            // btnSacuvajOblastTehnike
            // 
            this.btnSacuvajOblastTehnike.Location = new System.Drawing.Point(208, 179);
            this.btnSacuvajOblastTehnike.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvajOblastTehnike.Name = "btnSacuvajOblastTehnike";
            this.btnSacuvajOblastTehnike.Size = new System.Drawing.Size(191, 28);
            this.btnSacuvajOblastTehnike.TabIndex = 2;
            this.btnSacuvajOblastTehnike.Text = "DodajOblastTehnike";
            this.btnSacuvajOblastTehnike.UseSelectable = true;
            this.btnSacuvajOblastTehnike.Click += new System.EventHandler(this.btnSacuvajOblastTehnike_Click);
            // 
            // txtOblastTehnike
            // 
            // 
            // 
            // 
            this.txtOblastTehnike.CustomButton.Image = null;
            this.txtOblastTehnike.CustomButton.Location = new System.Drawing.Point(165, 2);
            this.txtOblastTehnike.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtOblastTehnike.CustomButton.Name = "";
            this.txtOblastTehnike.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtOblastTehnike.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOblastTehnike.CustomButton.TabIndex = 1;
            this.txtOblastTehnike.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOblastTehnike.CustomButton.UseSelectable = true;
            this.txtOblastTehnike.CustomButton.Visible = false;
            this.txtOblastTehnike.Lines = new string[0];
            this.txtOblastTehnike.Location = new System.Drawing.Point(143, 12);
            this.txtOblastTehnike.Margin = new System.Windows.Forms.Padding(4);
            this.txtOblastTehnike.MaxLength = 32767;
            this.txtOblastTehnike.Name = "txtOblastTehnike";
            this.txtOblastTehnike.PasswordChar = '\0';
            this.txtOblastTehnike.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOblastTehnike.SelectedText = "";
            this.txtOblastTehnike.SelectionLength = 0;
            this.txtOblastTehnike.SelectionStart = 0;
            this.txtOblastTehnike.ShortcutsEnabled = true;
            this.txtOblastTehnike.Size = new System.Drawing.Size(191, 28);
            this.txtOblastTehnike.TabIndex = 0;
            this.txtOblastTehnike.UseSelectable = true;
            this.txtOblastTehnike.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOblastTehnike.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOblastTehnike.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOblastTehnike_KeyPress);
            // 
            // btnSacuvajStrucnuSpremu
            // 
            this.btnSacuvajStrucnuSpremu.Location = new System.Drawing.Point(194, 181);
            this.btnSacuvajStrucnuSpremu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvajStrucnuSpremu.Name = "btnSacuvajStrucnuSpremu";
            this.btnSacuvajStrucnuSpremu.Size = new System.Drawing.Size(191, 28);
            this.btnSacuvajStrucnuSpremu.TabIndex = 2;
            this.btnSacuvajStrucnuSpremu.Text = "Dodaj Strucnu spremu";
            this.btnSacuvajStrucnuSpremu.UseSelectable = true;
            this.btnSacuvajStrucnuSpremu.Click += new System.EventHandler(this.btnSacuvajStrucnuSpremu_Click);
            // 
            // txtStrucnaSprema
            // 
            // 
            // 
            // 
            this.txtStrucnaSprema.CustomButton.Image = null;
            this.txtStrucnaSprema.CustomButton.Location = new System.Drawing.Point(165, 2);
            this.txtStrucnaSprema.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtStrucnaSprema.CustomButton.Name = "";
            this.txtStrucnaSprema.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtStrucnaSprema.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStrucnaSprema.CustomButton.TabIndex = 1;
            this.txtStrucnaSprema.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStrucnaSprema.CustomButton.UseSelectable = true;
            this.txtStrucnaSprema.CustomButton.Visible = false;
            this.txtStrucnaSprema.Lines = new string[0];
            this.txtStrucnaSprema.Location = new System.Drawing.Point(147, 18);
            this.txtStrucnaSprema.Margin = new System.Windows.Forms.Padding(4);
            this.txtStrucnaSprema.MaxLength = 32767;
            this.txtStrucnaSprema.Name = "txtStrucnaSprema";
            this.txtStrucnaSprema.PasswordChar = '\0';
            this.txtStrucnaSprema.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStrucnaSprema.SelectedText = "";
            this.txtStrucnaSprema.SelectionLength = 0;
            this.txtStrucnaSprema.SelectionStart = 0;
            this.txtStrucnaSprema.ShortcutsEnabled = true;
            this.txtStrucnaSprema.Size = new System.Drawing.Size(191, 28);
            this.txtStrucnaSprema.TabIndex = 0;
            this.txtStrucnaSprema.UseSelectable = true;
            this.txtStrucnaSprema.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStrucnaSprema.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStrucnaSprema.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStrucnaSprema_KeyPress);
            // 
            // dgvOblasti
            // 
            this.dgvOblasti.AllowUserToResizeRows = false;
            this.dgvOblasti.BackgroundColor = System.Drawing.Color.White;
            this.dgvOblasti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOblasti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOblasti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOblasti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOblasti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOblasti.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOblasti.EnableHeadersVisualStyles = false;
            this.dgvOblasti.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvOblasti.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOblasti.Location = new System.Drawing.Point(143, 47);
            this.dgvOblasti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOblasti.Name = "dgvOblasti";
            this.dgvOblasti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOblasti.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOblasti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvOblasti.RowTemplate.Height = 24;
            this.dgvOblasti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOblasti.Size = new System.Drawing.Size(191, 126);
            this.dgvOblasti.TabIndex = 1;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel2.Controls.Add(this.metroButton2);
            this.metroPanel2.Controls.Add(this.dgvOblasti);
            this.metroPanel2.Controls.Add(this.txtOblastTehnike);
            this.metroPanel2.Controls.Add(this.lbloblasttehnike);
            this.metroPanel2.Controls.Add(this.btnSacuvajOblastTehnike);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 425);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(416, 212);
            this.metroPanel2.TabIndex = 20;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 11;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(9, 179);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(171, 28);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Obrisi oblast tehnike";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // dgvStruke
            // 
            this.dgvStruke.AllowUserToResizeRows = false;
            this.dgvStruke.BackgroundColor = System.Drawing.Color.White;
            this.dgvStruke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStruke.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStruke.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStruke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStruke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStruke.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStruke.EnableHeadersVisualStyles = false;
            this.dgvStruke.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvStruke.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStruke.Location = new System.Drawing.Point(147, 52);
            this.dgvStruke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStruke.Name = "dgvStruke";
            this.dgvStruke.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStruke.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStruke.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStruke.RowTemplate.Height = 24;
            this.dgvStruke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStruke.Size = new System.Drawing.Size(187, 123);
            this.dgvStruke.TabIndex = 1;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel3.Controls.Add(this.metroButton1);
            this.metroPanel3.Controls.Add(this.dgvStruke);
            this.metroPanel3.Controls.Add(this.txtStrucnaSprema);
            this.metroPanel3.Controls.Add(this.btnSacuvajStrucnuSpremu);
            this.metroPanel3.Controls.Add(this.lblstrucnasprema);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(479, 425);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(389, 212);
            this.metroPanel3.TabIndex = 22;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 11;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(4, 179);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(171, 28);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Obrisi Strucnu spremu";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // DodajTehnickoLice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 716);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DodajTehnickoLice";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Dodaj tehnicko lice";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOblasti)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStruke)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroDateTime dtpRodjenja;
        private MetroFramework.Controls.MetroRadioButton radioM;
        private MetroFramework.Controls.MetroTextBox txtJMBG;
        private MetroFramework.Controls.MetroRadioButton radioZ;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPrezime;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIme;
        private MetroFramework.Controls.MetroLabel lbloblasttehnike;
        private MetroFramework.Controls.MetroLabel lblstrucnasprema;
        private MetroFramework.Controls.MetroButton btnSacuvajOblastTehnike;
        private MetroFramework.Controls.MetroTextBox txtOblastTehnike;
        private MetroFramework.Controls.MetroButton btnSacuvajStrucnuSpremu;
        private MetroFramework.Controls.MetroTextBox txtStrucnaSprema;
        private MetroFramework.Controls.MetroGrid dgvOblasti;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgvStruke;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}