namespace Przychodnia.forms
{
    partial class ManageRights
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
            this.role = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.Decline = new System.Windows.Forms.Button();
            this.Id10 = new System.Windows.Forms.CheckBox();
            this.Id9 = new System.Windows.Forms.CheckBox();
            this.Id8 = new System.Windows.Forms.CheckBox();
            this.Id7 = new System.Windows.Forms.CheckBox();
            this.Id6 = new System.Windows.Forms.CheckBox();
            this.Id5 = new System.Windows.Forms.CheckBox();
            this.Id4 = new System.Windows.Forms.CheckBox();
            this.Id3 = new System.Windows.Forms.CheckBox();
            this.Id2 = new System.Windows.Forms.CheckBox();
            this.Id1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // role
            // 
            this.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.role.FormattingEnabled = true;
            this.role.Location = new System.Drawing.Point(110, 113);
            this.role.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(181, 28);
            this.role.TabIndex = 68;
            this.role.SelectedIndexChanged += new System.EventHandler(this.rola_SelectedIndexChanged);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(454, 467);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(125, 34);
            this.Save.TabIndex = 67;
            this.Save.Text = "Zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // Decline
            // 
            this.Decline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Decline.Location = new System.Drawing.Point(584, 467);
            this.Decline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Decline.Name = "Decline";
            this.Decline.Size = new System.Drawing.Size(125, 34);
            this.Decline.TabIndex = 66;
            this.Decline.Text = "Anuluj";
            this.Decline.UseVisualStyleBackColor = true;
            this.Decline.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // Id10
            // 
            this.Id10.AutoSize = true;
            this.Id10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id10.Location = new System.Drawing.Point(314, 433);
            this.Id10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Id10.Name = "Id10";
            this.Id10.Size = new System.Drawing.Size(180, 24);
            this.Id10.TabIndex = 65;
            this.Id10.Text = "ShowUsersWithRight";
            this.Id10.UseVisualStyleBackColor = true;
            // 
            // Id9
            // 
            this.Id9.AutoSize = true;
            this.Id9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id9.Location = new System.Drawing.Point(314, 398);
            this.Id9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Id9.Name = "Id9";
            this.Id9.Size = new System.Drawing.Size(114, 24);
            this.Id9.TabIndex = 64;
            this.Id9.Text = "ShowRights";
            this.Id9.UseVisualStyleBackColor = true;
            // 
            // Id8
            // 
            this.Id8.AutoSize = true;
            this.Id8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id8.Location = new System.Drawing.Point(314, 363);
            this.Id8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Id8.Name = "Id8";
            this.Id8.Size = new System.Drawing.Size(107, 24);
            this.Id8.TabIndex = 63;
            this.Id8.Text = "GrantRight";
            this.Id8.UseVisualStyleBackColor = true;
            // 
            // Id7
            // 
            this.Id7.AutoSize = true;
            this.Id7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id7.Location = new System.Drawing.Point(314, 327);
            this.Id7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Id7.Name = "Id7";
            this.Id7.Size = new System.Drawing.Size(137, 24);
            this.Id7.TabIndex = 62;
            this.Id7.Text = "ShowUserData";
            this.Id7.UseVisualStyleBackColor = true;
            // 
            // Id6
            // 
            this.Id6.AutoSize = true;
            this.Id6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id6.Location = new System.Drawing.Point(314, 293);
            this.Id6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Id6.Name = "Id6";
            this.Id6.Size = new System.Drawing.Size(126, 24);
            this.Id6.TabIndex = 61;
            this.Id6.Text = "SearchForgot";
            this.Id6.UseVisualStyleBackColor = true;
            // 
            // Id5
            // 
            this.Id5.AutoSize = true;
            this.Id5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id5.Location = new System.Drawing.Point(314, 259);
            this.Id5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Id5.Name = "Id5";
            this.Id5.Size = new System.Drawing.Size(75, 24);
            this.Id5.TabIndex = 60;
            this.Id5.Text = "Forget";
            this.Id5.UseVisualStyleBackColor = true;
            // 
            // Id4
            // 
            this.Id4.AutoSize = true;
            this.Id4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id4.Location = new System.Drawing.Point(314, 223);
            this.Id4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Id4.Name = "Id4";
            this.Id4.Size = new System.Drawing.Size(79, 24);
            this.Id4.TabIndex = 59;
            this.Id4.Text = "Search";
            this.Id4.UseVisualStyleBackColor = true;
            // 
            // Id3
            // 
            this.Id3.AutoSize = true;
            this.Id3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id3.Location = new System.Drawing.Point(314, 188);
            this.Id3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Id3.Name = "Id3";
            this.Id3.Size = new System.Drawing.Size(110, 24);
            this.Id3.TabIndex = 58;
            this.Id3.Text = "ShowUsers";
            this.Id3.UseVisualStyleBackColor = true;
            // 
            // Id2
            // 
            this.Id2.AutoSize = true;
            this.Id2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id2.Location = new System.Drawing.Point(314, 153);
            this.Id2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Id2.Name = "Id2";
            this.Id2.Size = new System.Drawing.Size(56, 24);
            this.Id2.TabIndex = 57;
            this.Id2.Text = "Edit";
            this.Id2.UseVisualStyleBackColor = true;
            // 
            // Id1
            // 
            this.Id1.AutoSize = true;
            this.Id1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Id1.Location = new System.Drawing.Point(314, 118);
            this.Id1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Id1.Name = "Id1";
            this.Id1.Size = new System.Drawing.Size(57, 24);
            this.Id1.TabIndex = 56;
            this.Id1.Text = "Add";
            this.Id1.UseVisualStyleBackColor = true;
            // 
            // ManageRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.role);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Decline);
            this.Controls.Add(this.Id10);
            this.Controls.Add(this.Id9);
            this.Controls.Add(this.Id8);
            this.Controls.Add(this.Id7);
            this.Controls.Add(this.Id6);
            this.Controls.Add(this.Id5);
            this.Controls.Add(this.Id4);
            this.Controls.Add(this.Id3);
            this.Controls.Add(this.Id2);
            this.Controls.Add(this.Id1);
            this.Name = "ManageRights";
            this.Size = new System.Drawing.Size(819, 598);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Decline;
        private System.Windows.Forms.CheckBox Id10;
        private System.Windows.Forms.CheckBox Id9;
        private System.Windows.Forms.CheckBox Id8;
        private System.Windows.Forms.CheckBox Id7;
        private System.Windows.Forms.CheckBox Id6;
        private System.Windows.Forms.CheckBox Id5;
        private System.Windows.Forms.CheckBox Id4;
        private System.Windows.Forms.CheckBox Id3;
        private System.Windows.Forms.CheckBox Id2;
        private System.Windows.Forms.CheckBox Id1;
    }
}
