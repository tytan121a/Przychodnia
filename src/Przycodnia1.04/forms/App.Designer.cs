namespace Przychodnia.forms
{
    partial class App
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.roleLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.PatientsButton = new System.Windows.Forms.Button();
            this.PermissionButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.roleLabel);
            this.panel1.Controls.Add(this.WelcomeLabel);
            this.panel1.Controls.Add(this.logOutButton);
            this.panel1.Controls.Add(this.PatientsButton);
            this.panel1.Controls.Add(this.PermissionButton);
            this.panel1.Controls.Add(this.UsersButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 743);
            this.panel1.TabIndex = 0;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roleLabel.Location = new System.Drawing.Point(15, 59);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(149, 28);
            this.roleLabel.TabIndex = 7;
            this.roleLabel.Text = "Twoja rola:  rola";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 10);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(206, 46);
            this.WelcomeLabel.TabIndex = 6;
            this.WelcomeLabel.Text = "Witaj, User!";
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logOutButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutButton.ForeColor = System.Drawing.Color.Beige;
            this.logOutButton.Location = new System.Drawing.Point(0, 690);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(368, 53);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Wyloguj";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // PatientsButton
            // 
            this.PatientsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientsButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PatientsButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.PatientsButton.FlatAppearance.BorderSize = 0;
            this.PatientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientsButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PatientsButton.ForeColor = System.Drawing.Color.Beige;
            this.PatientsButton.Location = new System.Drawing.Point(0, 396);
            this.PatientsButton.Margin = new System.Windows.Forms.Padding(4);
            this.PatientsButton.Name = "PatientsButton";
            this.PatientsButton.Size = new System.Drawing.Size(368, 53);
            this.PatientsButton.TabIndex = 4;
            this.PatientsButton.Text = "Pacjenci";
            this.PatientsButton.UseVisualStyleBackColor = false;
            // 
            // PermissionButton
            // 
            this.PermissionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PermissionButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PermissionButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.PermissionButton.FlatAppearance.BorderSize = 0;
            this.PermissionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PermissionButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PermissionButton.ForeColor = System.Drawing.Color.Beige;
            this.PermissionButton.Location = new System.Drawing.Point(0, 331);
            this.PermissionButton.Margin = new System.Windows.Forms.Padding(4);
            this.PermissionButton.Name = "PermissionButton";
            this.PermissionButton.Size = new System.Drawing.Size(368, 53);
            this.PermissionButton.TabIndex = 3;
            this.PermissionButton.Text = "Uprawnienia";
            this.PermissionButton.UseVisualStyleBackColor = false;
            this.PermissionButton.Click += new System.EventHandler(this.PermissionButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.UsersButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.UsersButton.FlatAppearance.BorderSize = 0;
            this.UsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsersButton.ForeColor = System.Drawing.Color.Beige;
            this.UsersButton.Location = new System.Drawing.Point(0, 266);
            this.UsersButton.Margin = new System.Windows.Forms.Padding(4);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(368, 53);
            this.UsersButton.TabIndex = 2;
            this.UsersButton.Text = "Użytkownicy";
            this.UsersButton.UseVisualStyleBackColor = false;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(369, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1129, 780);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(365, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1133, 784);
            this.panel2.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(365, 2);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1092, 736);
            this.mainPanel.TabIndex = 1;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1470, 738);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "App";
            this.Text = "App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button PatientsButton;
        private System.Windows.Forms.Button PermissionButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}