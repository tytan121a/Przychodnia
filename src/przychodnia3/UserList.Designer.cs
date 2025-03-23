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
            this.listaUzytkownikow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).BeginInit();
            this.SuspendLayout();
            // 
            // wyszukajText
            // 
            this.wyszukajText.Location = new System.Drawing.Point(99, 71);
            this.wyszukajText.Margin = new System.Windows.Forms.Padding(2);
            this.wyszukajText.Name = "wyszukajText";
            this.wyszukajText.Size = new System.Drawing.Size(306, 20);
            this.wyszukajText.TabIndex = 0;
            this.wyszukajText.TextChanged += new System.EventHandler(this.wyszukajText_TextChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista użytkowników";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dodajUzytkownikow
            // 
            this.dodajUzytkownikow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dodajUzytkownikow.Location = new System.Drawing.Point(432, 56);
            this.dodajUzytkownikow.Margin = new System.Windows.Forms.Padding(2);
            this.dodajUzytkownikow.Name = "dodajUzytkownikow";
            this.dodajUzytkownikow.Size = new System.Drawing.Size(94, 38);
            this.dodajUzytkownikow.TabIndex = 2;
            this.dodajUzytkownikow.Text = "Dodaj użytkoników";
            this.dodajUzytkownikow.UseVisualStyleBackColor = true;
            this.dodajUzytkownikow.Click += new System.EventHandler(this.button1_Click);
            // 
            // edytujUzytkownikow
            // 
            this.edytujUzytkownikow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edytujUzytkownikow.Location = new System.Drawing.Point(532, 56);
            this.edytujUzytkownikow.Margin = new System.Windows.Forms.Padding(2);
            this.edytujUzytkownikow.Name = "edytujUzytkownikow";
            this.edytujUzytkownikow.Size = new System.Drawing.Size(94, 38);
            this.edytujUzytkownikow.TabIndex = 3;
            this.edytujUzytkownikow.Text = "Edytuj użytkoników";
            this.edytujUzytkownikow.UseVisualStyleBackColor = true;
            this.edytujUzytkownikow.Click += new System.EventHandler(this.edytujUzytkownikow_Click);
            // 
            // wyszukajButton
            // 
            this.wyszukajButton.Location = new System.Drawing.Point(18, 66);
            this.wyszukajButton.Margin = new System.Windows.Forms.Padding(2);
            this.wyszukajButton.Name = "wyszukajButton";
            this.wyszukajButton.Size = new System.Drawing.Size(77, 28);
            this.wyszukajButton.TabIndex = 4;
            this.wyszukajButton.Text = "Wyszukaj";
            this.wyszukajButton.UseVisualStyleBackColor = true;
            this.wyszukajButton.Click += new System.EventHandler(this.wyszukajButton_Click);
            // 
            // listaUzytkownikow
            // 
            this.listaUzytkownikow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaUzytkownikow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaUzytkownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUzytkownikow.Location = new System.Drawing.Point(19, 110);
            this.listaUzytkownikow.MultiSelect = false;
            this.listaUzytkownikow.Name = "listaUzytkownikow";
            this.listaUzytkownikow.RowHeadersVisible = false;
            this.listaUzytkownikow.RowHeadersWidth = 51;
            this.listaUzytkownikow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUzytkownikow.Size = new System.Drawing.Size(625, 466);
            this.listaUzytkownikow.TabIndex = 5;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 588);
            this.Controls.Add(this.listaUzytkownikow);
            this.Controls.Add(this.wyszukajButton);
            this.Controls.Add(this.edytujUzytkownikow);
            this.Controls.Add(this.dodajUzytkownikow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wyszukajText);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserList";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wyszukajText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodajUzytkownikow;
        private System.Windows.Forms.Button edytujUzytkownikow;
        private System.Windows.Forms.Button wyszukajButton;
        private System.Windows.Forms.DataGridView listaUzytkownikow;
    }
}

