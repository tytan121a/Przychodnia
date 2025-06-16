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
            this.ForgotUsers = new System.Windows.Forms.Button();
            this.UserDataButton = new System.Windows.Forms.Button();
            this.UsersList = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.editUsers = new System.Windows.Forms.Button();
            this.addUsers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.ForceRecoverPassButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // ForgotUsers
            // 
            this.ForgotUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ForgotUsers.Location = new System.Drawing.Point(53, 666);
            this.ForgotUsers.Margin = new System.Windows.Forms.Padding(4);
            this.ForgotUsers.Name = "ForgotUsers";
            this.ForgotUsers.Size = new System.Drawing.Size(233, 42);
            this.ForgotUsers.TabIndex = 16;
            this.ForgotUsers.Text = "Zapomniani użytkownicy";
            this.ForgotUsers.UseVisualStyleBackColor = true;
            this.ForgotUsers.Click += new System.EventHandler(this.ZapomnianiUzytkownicy_Click);
            // 
            // UserDataButton
            // 
            this.UserDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UserDataButton.Location = new System.Drawing.Point(852, 666);
            this.UserDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.UserDataButton.Name = "UserDataButton";
            this.UserDataButton.Size = new System.Drawing.Size(167, 42);
            this.UserDataButton.TabIndex = 15;
            this.UserDataButton.Text = "Podgląd";
            this.UserDataButton.UseVisualStyleBackColor = true;
            this.UserDataButton.Click += new System.EventHandler(this.Podglad_Click);
            // 
            // UsersList
            // 
            this.UsersList.AllowUserToAddRows = false;
            this.UsersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersList.Location = new System.Drawing.Point(53, 146);
            this.UsersList.Margin = new System.Windows.Forms.Padding(5);
            this.UsersList.MultiSelect = false;
            this.UsersList.Name = "UsersList";
            this.UsersList.ReadOnly = true;
            this.UsersList.RowHeadersVisible = false;
            this.UsersList.RowHeadersWidth = 51;
            this.UsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersList.Size = new System.Drawing.Size(965, 511);
            this.UsersList.TabIndex = 18;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(53, 96);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(137, 42);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Wyszukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.wyszukajButton_Click);
            // 
            // editUsers
            // 
            this.editUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editUsers.Location = new System.Drawing.Point(852, 94);
            this.editUsers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.editUsers.Name = "editUsers";
            this.editUsers.Size = new System.Drawing.Size(167, 41);
            this.editUsers.TabIndex = 13;
            this.editUsers.Text = "Edytuj użytkoników";
            this.editUsers.UseVisualStyleBackColor = true;
            this.editUsers.Click += new System.EventHandler(this.edytujUzytkownikow_Click);
            // 
            // addUsers
            // 
            this.addUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUsers.Location = new System.Drawing.Point(677, 94);
            this.addUsers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addUsers.Name = "addUsers";
            this.addUsers.Size = new System.Drawing.Size(167, 41);
            this.addUsers.TabIndex = 12;
            this.addUsers.Text = "Dodaj użytkoników";
            this.addUsers.UseVisualStyleBackColor = true;
            this.addUsers.Click += new System.EventHandler(this.dodajUzytkownikow_Click);
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
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(197, 103);
            this.searchText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(472, 22);
            this.searchText.TabIndex = 10;
            // 
            // ForceRecoverPassButton
            // 
            this.ForceRecoverPassButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ForceRecoverPassButton.Location = new System.Drawing.Point(708, 665);
            this.ForceRecoverPassButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ForceRecoverPassButton.Name = "ForceRecoverPassButton";
            this.ForceRecoverPassButton.Size = new System.Drawing.Size(137, 43);
            this.ForceRecoverPassButton.TabIndex = 19;
            this.ForceRecoverPassButton.Text = "Wymuś odzyskanie";
            this.ForceRecoverPassButton.UseVisualStyleBackColor = true;
            this.ForceRecoverPassButton.Click += new System.EventHandler(this.ForceRecoverPass_Click);
            // 
            // UsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ForceRecoverPassButton);
            this.Controls.Add(this.ForgotUsers);
            this.Controls.Add(this.UserDataButton);
            this.Controls.Add(this.UsersList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.editUsers);
            this.Controls.Add(this.addUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersControl";
            this.Size = new System.Drawing.Size(1092, 736);
            ((System.ComponentModel.ISupportInitialize)(this.UsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ForgotUsers;
        private System.Windows.Forms.Button UserDataButton;
        private System.Windows.Forms.DataGridView UsersList;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button editUsers;
        private System.Windows.Forms.Button addUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button ForceRecoverPassButton;
    }
}
