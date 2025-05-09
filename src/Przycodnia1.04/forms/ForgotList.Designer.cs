namespace Przychodnia.forms
{
    partial class ForgotList
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
            this.Cofnij = new System.Windows.Forms.Button();
            this.listaUzytkownikow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).BeginInit();
            this.SuspendLayout();
            // 
            // Cofnij
            // 
            this.Cofnij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cofnij.Location = new System.Drawing.Point(773, 681);
            this.Cofnij.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cofnij.Name = "Cofnij";
            this.Cofnij.Size = new System.Drawing.Size(233, 34);
            this.Cofnij.TabIndex = 16;
            this.Cofnij.Text = "Cofnij";
            this.Cofnij.UseVisualStyleBackColor = true;
            this.Cofnij.Click += new System.EventHandler(this.Cofnij_Click);
            // 
            // listaUzytkownikow
            // 
            this.listaUzytkownikow.AllowUserToAddRows = false;
            this.listaUzytkownikow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaUzytkownikow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaUzytkownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUzytkownikow.Location = new System.Drawing.Point(41, 177);
            this.listaUzytkownikow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaUzytkownikow.MultiSelect = false;
            this.listaUzytkownikow.Name = "listaUzytkownikow";
            this.listaUzytkownikow.ReadOnly = true;
            this.listaUzytkownikow.RowHeadersVisible = false;
            this.listaUzytkownikow.RowHeadersWidth = 51;
            this.listaUzytkownikow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUzytkownikow.Size = new System.Drawing.Size(967, 434);
            this.listaUzytkownikow.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1031, 66);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lista zapomnianych użytkowników";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ForgotList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cofnij);
            this.Controls.Add(this.listaUzytkownikow);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ForgotList";
            this.Size = new System.Drawing.Size(1031, 747);
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cofnij;
        private System.Windows.Forms.DataGridView listaUzytkownikow;
        private System.Windows.Forms.Label label1;
    }
}
