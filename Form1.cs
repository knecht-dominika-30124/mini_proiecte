using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gym
{
    public partial class Form1 : Form
    {
        List<Membru> membri = new List<Membru>();
        int urmatorulId = 1;

        public Form1()
        {
            InitializeComponent();
            InitializareComboBox();
            InitializareDataGridView();
        }

        private void InitializareComboBox()
        {
            cmbTipAbonament.Items.Clear();
            cmbTipAbonament.Items.Add("Lunar");
            cmbTipAbonament.Items.Add("3 Luni");
            cmbTipAbonament.Items.Add("6 Luni");
            cmbTipAbonament.Items.Add("Anual");
            cmbTipAbonament.SelectedIndex = -1;
        }

        private void InitializareDataGridView()
        {
            dgvMembri.AutoGenerateColumns = true;
            dgvMembri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembri.MultiSelect = false;
        }

        private void AfiseazaMembri()
        {
            dgvMembri.DataSource = null;
            dgvMembri.DataSource = membri;
        }

        private string CalculeazaStatus(DateTime dataExpirare)
        {
            DateTime azi = DateTime.Today;

            if (dataExpirare < azi)
            {
                return "Expirat";
            }
            else if ((dataExpirare - azi).Days <= 7)
            {
                return "Expira curand";
            }
            else
            {
                return "Activ";
            }
        }

        private void GolesteCampuri()
        {
            txtNume.Clear();
            txtTelefon.Clear();
            cmbTipAbonament.SelectedIndex = -1;
            dtpDataInceput.Value = DateTime.Today;
            dtpDataExpirare.Value = DateTime.Today;
            chkActiv.Checked = false;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string nume = txtNume.Text.Trim();
            string telefon = txtTelefon.Text.Trim();

            if (nume == "")
            {
                MessageBox.Show("Introdu numele membrului.");
                return;
            }

            if (telefon == "")
            {
                MessageBox.Show("Introdu numarul de telefon.");
                return;
            }

            if (cmbTipAbonament.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza tipul de abonament.");
                return;
            }

            DateTime dataInceput = dtpDataInceput.Value.Date;
            DateTime dataExpirare = dtpDataExpirare.Value.Date;

            if (dataExpirare < dataInceput)
            {
                MessageBox.Show("Data expirarii nu poate fi mai mica decat data inceperii.");
                return;
            }

            string tipAbonament = cmbTipAbonament.SelectedItem.ToString();
            bool activ = chkActiv.Checked;

            Membru membruNou = new Membru
            {
                Id = urmatorulId,
                Nume = nume,
                Telefon = telefon,
                TipAbonament = tipAbonament,
                DataInceput = dataInceput,
                DataExpirare = dataExpirare,
                Activ = activ,
                Status = CalculeazaStatus(dataExpirare)
            };

            membri.Add(membruNou);
            urmatorulId++;

            AfiseazaMembri();
            GolesteCampuri();

            MessageBox.Show("Membrul a fost adaugat cu succes.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            GolesteCampuri();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvMembri.CurrentRow == null)
            {
                MessageBox.Show("Selecteaza un membru pentru modificare.");
                return;
            }

            Membru membruSelectat = dgvMembri.CurrentRow.DataBoundItem as Membru;

            if (membruSelectat == null)
            {
                MessageBox.Show("Nu exista membru selectat.");
                return;
            }

            string nume = txtNume.Text.Trim();
            string telefon = txtTelefon.Text.Trim();

            if (nume == "")
            {
                MessageBox.Show("Introdu numele membrului.");
                return;
            }

            if (telefon == "")
            {
                MessageBox.Show("Introdu numarul de telefon.");
                return;
            }

            if (cmbTipAbonament.SelectedItem == null)
            {
                MessageBox.Show("Selecteaza tipul de abonament.");
                return;
            }

            DateTime dataInceput = dtpDataInceput.Value.Date;
            DateTime dataExpirare = dtpDataExpirare.Value.Date;

            if (dataExpirare < dataInceput)
            {
                MessageBox.Show("Data expirarii nu poate fi mai mica decat data inceperii.");
                return;
            }

            membruSelectat.Nume = nume;
            membruSelectat.Telefon = telefon;
            membruSelectat.TipAbonament = cmbTipAbonament.SelectedItem.ToString();
            membruSelectat.DataInceput = dataInceput;
            membruSelectat.DataExpirare = dataExpirare;
            membruSelectat.Activ = chkActiv.Checked;
            membruSelectat.Status = CalculeazaStatus(dataExpirare);

            AfiseazaMembri();

            MessageBox.Show("Membrul a fost modificat.");
        }

        private void btnReinnoieste_Click(object sender, EventArgs e)
        {
            if (dgvMembri.CurrentRow == null)
            {
                MessageBox.Show("Selecteaza un membru pentru reinnoire.");
                return;
            }

            Membru membruSelectat = dgvMembri.CurrentRow.DataBoundItem as Membru;

            if (membruSelectat == null)
            {
                MessageBox.Show("Nu exista membru selectat.");
                return;
            }

            membruSelectat.DataExpirare = membruSelectat.DataExpirare.AddMonths(1);
            membruSelectat.Activ = true;
            membruSelectat.Status = CalculeazaStatus(membruSelectat.DataExpirare);

            AfiseazaMembri();

            txtNume.Text = membruSelectat.Nume;
            txtTelefon.Text = membruSelectat.Telefon;
            cmbTipAbonament.SelectedItem = membruSelectat.TipAbonament;
            dtpDataInceput.Value = membruSelectat.DataInceput;
            dtpDataExpirare.Value = membruSelectat.DataExpirare;
            chkActiv.Checked = membruSelectat.Activ;

            MessageBox.Show("Abonamentul a fost reinnoit cu o luna.");

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (dgvMembri.CurrentRow == null)
            {
                MessageBox.Show("Selecteaza un membru pentru stergere.");
                return;
            }

            Membru membruSelectat = dgvMembri.CurrentRow.DataBoundItem as Membru;

            if (membruSelectat == null)
            {
                MessageBox.Show("Nu exista membru selectat.");
                return;
            }

            DialogResult rezultat = MessageBox.Show(
                "Sigur vrei sa stergi acest membru?",
                "Confirmare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                membri.Remove(membruSelectat);
                AfiseazaMembri();
                GolesteCampuri();

                if (dgvMembri.Rows.Count > 0)
                {
                    dgvMembri.ClearSelection();
                }

                MessageBox.Show("Membrul a fost sters.");
            }
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            List<Membru> membriCuProbleme = new List<Membru>();

            foreach (Membru m in membri)
            {
                if (m.Status == "Expirat" || m.Status == "Expira curand")
                {
                    membriCuProbleme.Add(m);
                }
            }

            if (membriCuProbleme.Count == 0)
            {
                MessageBox.Show("Nu exista abonamente expirate sau care expira curand.");
                return;
            }

            string mesaj = "Abonamente care necesita atentie:\n\n";

            foreach (Membru m in membriCuProbleme)
            {
                mesaj += m.Nume + " - " + m.Status + " - Expira la: " + m.DataExpirare.ToShortDateString() + "\n";
            }

            MessageBox.Show(mesaj);
        }
        private void dgvMembri_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembri.CurrentRow == null)
                return;

            if (dgvMembri.CurrentRow.Index < 0)
                return;

            if (dgvMembri.CurrentRow.DataBoundItem == null)
                return;

            Membru membruSelectat = dgvMembri.CurrentRow.DataBoundItem as Membru;

            if (membruSelectat == null)
                return;

            txtNume.Text = membruSelectat.Nume;
            txtTelefon.Text = membruSelectat.Telefon;
            cmbTipAbonament.SelectedItem = membruSelectat.TipAbonament;
            dtpDataInceput.Value = membruSelectat.DataInceput;
            dtpDataExpirare.Value = membruSelectat.DataExpirare;
            chkActiv.Checked = membruSelectat.Activ;
        }

        private void txtNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
