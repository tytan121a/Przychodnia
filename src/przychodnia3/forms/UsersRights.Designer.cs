namespace przychodnia3.forms
{
    partial class UsersRights
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
            this.listaUzytkownikow = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Cofnij = new System.Windows.Forms.Button();
            this.title2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).BeginInit();
            this.SuspendLayout();
            // 
            // listaUzytkownikow
            // 
            this.listaUzytkownikow.AllowUserToAddRows = false;
            this.listaUzytkownikow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaUzytkownikow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaUzytkownikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUzytkownikow.Location = new System.Drawing.Point(12, 111);
            this.listaUzytkownikow.MultiSelect = false;
            this.listaUzytkownikow.Name = "listaUzytkownikow";
            this.listaUzytkownikow.ReadOnly = true;
            this.listaUzytkownikow.RowHeadersVisible = false;
            this.listaUzytkownikow.RowHeadersWidth = 51;
            this.listaUzytkownikow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaUzytkownikow.Size = new System.Drawing.Size(651, 309);
            this.listaUzytkownikow.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(682, 54);
            this.label2.TabIndex = 9;
            this.label2.Text = "Użytkownicy uprawnienia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cofnij
            // 
            this.Cofnij.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cofnij.Location = new System.Drawing.Point(580, 444);
            this.Cofnij.Margin = new System.Windows.Forms.Padding(2);
            this.Cofnij.Name = "Cofnij";
            this.Cofnij.Size = new System.Drawing.Size(94, 28);
            this.Cofnij.TabIndex = 15;
            this.Cofnij.Text = "Cofnij";
            this.Cofnij.UseVisualStyleBackColor = true;
            this.Cofnij.Click += new System.EventHandler(this.Cofnij_Click);
            // 
            // title2
            // 
            this.title2.Dock = System.Windows.Forms.DockStyle.Top;
            this.title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title2.Location = new System.Drawing.Point(0, 54);
            this.title2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(682, 31);
            this.title2.TabIndex = 16;
            this.title2.Text = "uprawnienie";
            this.title2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UsersRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 481);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.Cofnij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaUzytkownikow);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UsersRights";
            this.Text = "UsersRights";
            ((System.ComponentModel.ISupportInitialize)(this.listaUzytkownikow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listaUzytkownikow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cofnij;
        private System.Windows.Forms.Label title2;
    }
}