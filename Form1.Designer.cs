namespace gym
{
    partial class Form1
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
            this.llbNume = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTipAbonament = new System.Windows.Forms.Label();
            this.lblDataInceput = new System.Windows.Forms.Label();
            this.lblDataExpirare = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.cmbTipAbonament = new System.Windows.Forms.ComboBox();
            this.dtpDataInceput = new System.Windows.Forms.DateTimePicker();
            this.dtpDataExpirare = new System.Windows.Forms.DateTimePicker();
            this.chkActiv = new System.Windows.Forms.CheckBox();
            this.dgvMembri = new System.Windows.Forms.DataGridView();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.btnReinnoieste = new System.Windows.Forms.Button();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembri)).BeginInit();
            this.SuspendLayout();
            // 
            // llbNume
            // 
            this.llbNume.AutoSize = true;
            this.llbNume.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbNume.Location = new System.Drawing.Point(30, 28);
            this.llbNume.Name = "llbNume";
            this.llbNume.Size = new System.Drawing.Size(52, 20);
            this.llbNume.TabIndex = 0;
            this.llbNume.Text = "Nume";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(30, 79);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(60, 20);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblTipAbonament
            // 
            this.lblTipAbonament.AutoSize = true;
            this.lblTipAbonament.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipAbonament.Location = new System.Drawing.Point(30, 129);
            this.lblTipAbonament.Name = "lblTipAbonament";
            this.lblTipAbonament.Size = new System.Drawing.Size(115, 20);
            this.lblTipAbonament.TabIndex = 2;
            this.lblTipAbonament.Text = "Tip abonament";
            // 
            // lblDataInceput
            // 
            this.lblDataInceput.AutoSize = true;
            this.lblDataInceput.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInceput.Location = new System.Drawing.Point(30, 178);
            this.lblDataInceput.Name = "lblDataInceput";
            this.lblDataInceput.Size = new System.Drawing.Size(189, 20);
            this.lblDataInceput.TabIndex = 3;
            this.lblDataInceput.Text = "Data inceperii abonament";
            // 
            // lblDataExpirare
            // 
            this.lblDataExpirare.AutoSize = true;
            this.lblDataExpirare.Font = new System.Drawing.Font("Nirmala UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataExpirare.Location = new System.Drawing.Point(31, 241);
            this.lblDataExpirare.Name = "lblDataExpirare";
            this.lblDataExpirare.Size = new System.Drawing.Size(187, 20);
            this.lblDataExpirare.TabIndex = 4;
            this.lblDataExpirare.Text = "Data expirarii abonament";
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.Color.Bisque;
            this.txtNume.ForeColor = System.Drawing.Color.Black;
            this.txtNume.Location = new System.Drawing.Point(173, 26);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(121, 22);
            this.txtNume.TabIndex = 5;
            this.txtNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNume_KeyPress);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.Bisque;
            this.txtTelefon.Location = new System.Drawing.Point(173, 76);
            this.txtTelefon.MaxLength = 10;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(121, 22);
            this.txtTelefon.TabIndex = 6;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // cmbTipAbonament
            // 
            this.cmbTipAbonament.BackColor = System.Drawing.Color.Bisque;
            this.cmbTipAbonament.FormattingEnabled = true;
            this.cmbTipAbonament.Items.AddRange(new object[] {
            "Lunar",
            "3 Luni",
            "6 Luni",
            "Anual"});
            this.cmbTipAbonament.Location = new System.Drawing.Point(173, 129);
            this.cmbTipAbonament.Name = "cmbTipAbonament";
            this.cmbTipAbonament.Size = new System.Drawing.Size(121, 24);
            this.cmbTipAbonament.TabIndex = 7;
            // 
            // dtpDataInceput
            // 
            this.dtpDataInceput.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dtpDataInceput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDataInceput.Location = new System.Drawing.Point(261, 176);
            this.dtpDataInceput.Name = "dtpDataInceput";
            this.dtpDataInceput.Size = new System.Drawing.Size(256, 22);
            this.dtpDataInceput.TabIndex = 8;
            // 
            // dtpDataExpirare
            // 
            this.dtpDataExpirare.Location = new System.Drawing.Point(261, 239);
            this.dtpDataExpirare.Name = "dtpDataExpirare";
            this.dtpDataExpirare.Size = new System.Drawing.Size(256, 22);
            this.dtpDataExpirare.TabIndex = 9;
            // 
            // chkActiv
            // 
            this.chkActiv.AutoSize = true;
            this.chkActiv.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActiv.Location = new System.Drawing.Point(394, 28);
            this.chkActiv.Name = "chkActiv";
            this.chkActiv.Size = new System.Drawing.Size(78, 32);
            this.chkActiv.TabIndex = 10;
            this.chkActiv.Text = "Activ";
            this.chkActiv.UseVisualStyleBackColor = true;
            // 
            // dgvMembri
            // 
            this.dgvMembri.AllowUserToAddRows = false;
            this.dgvMembri.AllowUserToDeleteRows = false;
            this.dgvMembri.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvMembri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembri.Location = new System.Drawing.Point(12, 297);
            this.dgvMembri.Name = "dgvMembri";
            this.dgvMembri.ReadOnly = true;
            this.dgvMembri.RowHeadersWidth = 51;
            this.dgvMembri.RowTemplate.Height = 24;
            this.dgvMembri.Size = new System.Drawing.Size(1147, 318);
            this.dgvMembri.TabIndex = 11;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(651, 13);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(106, 35);
            this.btnAdauga.TabIndex = 12;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.MistyRose;
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(651, 76);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(106, 32);
            this.btnModifica.TabIndex = 13;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.MistyRose;
            this.btnSterge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSterge.Location = new System.Drawing.Point(804, 76);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(106, 32);
            this.btnSterge.TabIndex = 14;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnReinnoieste
            // 
            this.btnReinnoieste.BackColor = System.Drawing.Color.MistyRose;
            this.btnReinnoieste.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinnoieste.Location = new System.Drawing.Point(804, 13);
            this.btnReinnoieste.Name = "btnReinnoieste";
            this.btnReinnoieste.Size = new System.Drawing.Size(106, 35);
            this.btnReinnoieste.TabIndex = 15;
            this.btnReinnoieste.Text = "Reinnoieste";
            this.btnReinnoieste.UseVisualStyleBackColor = false;
            this.btnReinnoieste.Click += new System.EventHandler(this.btnReinnoieste_Click);
            // 
            // btnVerifica
            // 
            this.btnVerifica.BackColor = System.Drawing.Color.MistyRose;
            this.btnVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica.Location = new System.Drawing.Point(651, 129);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(106, 35);
            this.btnVerifica.TabIndex = 16;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = false;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MistyRose;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(804, 129);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 35);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1612, 620);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.btnReinnoieste);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dgvMembri);
            this.Controls.Add(this.chkActiv);
            this.Controls.Add(this.dtpDataExpirare);
            this.Controls.Add(this.dtpDataInceput);
            this.Controls.Add(this.cmbTipAbonament);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblDataExpirare);
            this.Controls.Add(this.lblDataInceput);
            this.Controls.Add(this.lblTipAbonament);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.llbNume);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label llbNume;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTipAbonament;
        private System.Windows.Forms.Label lblDataInceput;
        private System.Windows.Forms.Label lblDataExpirare;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbTipAbonament;
        private System.Windows.Forms.DateTimePicker dtpDataInceput;
        private System.Windows.Forms.DateTimePicker dtpDataExpirare;
        private System.Windows.Forms.CheckBox chkActiv;
        private System.Windows.Forms.DataGridView dgvMembri;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnReinnoieste;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.Button btnReset;
    }
}

