using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EwidencjaPojazdow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string nr = txtNrRejestracyjny.Text;
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            int rok = (int)numRokProdukcji.Value;
            DateTime data = dtpDataPrzegladu.Value;
            string wlasciciel = txtWlasciciel.Text;

            if (string.IsNullOrWhiteSpace(txtNrRejestracyjny.Text) ||
                string.IsNullOrWhiteSpace(txtMarka.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtWlasciciel.Text))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione!", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNrRejestracyjny.Text.Length < 5)
            {
                MessageBox.Show("Numer rejestracyjny jest za krótki!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpDataPrzegladu.Value < DateTime.Now.AddYears(-2))
            {
                MessageBox.Show("Data przeglądu jest zbyt odległa w przeszłości!", "Błąd daty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                dgvPojazdy.Rows.Add(
                    txtNrRejestracyjny.Text.ToUpper(),
                    txtMarka.Text,
                    txtModel.Text,
                    numRokProdukcji.Value.ToString(),
                    dtpDataPrzegladu.Value.ToShortDateString(),
                    txtWlasciciel.Text
                );
                WyczyscPola();
                MessageBox.Show("Pojazd został dodany pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas dodawania: " + ex.Message);
            }
        }
        private void WyczyscPola()
        {
            txtNrRejestracyjny.Clear();
            txtMarka.Clear();
            txtModel.Clear();
            txtWlasciciel.Clear();
            numRokProdukcji.Value = 2020;
            dtpDataPrzegladu.Value = DateTime.Now;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var daneFiltr = dgvPojazdy.Rows.Cast<DataGridViewRow>()
        .Where(row => !row.IsNewRow)
        .Select(row => new
        {
            NrRejestracyjny = row.Cells[0].Value?.ToString(),
            Marka = row.Cells[1].Value?.ToString(),
            Wlasciciel = row.Cells[5].Value?.ToString(),
            DataPrzegladu = DateTime.Parse(row.Cells[4].Value?.ToString())
        })
        .Where(p => p.DataPrzegladu.Month == DateTime.Now.Month &&
                    p.DataPrzegladu.Year == DateTime.Now.Year)
        .ToList();
            FormRaport okno = new FormRaport();
            okno.PokazRaport(daneFiltr);
            okno.Show();
        }
    }
}
