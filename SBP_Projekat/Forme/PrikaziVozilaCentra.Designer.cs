namespace SBP_Projekat.Forme
{
    partial class PrikaziVozilaCentra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVozila = new MetroFramework.Controls.MetroGrid();
            this.btnAddVozilo = new MetroFramework.Controls.MetroButton();
            this.btnObrisiVozilo = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVozila
            // 
            this.dgvVozila.AllowUserToResizeRows = false;
            this.dgvVozila.BackgroundColor = System.Drawing.Color.White;
            this.dgvVozila.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVozila.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVozila.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVozila.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVozila.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVozila.EnableHeadersVisualStyles = false;
            this.dgvVozila.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvVozila.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVozila.Location = new System.Drawing.Point(35, 84);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVozila.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVozila.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVozila.RowTemplate.Height = 24;
            this.dgvVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVozila.Size = new System.Drawing.Size(875, 355);
            this.dgvVozila.TabIndex = 0;
            this.dgvVozila.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVozila_CellContentDoubleClick);
            // 
            // btnAddVozilo
            // 
            this.btnAddVozilo.Location = new System.Drawing.Point(537, 464);
            this.btnAddVozilo.Name = "btnAddVozilo";
            this.btnAddVozilo.Size = new System.Drawing.Size(175, 41);
            this.btnAddVozilo.TabIndex = 1;
            this.btnAddVozilo.Text = "Dodaj vozilo centru";
            this.btnAddVozilo.UseSelectable = true;
            this.btnAddVozilo.Click += new System.EventHandler(this.btnAddVozilo_Click);
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.Location = new System.Drawing.Point(735, 464);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(175, 41);
            this.btnObrisiVozilo.TabIndex = 2;
            this.btnObrisiVozilo.Text = "Obrisi vozilo";
            this.btnObrisiVozilo.UseSelectable = true;
            // 
            // PrikaziVozilaCentra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 538);
            this.Controls.Add(this.btnObrisiVozilo);
            this.Controls.Add(this.btnAddVozilo);
            this.Controls.Add(this.dgvVozila);
            this.Name = "PrikaziVozilaCentra";
            this.Text = "Prikazi vozila regionalnog centra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvVozila;
        private MetroFramework.Controls.MetroButton btnAddVozilo;
        private MetroFramework.Controls.MetroButton btnObrisiVozilo;
    }
}