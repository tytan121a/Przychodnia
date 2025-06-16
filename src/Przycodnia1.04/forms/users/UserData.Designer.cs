namespace Przychodnia.forms
{
    partial class UserData
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
            this.Anuluj = new System.Windows.Forms.Button();
            this.forget = new System.Windows.Forms.Button();
            this.dataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.rola = new System.Windows.Forms.ComboBox();
            this.plec = new System.Windows.Forms.ComboBox();
            this.haslo = new System.Windows.Forms.TextBox();
            this.imie = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.pesel = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.numerTelefonu = new System.Windows.Forms.TextBox();
            this.miejscowosc = new System.Windows.Forms.TextBox();
            this.kodPocztowy = new System.Windows.Forms.TextBox();
            this.ulica = new System.Windows.Forms.TextBox();
            this.numerPosesji = new System.Windows.Forms.TextBox();
            this.numerLokalu = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
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
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Anuluj
            // 
            this.Anuluj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Anuluj.Location = new System.Drawing.Point(920, 385);
            this.Anuluj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(91, 37);
            this.Anuluj.TabIndex = 140;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // forget
            // 
            this.forget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.forget.Location = new System.Drawing.Point(808, 385);
            this.forget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(91, 37);
            this.forget.TabIndex = 139;
            this.forget.Text = "Zapomnij";
            this.forget.UseVisualStyleBackColor = true;
            this.forget.Click += new System.EventHandler(this.zapomnij_Click);
            // 
            // dataUrodzenia
            // 
            this.dataUrodzenia.Enabled = false;
            this.dataUrodzenia.Location = new System.Drawing.Point(287, 261);
            this.dataUrodzenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataUrodzenia.Name = "dataUrodzenia";
            this.dataUrodzenia.Size = new System.Drawing.Size(200, 22);
            this.dataUrodzenia.TabIndex = 129;
            // 
            // rola
            // 
            this.rola.Enabled = false;
            this.rola.FormattingEnabled = true;
            this.rola.Location = new System.Drawing.Point(699, 309);
            this.rola.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rola.Name = "rola";
            this.rola.Size = new System.Drawing.Size(160, 24);
            this.rola.TabIndex = 138;
            // 
            // plec
            // 
            this.plec.Enabled = false;
            this.plec.FormattingEnabled = true;
            this.plec.Location = new System.Drawing.Point(699, 261);
            this.plec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plec.Name = "plec";
            this.plec.Size = new System.Drawing.Size(160, 24);
            this.plec.TabIndex = 137;
            // 
            // haslo
            // 
            this.haslo.Enabled = false;
            this.haslo.Location = new System.Drawing.Point(173, 89);
            this.haslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.haslo.MaxLength = 15;
            this.haslo.Name = "haslo";
            this.haslo.ReadOnly = true;
            this.haslo.Size = new System.Drawing.Size(313, 22);
            this.haslo.TabIndex = 125;
            this.haslo.UseSystemPasswordChar = true;
            // 
            // imie
            // 
            this.imie.Enabled = false;
            this.imie.Location = new System.Drawing.Point(173, 129);
            this.imie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imie.MaxLength = 20;
            this.imie.Name = "imie";
            this.imie.ReadOnly = true;
            this.imie.Size = new System.Drawing.Size(313, 22);
            this.imie.TabIndex = 126;
            // 
            // nazwisko
            // 
            this.nazwisko.Enabled = false;
            this.nazwisko.Location = new System.Drawing.Point(173, 177);
            this.nazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nazwisko.MaxLength = 30;
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.ReadOnly = true;
            this.nazwisko.Size = new System.Drawing.Size(313, 22);
            this.nazwisko.TabIndex = 127;
            // 
            // pesel
            // 
            this.pesel.Enabled = false;
            this.pesel.Location = new System.Drawing.Point(173, 223);
            this.pesel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pesel.MaxLength = 11;
            this.pesel.Name = "pesel";
            this.pesel.ReadOnly = true;
            this.pesel.Size = new System.Drawing.Size(313, 22);
            this.pesel.TabIndex = 128;
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(173, 306);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.MaxLength = 25;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(313, 22);
            this.email.TabIndex = 130;
            // 
            // numerTelefonu
            // 
            this.numerTelefonu.Enabled = false;
            this.numerTelefonu.Location = new System.Drawing.Point(173, 347);
            this.numerTelefonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numerTelefonu.MaxLength = 9;
            this.numerTelefonu.Name = "numerTelefonu";
            this.numerTelefonu.ReadOnly = true;
            this.numerTelefonu.Size = new System.Drawing.Size(313, 22);
            this.numerTelefonu.TabIndex = 131;
            // 
            // miejscowosc
            // 
            this.miejscowosc.Enabled = false;
            this.miejscowosc.Location = new System.Drawing.Point(699, 46);
            this.miejscowosc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.miejscowosc.MaxLength = 30;
            this.miejscowosc.Name = "miejscowosc";
            this.miejscowosc.ReadOnly = true;
            this.miejscowosc.Size = new System.Drawing.Size(313, 22);
            this.miejscowosc.TabIndex = 132;
            // 
            // kodPocztowy
            // 
            this.kodPocztowy.Enabled = false;
            this.kodPocztowy.Location = new System.Drawing.Point(699, 92);
            this.kodPocztowy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kodPocztowy.MaxLength = 6;
            this.kodPocztowy.Name = "kodPocztowy";
            this.kodPocztowy.ReadOnly = true;
            this.kodPocztowy.Size = new System.Drawing.Size(313, 22);
            this.kodPocztowy.TabIndex = 133;
            // 
            // ulica
            // 
            this.ulica.Enabled = false;
            this.ulica.Location = new System.Drawing.Point(699, 133);
            this.ulica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ulica.MaxLength = 50;
            this.ulica.Name = "ulica";
            this.ulica.ReadOnly = true;
            this.ulica.Size = new System.Drawing.Size(313, 22);
            this.ulica.TabIndex = 134;
            // 
            // numerPosesji
            // 
            this.numerPosesji.Enabled = false;
            this.numerPosesji.Location = new System.Drawing.Point(699, 178);
            this.numerPosesji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numerPosesji.MaxLength = 10;
            this.numerPosesji.Name = "numerPosesji";
            this.numerPosesji.ReadOnly = true;
            this.numerPosesji.Size = new System.Drawing.Size(313, 22);
            this.numerPosesji.TabIndex = 135;
            // 
            // numerLokalu
            // 
            this.numerLokalu.Enabled = false;
            this.numerLokalu.Location = new System.Drawing.Point(699, 229);
            this.numerLokalu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numerLokalu.MaxLength = 10;
            this.numerLokalu.Name = "numerLokalu";
            this.numerLokalu.ReadOnly = true;
            this.numerLokalu.Size = new System.Drawing.Size(313, 22);
            this.numerLokalu.TabIndex = 136;
            // 
            // login
            // 
            this.login.Enabled = false;
            this.login.Location = new System.Drawing.Point(173, 42);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.MaxLength = 30;
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Size = new System.Drawing.Size(313, 22);
            this.login.TabIndex = 124;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label14.Location = new System.Drawing.Point(539, 263);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(50, 25);
            this.Label14.TabIndex = 123;
            this.Label14.Text = "Płeć";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label15.Location = new System.Drawing.Point(539, 311);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(51, 25);
            this.Label15.TabIndex = 122;
            this.Label15.Text = "Rola";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label11.Location = new System.Drawing.Point(539, 133);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(55, 25);
            this.Label11.TabIndex = 121;
            this.Label11.Text = "Ulica";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label12.Location = new System.Drawing.Point(539, 178);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(136, 25);
            this.Label12.TabIndex = 120;
            this.Label12.Text = "Numer posesji";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label13.Location = new System.Drawing.Point(539, 226);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(126, 25);
            this.Label13.TabIndex = 119;
            this.Label13.Text = "Numer lokalu";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label7.Location = new System.Drawing.Point(43, 303);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(60, 25);
            this.Label7.TabIndex = 118;
            this.Label7.Text = "Email";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label8.Location = new System.Drawing.Point(43, 346);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(78, 25);
            this.Label8.TabIndex = 117;
            this.Label8.Text = "Telefon";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label9.Location = new System.Drawing.Point(539, 46);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(124, 25);
            this.Label9.TabIndex = 116;
            this.Label9.Text = "Miejscowość";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label10.Location = new System.Drawing.Point(539, 92);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(135, 25);
            this.Label10.TabIndex = 115;
            this.Label10.Text = "Kod pocztowy";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label5.Location = new System.Drawing.Point(43, 220);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(61, 25);
            this.Label5.TabIndex = 114;
            this.Label5.Text = "Pesel";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label6.Location = new System.Drawing.Point(43, 263);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(144, 25);
            this.Label6.TabIndex = 113;
            this.Label6.Text = "Data urodzenia";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label3.Location = new System.Drawing.Point(43, 130);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 25);
            this.Label3.TabIndex = 112;
            this.Label3.Text = "Imie";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label4.Location = new System.Drawing.Point(43, 175);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(96, 25);
            this.Label4.TabIndex = 111;
            this.Label4.Text = "Nazwisko";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label2.Location = new System.Drawing.Point(43, 90);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 25);
            this.Label2.TabIndex = 110;
            this.Label2.Text = "Hasło";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(43, 44);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 25);
            this.Label1.TabIndex = 109;
            this.Label1.Text = "Login";
            // 
            // UserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.forget);
            this.Controls.Add(this.dataUrodzenia);
            this.Controls.Add(this.rola);
            this.Controls.Add(this.plec);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.numerTelefonu);
            this.Controls.Add(this.miejscowosc);
            this.Controls.Add(this.kodPocztowy);
            this.Controls.Add(this.ulica);
            this.Controls.Add(this.numerPosesji);
            this.Controls.Add(this.numerLokalu);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label15);
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
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserData";
            this.Size = new System.Drawing.Size(1027, 972);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Anuluj;
        private System.Windows.Forms.Button forget;
        private System.Windows.Forms.DateTimePicker dataUrodzenia;
        private System.Windows.Forms.ComboBox rola;
        private System.Windows.Forms.ComboBox plec;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox numerTelefonu;
        private System.Windows.Forms.TextBox miejscowosc;
        private System.Windows.Forms.TextBox kodPocztowy;
        private System.Windows.Forms.TextBox ulica;
        private System.Windows.Forms.TextBox numerPosesji;
        private System.Windows.Forms.TextBox numerLokalu;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Label Label15;
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
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
    }
}
