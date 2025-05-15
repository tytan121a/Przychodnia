namespace Przychodnia.forms.patients
{
    partial class PatientAdd
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.PESEL = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.PostalCode = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.PropertyNumber = new System.Windows.Forms.TextBox();
            this.ApartmentNumber = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(710, 298);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(68, 30);
            this.Cancel.TabIndex = 120;
            this.Cancel.Text = "Anuluj";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(626, 298);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(68, 30);
            this.Save.TabIndex = 119;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // BirthDate
            // 
            this.BirthDate.Location = new System.Drawing.Point(246, 175);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(151, 20);
            this.BirthDate.TabIndex = 109;
            // 
            // Gender
            // 
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(162, 282);
            this.Gender.Margin = new System.Windows.Forms.Padding(2);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 21);
            this.Gender.TabIndex = 117;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(162, 67);
            this.FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.FirstName.MaxLength = 20;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(236, 20);
            this.FirstName.TabIndex = 106;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(162, 106);
            this.LastName.Margin = new System.Windows.Forms.Padding(2);
            this.LastName.MaxLength = 30;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(236, 20);
            this.LastName.TabIndex = 107;
            // 
            // PESEL
            // 
            this.PESEL.Location = new System.Drawing.Point(162, 144);
            this.PESEL.Margin = new System.Windows.Forms.Padding(2);
            this.PESEL.MaxLength = 11;
            this.PESEL.Name = "PESEL";
            this.PESEL.Size = new System.Drawing.Size(236, 20);
            this.PESEL.TabIndex = 108;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(162, 211);
            this.Email.Margin = new System.Windows.Forms.Padding(2);
            this.Email.MaxLength = 25;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(236, 20);
            this.Email.TabIndex = 110;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(162, 245);
            this.Phone.Margin = new System.Windows.Forms.Padding(2);
            this.Phone.MaxLength = 9;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(236, 20);
            this.Phone.TabIndex = 111;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(554, 69);
            this.City.Margin = new System.Windows.Forms.Padding(2);
            this.City.MaxLength = 30;
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(236, 20);
            this.City.TabIndex = 112;
            // 
            // PostalCode
            // 
            this.PostalCode.Location = new System.Drawing.Point(554, 106);
            this.PostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.PostalCode.MaxLength = 6;
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Size = new System.Drawing.Size(236, 20);
            this.PostalCode.TabIndex = 113;
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(554, 140);
            this.Street.Margin = new System.Windows.Forms.Padding(2);
            this.Street.MaxLength = 50;
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(236, 20);
            this.Street.TabIndex = 114;
            // 
            // PropertyNumber
            // 
            this.PropertyNumber.Location = new System.Drawing.Point(554, 177);
            this.PropertyNumber.Margin = new System.Windows.Forms.Padding(2);
            this.PropertyNumber.MaxLength = 10;
            this.PropertyNumber.Name = "PropertyNumber";
            this.PropertyNumber.Size = new System.Drawing.Size(236, 20);
            this.PropertyNumber.TabIndex = 115;
            // 
            // ApartmentNumber
            // 
            this.ApartmentNumber.Location = new System.Drawing.Point(554, 214);
            this.ApartmentNumber.Margin = new System.Windows.Forms.Padding(2);
            this.ApartmentNumber.MaxLength = 10;
            this.ApartmentNumber.Name = "ApartmentNumber";
            this.ApartmentNumber.Size = new System.Drawing.Size(236, 20);
            this.ApartmentNumber.TabIndex = 116;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label14.Location = new System.Drawing.Point(60, 280);
            this.Label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(40, 20);
            this.Label14.TabIndex = 103;
            this.Label14.Text = "Płeć";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label11.Location = new System.Drawing.Point(429, 140);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(44, 20);
            this.Label11.TabIndex = 101;
            this.Label11.Text = "Ulica";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label12.Location = new System.Drawing.Point(429, 177);
            this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(109, 20);
            this.Label12.TabIndex = 100;
            this.Label12.Text = "Numer posesji";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label13.Location = new System.Drawing.Point(429, 214);
            this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(101, 20);
            this.Label13.TabIndex = 99;
            this.Label13.Text = "Numer lokalu";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label7.Location = new System.Drawing.Point(60, 209);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(48, 20);
            this.Label7.TabIndex = 98;
            this.Label7.Text = "Email";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label8.Location = new System.Drawing.Point(60, 243);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(62, 20);
            this.Label8.TabIndex = 97;
            this.Label8.Text = "Telefon";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label9.Location = new System.Drawing.Point(429, 69);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(98, 20);
            this.Label9.TabIndex = 96;
            this.Label9.Text = "Miejscowość";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label10.Location = new System.Drawing.Point(429, 106);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(107, 20);
            this.Label10.TabIndex = 95;
            this.Label10.Text = "Kod pocztowy";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label5.Location = new System.Drawing.Point(60, 141);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 20);
            this.Label5.TabIndex = 94;
            this.Label5.Text = "Pesel";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label6.Location = new System.Drawing.Point(60, 176);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(118, 20);
            this.Label6.TabIndex = 93;
            this.Label6.Text = "Data urodzenia";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label3.Location = new System.Drawing.Point(60, 69);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 20);
            this.Label3.TabIndex = 92;
            this.Label3.Text = "Imie";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label4.Location = new System.Drawing.Point(60, 105);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(76, 20);
            this.Label4.TabIndex = 91;
            this.Label4.Text = "Nazwisko";
            // 
            // PatientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.PESEL);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.City);
            this.Controls.Add(this.PostalCode);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.PropertyNumber);
            this.Controls.Add(this.ApartmentNumber);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Name = "PatientAdd";
            this.Size = new System.Drawing.Size(891, 709);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox PESEL;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox PostalCode;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.TextBox PropertyNumber;
        private System.Windows.Forms.TextBox ApartmentNumber;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
    }
}
