namespace przychodnia3
{
    partial class RightsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listaUprawnień = new System.Windows.Forms.DataGridView();
            this.Cofnij = new System.Windows.Forms.Button();
            this.Zarzadzaj = new System.Windows.Forms.Button();
            this.Przegląd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaUprawnień)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(910, 66);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lista  uprawnień";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listaUprawnień
            // 
            this.listaUprawnień.AllowUserToAddRows = false;
            this.listaUprawnień.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaUprawnień.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaUprawnień.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUprawnień.Location = new System.Drawing.Point(26, 130);
            this.listaUprawnień.Margin = new System.Windows.Forms.Padding(4);
            this.listaUprawnień.MultiSelect = false;
            this.listaUprawnień.Name = "listaUprawnień";
            this.listaUprawnień.ReadOnly = true;
            this.listaUprawnień.RowHeadersVisible = false;
            this.listaUprawnień.RowHeadersWidth = 51;
            this.listaUprawnień.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUprawnień.Size = new System.Drawing.Size(858, 373);
            this.listaUprawnień.TabIndex = 13;
            // 
            // Cofnij
            // 
            this.Cofnij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cofnij.Location = new System.Drawing.Point(773, 543);
            this.Cofnij.Name = "Cofnij";
            this.Cofnij.Size = new System.Drawing.Size(125, 34);
            this.Cofnij.TabIndex = 14;
            this.Cofnij.Text = "Cofnij";
            this.Cofnij.UseVisualStyleBackColor = true;
            this.Cofnij.Click += new System.EventHandler(this.Cofnij_Click_1);
            // 
            // Zarzadzaj
            // 
            this.Zarzadzaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Zarzadzaj.Location = new System.Drawing.Point(602, 543);
            this.Zarzadzaj.Name = "Zarzadzaj";
            this.Zarzadzaj.Size = new System.Drawing.Size(165, 34);
            this.Zarzadzaj.TabIndex = 15;
            this.Zarzadzaj.Text = "Zarządzaj uprawnieniami";
            this.Zarzadzaj.UseVisualStyleBackColor = true;
            this.Zarzadzaj.Click += new System.EventHandler(this.Zarzadzaj_Click);
            // 
            // Przegląd
            // 
            this.Przegląd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Przegląd.Location = new System.Drawing.Point(12, 543);
            this.Przegląd.Name = "Przegląd";
            this.Przegląd.Size = new System.Drawing.Size(165, 34);
            this.Przegląd.TabIndex = 16;
            this.Przegląd.Text = "Przegląd użytkowników";
            this.Przegląd.UseVisualStyleBackColor = true;
            this.Przegląd.Click += new System.EventHandler(this.Przegląd_Click);
            // 
            // RightsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 589);
            this.Controls.Add(this.Przegląd);
            this.Controls.Add(this.Zarzadzaj);
            this.Controls.Add(this.Cofnij);
            this.Controls.Add(this.listaUprawnień);
            this.Controls.Add(this.label1);
            this.Name = "RightsList";
            this.Text = "RightsList";
            ((System.ComponentModel.ISupportInitialize)(this.listaUprawnień)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listaUprawnień;
        private System.Windows.Forms.Button Cofnij;
        private System.Windows.Forms.Button Zarzadzaj;
        private System.Windows.Forms.Button Przegląd;
    }
}