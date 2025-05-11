namespace Przychodnia.forms
{
    partial class UsersControl
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
            this.ZapomnianiUzytkownicy = new System.Windows.Forms.Button();
            this.Podglad = new System.Windows.Forms.Button();
            this.listaUzytkownikow = new System.Windows.Forms.DataGridView();
            this.wyszukajButton = new System.Windows.Forms.Button();
            this.edytujUzytkownikow = new System.Windows.Forms.Button();
            this.dodajUzytkownikow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wyszukajText = new System.Windows.Forms.TextBox();
            this.ForceRecoverPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).BeginInit();
            this.SuspendLayout();
            // 
            // ZapomnianiUzytkownicy
            // 
            this.ZapomnianiUzytkownicy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ZapomnianiUzytkownicy.Location = new System.Drawing.Point(53, 666);
            this.ZapomnianiUzytkownicy.Margin = new System.Windows.Forms.Padding(4);
            this.ZapomnianiUzytkownicy.Name = "ZapomnianiUzytkownicy";
            this.ZapomnianiUzytkownicy.Size = new System.Drawing.Size(233, 42);
            this.ZapomnianiUzytkownicy.TabIndex = 16;
            this.ZapomnianiUzytkownicy.Text = "Zapomniani użytkownicy";
            this.ZapomnianiUzytkownicy.UseVisualStyleBackColor = true;
            this.ZapomnianiUzytkownicy.Click += new System.EventHandler(this.ZapomnianiUzytkownicy_Click);
            // 
            // Podglad
            // 
            this.Podglad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Podglad.Location = new System.Drawing.Point(852, 666);
            this.Podglad.Margin = new System.Windows.Forms.Padding(4);
            this.Podglad.Name = "Podglad";
            this.Podglad.Size = new System.Drawing.Size(167, 42);
            this.Podglad.TabIndex = 15;
            this.Podglad.Text = "Podgląd";
            this.Podglad.UseVisualStyleBackColor = true;
            this.Podglad.Click += new System.EventHandler(this.Podglad_Click);
            // 
            // listaUzytkownikow
            // 
            this.listaUzytkownikow.AllowUserToAddRows = false;
            this.listaUzytkownikow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaUzytkownikow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaUzytkownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUzytkownikow.Location = new System.Drawing.Point(53, 146);
            this.listaUzytkownikow.Margin = new System.Windows.Forms.Padding(5);
            this.listaUzytkownikow.MultiSelect = false;
            this.listaUzytkownikow.Name = "listaUzytkownikow";
            this.listaUzytkownikow.ReadOnly = true;
            this.listaUzytkownikow.RowHeadersVisible = false;
            this.listaUzytkownikow.RowHeadersWidth = 51;
            this.listaUzytkownikow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUzytkownikow.Size = new System.Drawing.Size(965, 511);
            this.listaUzytkownikow.TabIndex = 18;
            // 
            // wyszukajButton
            // 
            this.wyszukajButton.Location = new System.Drawing.Point(53, 96);
            this.wyszukajButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.wyszukajButton.Name = "wyszukajButton";
            this.wyszukajButton.Size = new System.Drawing.Size(137, 42);
            this.wyszukajButton.TabIndex = 14;
            this.wyszukajButton.Text = "Wyszukaj";
            this.wyszukajButton.UseVisualStyleBackColor = true;
            this.wyszukajButton.Click += new System.EventHandler(this.wyszukajButton_Click);
            // 
            // edytujUzytkownikow
            // 
            this.edytujUzytkownikow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edytujUzytkownikow.Location = new System.Drawing.Point(852, 94);
            this.edytujUzytkownikow.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.edytujUzytkownikow.Name = "edytujUzytkownikow";
            this.edytujUzytkownikow.Size = new System.Drawing.Size(167, 41);
            this.edytujUzytkownikow.TabIndex = 13;
            this.edytujUzytkownikow.Text = "Edytuj użytkoników";
            this.edytujUzytkownikow.UseVisualStyleBackColor = true;
            this.edytujUzytkownikow.Click += new System.EventHandler(this.edytujUzytkownikow_Click);
            // 
            // dodajUzytkownikow
            // 
            this.dodajUzytkownikow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dodajUzytkownikow.Location = new System.Drawing.Point(677, 94);
            this.dodajUzytkownikow.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dodajUzytkownikow.Name = "dodajUzytkownikow";
            this.dodajUzytkownikow.Size = new System.Drawing.Size(167, 41);
            this.dodajUzytkownikow.TabIndex = 12;
            this.dodajUzytkownikow.Text = "Dodaj użytkoników";
            this.dodajUzytkownikow.UseVisualStyleBackColor = true;
            this.dodajUzytkownikow.Click += new System.EventHandler(this.dodajUzytkownikow_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1092, 76);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lista użytkowników";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wyszukajText
            // 
            this.wyszukajText.Location = new System.Drawing.Point(197, 103);
            this.wyszukajText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.wyszukajText.Name = "wyszukajText";
            this.wyszukajText.Size = new System.Drawing.Size(472, 22);
            this.wyszukajText.TabIndex = 10;
            // 
            // ForceRecoverPass
            // 
            this.ForceRecoverPass.Location = new System.Drawing.Point(708, 665);
            this.ForceRecoverPass.Name = "ForceRecoverPass";
            this.ForceRecoverPass.Size = new System.Drawing.Size(137, 43);
            this.ForceRecoverPass.TabIndex = 19;
            this.ForceRecoverPass.Text = "Wymuś odzyskanie";
            this.ForceRecoverPass.UseVisualStyleBackColor = true;
            this.ForceRecoverPass.Click += new System.EventHandler(this.ForceRecoverPass_Click);
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ForceRecoverPass);
            this.Controls.Add(this.ZapomnianiUzytkownicy);
            this.Controls.Add(this.Podglad);
            this.Controls.Add(this.listaUzytkownikow);
            this.Controls.Add(this.wyszukajButton);
            this.Controls.Add(this.edytujUzytkownikow);
            this.Controls.Add(this.dodajUzytkownikow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wyszukajText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(1092, 736);
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ZapomnianiUzytkownicy;
        private System.Windows.Forms.Button Podglad;
        private System.Windows.Forms.DataGridView listaUzytkownikow;
        private System.Windows.Forms.Button wyszukajButton;
        private System.Windows.Forms.Button edytujUzytkownikow;
        private System.Windows.Forms.Button dodajUzytkownikow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wyszukajText;
        private System.Windows.Forms.Button ForceRecoverPass;
    }
}
