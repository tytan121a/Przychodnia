namespace przychodnia3
{
    partial class ForgotList
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
            this.Cofnij = new System.Windows.Forms.Button();
            this.listaUzytkownikow = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).BeginInit();
            this.SuspendLayout();
            // 
            // Cofnij
            // 
            this.Cofnij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cofnij.Location = new System.Drawing.Point(758, 649);
            this.Cofnij.Name = "Cofnij";
            this.Cofnij.Size = new System.Drawing.Size(125, 34);
            this.Cofnij.TabIndex = 13;
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
            this.listaUzytkownikow.Location = new System.Drawing.Point(25, 145);
            this.listaUzytkownikow.Margin = new System.Windows.Forms.Padding(4);
            this.listaUzytkownikow.MultiSelect = false;
            this.listaUzytkownikow.Name = "listaUzytkownikow";
            this.listaUzytkownikow.ReadOnly = true;
            this.listaUzytkownikow.RowHeadersVisible = false;
            this.listaUzytkownikow.RowHeadersWidth = 51;
            this.listaUzytkownikow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUzytkownikow.Size = new System.Drawing.Size(858, 435);
            this.listaUzytkownikow.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(910, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista zapomnianych użytkowników";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ForgotList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 695);
            this.Controls.Add(this.Cofnij);
            this.Controls.Add(this.listaUzytkownikow);
            this.Controls.Add(this.label1);
            this.Name = "ForgotList";
            this.Text = "ForgotList";
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cofnij;
        private System.Windows.Forms.DataGridView listaUzytkownikow;
        private System.Windows.Forms.Label label1;
    }
}