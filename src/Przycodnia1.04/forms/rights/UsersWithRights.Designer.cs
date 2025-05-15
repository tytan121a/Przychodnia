namespace Przychodnia.forms
{
    partial class UsersWithRights
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
            this.title2 = new System.Windows.Forms.Label();
            this.Cofnij = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listaUzytkownikow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).BeginInit();
            this.SuspendLayout();
            // 
            // title2
            // 
            this.title2.Dock = System.Windows.Forms.DockStyle.Top;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title2.Location = new System.Drawing.Point(0, 66);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(909, 38);
            this.title2.TabIndex = 20;
            this.title2.Text = "uprawnienie";
            this.title2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cofnij
            // 
            this.Cofnij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cofnij.Location = new System.Drawing.Point(716, 527);
            this.Cofnij.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cofnij.Name = "Cofnij";
            this.Cofnij.Size = new System.Drawing.Size(125, 34);
            this.Cofnij.TabIndex = 19;
            this.Cofnij.Text = "Cofnij";
            this.Cofnij.UseVisualStyleBackColor = true;
            this.Cofnij.Click += new System.EventHandler(this.Cofnij_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(909, 66);
            this.label2.TabIndex = 18;
            this.label2.Text = "Użytkownicy uprawnienia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listaUzytkownikow
            // 
            this.listaUzytkownikow.AllowUserToAddRows = false;
            this.listaUzytkownikow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaUzytkownikow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaUzytkownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUzytkownikow.Location = new System.Drawing.Point(16, 122);
            this.listaUzytkownikow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaUzytkownikow.MultiSelect = false;
            this.listaUzytkownikow.Name = "listaUzytkownikow";
            this.listaUzytkownikow.ReadOnly = true;
            this.listaUzytkownikow.RowHeadersVisible = false;
            this.listaUzytkownikow.RowHeadersWidth = 51;
            this.listaUzytkownikow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUzytkownikow.Size = new System.Drawing.Size(825, 387);
            this.listaUzytkownikow.TabIndex = 17;
            // 
            // UsersWithRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.title2);
            this.Controls.Add(this.Cofnij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaUzytkownikow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UsersWithRights";
            this.Size = new System.Drawing.Size(909, 595);
            this.Load += new System.EventHandler(this.UsersWithRights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Button Cofnij;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listaUzytkownikow;
    }
}
