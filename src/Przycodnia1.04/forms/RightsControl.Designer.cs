namespace Przychodnia.forms
{
    partial class RightsControl
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
            this.UprawnieniaButton = new System.Windows.Forms.Button();
            this.UsersWithRightsButton = new System.Windows.Forms.Button();
            this.RightsDataTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RightsDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // UprawnieniaButton
            // 
            this.UprawnieniaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UprawnieniaButton.Location = new System.Drawing.Point(1147, 676);
            this.UprawnieniaButton.Margin = new System.Windows.Forms.Padding(4);
            this.UprawnieniaButton.Name = "UprawnieniaButton";
            this.UprawnieniaButton.Size = new System.Drawing.Size(179, 42);
            this.UprawnieniaButton.TabIndex = 26;
            this.UprawnieniaButton.Text = "Zarządzaj uprawnieniami";
            this.UprawnieniaButton.UseVisualStyleBackColor = true;
            this.UprawnieniaButton.Click += new System.EventHandler(this.UprawnieniaButton_Click);
            // 
            // UsersWithRightsButton
            // 
            this.UsersWithRightsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UsersWithRightsButton.Location = new System.Drawing.Point(53, 676);
            this.UsersWithRightsButton.Margin = new System.Windows.Forms.Padding(4);
            this.UsersWithRightsButton.Name = "UsersWithRightsButton";
            this.UsersWithRightsButton.Size = new System.Drawing.Size(233, 42);
            this.UsersWithRightsButton.TabIndex = 25;
            this.UsersWithRightsButton.Text = "Przeglądaj użytkownikow z zadanym uprawnieniem";
            this.UsersWithRightsButton.UseVisualStyleBackColor = true;
            this.UsersWithRightsButton.Click += new System.EventHandler(this.UsersWithRightsButton_Click);
            // 
            // RightsDataTable
            // 
            this.RightsDataTable.AllowUserToAddRows = false;
            this.RightsDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightsDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RightsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RightsDataTable.Location = new System.Drawing.Point(53, 160);
            this.RightsDataTable.Margin = new System.Windows.Forms.Padding(5);
            this.RightsDataTable.MultiSelect = false;
            this.RightsDataTable.Name = "RightsDataTable";
            this.RightsDataTable.ReadOnly = true;
            this.RightsDataTable.RowHeadersVisible = false;
            this.RightsDataTable.RowHeadersWidth = 51;
            this.RightsDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RightsDataTable.Size = new System.Drawing.Size(1272, 507);
            this.RightsDataTable.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1396, 76);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lista uprawnien";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RightsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UprawnieniaButton);
            this.Controls.Add(this.UsersWithRightsButton);
            this.Controls.Add(this.RightsDataTable);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RightsControl";
            this.Size = new System.Drawing.Size(1396, 731);
            ((System.ComponentModel.ISupportInitialize)(this.RightsDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UprawnieniaButton;
        private System.Windows.Forms.Button UsersWithRightsButton;
        private System.Windows.Forms.DataGridView RightsDataTable;
        private System.Windows.Forms.Label label1;
    }
}
