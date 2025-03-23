namespace przychodnia3
{
    partial class UserList
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
            this.wyszukajText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dodajUzytkownikow = new System.Windows.Forms.Button();
            this.edytujUzytkownikow = new System.Windows.Forms.Button();
            this.wyszukajButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wyszukajText
            // 
            this.wyszukajText.Location = new System.Drawing.Point(134, 157);
            this.wyszukajText.Name = "wyszukajText";
            this.wyszukajText.Size = new System.Drawing.Size(406, 22);
            this.wyszukajText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(243, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista użytkowników";
            // 
            // dodajUzytkownikow
            // 
            this.dodajUzytkownikow.Location = new System.Drawing.Point(647, 145);
            this.dodajUzytkownikow.Name = "dodajUzytkownikow";
            this.dodajUzytkownikow.Size = new System.Drawing.Size(126, 47);
            this.dodajUzytkownikow.TabIndex = 2;
            this.dodajUzytkownikow.Text = "Dodaj użytkoników";
            this.dodajUzytkownikow.UseVisualStyleBackColor = true;
            this.dodajUzytkownikow.Click += new System.EventHandler(this.button1_Click);
            // 
            // edytujUzytkownikow
            // 
            this.edytujUzytkownikow.Location = new System.Drawing.Point(780, 145);
            this.edytujUzytkownikow.Name = "edytujUzytkownikow";
            this.edytujUzytkownikow.Size = new System.Drawing.Size(126, 47);
            this.edytujUzytkownikow.TabIndex = 3;
            this.edytujUzytkownikow.Text = "Edytuj użytkoników";
            this.edytujUzytkownikow.UseVisualStyleBackColor = true;
            // 
            // wyszukajButton
            // 
            this.wyszukajButton.Location = new System.Drawing.Point(25, 151);
            this.wyszukajButton.Name = "wyszukajButton";
            this.wyszukajButton.Size = new System.Drawing.Size(103, 34);
            this.wyszukajButton.TabIndex = 4;
            this.wyszukajButton.Text = "Wyszukaj";
            this.wyszukajButton.UseVisualStyleBackColor = true;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(941, 736);
            this.Controls.Add(this.wyszukajButton);
            this.Controls.Add(this.edytujUzytkownikow);
            this.Controls.Add(this.dodajUzytkownikow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wyszukajText);
            this.Name = "UserList";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wyszukajText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajUzytkownikow;
        private System.Windows.Forms.Button edytujUzytkownikow;
        private System.Windows.Forms.Button wyszukajButton;
    }
}

