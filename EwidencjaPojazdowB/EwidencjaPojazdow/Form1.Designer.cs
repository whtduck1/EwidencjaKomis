namespace EwidencjaPojazdow
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNrRejestracyjny = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.numRokProdukcji = new System.Windows.Forms.NumericUpDown();
            this.dtpDataPrzegladu = new System.Windows.Forms.DateTimePicker();
            this.txtWlasciciel = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPojazdy = new System.Windows.Forms.DataGridView();
            this.colNrRejestracyjny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWlasciciel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numRokProdukcji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer Rejestracyjny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rok produkcji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data przegladu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(863, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Wlasciciel";
            // 
            // txtNrRejestracyjny
            // 
            this.txtNrRejestracyjny.Location = new System.Drawing.Point(55, 72);
            this.txtNrRejestracyjny.Name = "txtNrRejestracyjny";
            this.txtNrRejestracyjny.Size = new System.Drawing.Size(125, 20);
            this.txtNrRejestracyjny.TabIndex = 6;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(197, 72);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 7;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(319, 72);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 8;
            // 
            // numRokProdukcji
            // 
            this.numRokProdukcji.Location = new System.Drawing.Point(444, 72);
            this.numRokProdukcji.Maximum = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.numRokProdukcji.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numRokProdukcji.Name = "numRokProdukcji";
            this.numRokProdukcji.Size = new System.Drawing.Size(120, 20);
            this.numRokProdukcji.TabIndex = 9;
            this.numRokProdukcji.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // dtpDataPrzegladu
            // 
            this.dtpDataPrzegladu.Location = new System.Drawing.Point(585, 72);
            this.dtpDataPrzegladu.Name = "dtpDataPrzegladu";
            this.dtpDataPrzegladu.Size = new System.Drawing.Size(200, 20);
            this.dtpDataPrzegladu.TabIndex = 10;
            // 
            // txtWlasciciel
            // 
            this.txtWlasciciel.Location = new System.Drawing.Point(805, 71);
            this.txtWlasciciel.Name = "txtWlasciciel";
            this.txtWlasciciel.Size = new System.Drawing.Size(166, 20);
            this.txtWlasciciel.TabIndex = 11;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(852, 124);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj Pojazd";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPojazdy
            // 
            this.dgvPojazdy.AccessibleDescription = "a";
            this.dgvPojazdy.AllowUserToAddRows = false;
            this.dgvPojazdy.AllowUserToDeleteRows = false;
            this.dgvPojazdy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNrRejestracyjny,
            this.colMarka,
            this.colModel,
            this.colRok,
            this.colData,
            this.colWlasciciel});
            this.dgvPojazdy.Location = new System.Drawing.Point(55, 124);
            this.dgvPojazdy.Name = "dgvPojazdy";
            this.dgvPojazdy.ReadOnly = true;
            this.dgvPojazdy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPojazdy.Size = new System.Drawing.Size(730, 357);
            this.dgvPojazdy.TabIndex = 13;
            // 
            // colNrRejestracyjny
            // 
            this.colNrRejestracyjny.HeaderText = "Nr Rejestracyjny";
            this.colNrRejestracyjny.Name = "colNrRejestracyjny";
            this.colNrRejestracyjny.ReadOnly = true;
            // 
            // colMarka
            // 
            this.colMarka.HeaderText = "Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.ReadOnly = true;
            // 
            // colModel
            // 
            this.colModel.HeaderText = "Model";
            this.colModel.Name = "colModel";
            this.colModel.ReadOnly = true;
            // 
            // colRok
            // 
            this.colRok.HeaderText = "Rok Produkcji";
            this.colRok.Name = "colRok";
            this.colRok.ReadOnly = true;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data Przeglądu";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colWlasciciel
            // 
            this.colWlasciciel.HeaderText = "Właściciel";
            this.colWlasciciel.Name = "colWlasciciel";
            this.colWlasciciel.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 508);
            this.Controls.Add(this.dgvPojazdy);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtWlasciciel);
            this.Controls.Add(this.dtpDataPrzegladu);
            this.Controls.Add(this.numRokProdukcji);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtNrRejestracyjny);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numRokProdukcji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNrRejestracyjny;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.NumericUpDown numRokProdukcji;
        private System.Windows.Forms.DateTimePicker dtpDataPrzegladu;
        private System.Windows.Forms.TextBox txtWlasciciel;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPojazdy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrRejestracyjny;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarka;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRok;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWlasciciel;
    }
}

