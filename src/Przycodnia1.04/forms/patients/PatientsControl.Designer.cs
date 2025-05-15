namespace Przychodnia.forms.patients
{
    partial class PatientsControl
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PatientDataButton = new System.Windows.Forms.Button();
            this.PatientsList = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.editPatient = new System.Windows.Forms.Button();
            this.addPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsList)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientDataButton
            // 
            this.PatientDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientDataButton.Location = new System.Drawing.Point(639, 553);
            this.PatientDataButton.Name = "PatientDataButton";
            this.PatientDataButton.Size = new System.Drawing.Size(125, 34);
            this.PatientDataButton.TabIndex = 25;
            this.PatientDataButton.Text = "Podgląd danych";
            this.PatientDataButton.UseVisualStyleBackColor = true;
            this.PatientDataButton.Click += new System.EventHandler(this.PatientDataButton_Click);
            // 
            // PatientsList
            // 
            this.PatientsList.AllowUserToAddRows = false;
            this.PatientsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsList.Location = new System.Drawing.Point(40, 131);
            this.PatientsList.Margin = new System.Windows.Forms.Padding(4);
            this.PatientsList.MultiSelect = false;
            this.PatientsList.Name = "PatientsList";
            this.PatientsList.ReadOnly = true;
            this.PatientsList.RowHeadersVisible = false;
            this.PatientsList.RowHeadersWidth = 51;
            this.PatientsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsList.Size = new System.Drawing.Size(724, 415);
            this.PatientsList.TabIndex = 27;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(40, 90);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 34);
            this.searchButton.TabIndex = 24;
            this.searchButton.Text = "Wyszukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // editPatient
            // 
            this.editPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPatient.Location = new System.Drawing.Point(639, 88);
            this.editPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editPatient.Name = "editPatient";
            this.editPatient.Size = new System.Drawing.Size(125, 33);
            this.editPatient.TabIndex = 23;
            this.editPatient.Text = "Edytuj pacjentów";
            this.editPatient.UseVisualStyleBackColor = true;
            this.editPatient.Click += new System.EventHandler(this.editPatient_Click);
            // 
            // addPatient
            // 
            this.addPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPatient.Location = new System.Drawing.Point(508, 88);
            this.addPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(125, 33);
            this.addPatient.TabIndex = 22;
            this.addPatient.Text = "Dodaj pacjenta";
            this.addPatient.UseVisualStyleBackColor = true;
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 62);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lista pacjentów";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(148, 96);
            this.searchText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(355, 20);
            this.searchText.TabIndex = 20;
            // 
            // PatientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PatientDataButton);
            this.Controls.Add(this.PatientsList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.editPatient);
            this.Controls.Add(this.addPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.Name = "PatientsControl";
            this.Size = new System.Drawing.Size(819, 598);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientsList;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button editPatient;
        private System.Windows.Forms.Button addPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button PatientDataButton;
    }
}
