namespace ProspectApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.prospectLB = new System.Windows.Forms.ListBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.lastContactLBl = new System.Windows.Forms.Label();
            this.lastContactDTP = new System.Windows.Forms.DateTimePicker();
            this.notesLbl = new System.Windows.Forms.Label();
            this.notesTB = new System.Windows.Forms.TextBox();
            this.addProspectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prospectLB
            // 
            this.prospectLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.prospectLB.FormattingEnabled = true;
            this.prospectLB.Location = new System.Drawing.Point(0, 0);
            this.prospectLB.Name = "prospectLB";
            this.prospectLB.Size = new System.Drawing.Size(120, 334);
            this.prospectLB.Sorted = true;
            this.prospectLB.TabIndex = 0;
            this.prospectLB.SelectedIndexChanged += new System.EventHandler(this.prospectLB_SelectedIndexChanged);
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.Location = new System.Drawing.Point(140, 24);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(84, 23);
            this.lastNameLbl.TabIndex = 1;
            this.lastNameLbl.Text = "Nom :";
            this.lastNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTB.Enabled = false;
            this.lastNameTB.Location = new System.Drawing.Point(230, 26);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(200, 20);
            this.lastNameTB.TabIndex = 2;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTB.Enabled = false;
            this.firstNameTB.Location = new System.Drawing.Point(230, 62);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(200, 20);
            this.firstNameTB.TabIndex = 4;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.Location = new System.Drawing.Point(140, 60);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(84, 23);
            this.firstNameLbl.TabIndex = 3;
            this.firstNameLbl.Text = "Prénom :";
            this.firstNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTB
            // 
            this.emailTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTB.Enabled = false;
            this.emailTB.Location = new System.Drawing.Point(230, 100);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(200, 20);
            this.emailTB.TabIndex = 6;
            // 
            // emailLbl
            // 
            this.emailLbl.Location = new System.Drawing.Point(140, 98);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(84, 23);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Courriel :";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastContactLBl
            // 
            this.lastContactLBl.Location = new System.Drawing.Point(126, 137);
            this.lastContactLBl.Name = "lastContactLBl";
            this.lastContactLBl.Size = new System.Drawing.Size(98, 23);
            this.lastContactLBl.TabIndex = 7;
            this.lastContactLBl.Text = "Dernier contact :";
            this.lastContactLBl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastContactDTP
            // 
            this.lastContactDTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastContactDTP.Enabled = false;
            this.lastContactDTP.Location = new System.Drawing.Point(230, 140);
            this.lastContactDTP.Name = "lastContactDTP";
            this.lastContactDTP.Size = new System.Drawing.Size(200, 20);
            this.lastContactDTP.TabIndex = 8;
            // 
            // notesLbl
            // 
            this.notesLbl.Location = new System.Drawing.Point(126, 174);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(98, 23);
            this.notesLbl.TabIndex = 9;
            this.notesLbl.Text = "Notes :";
            this.notesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notesTB
            // 
            this.notesTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTB.Enabled = false;
            this.notesTB.Location = new System.Drawing.Point(230, 177);
            this.notesTB.Multiline = true;
            this.notesTB.Name = "notesTB";
            this.notesTB.Size = new System.Drawing.Size(200, 99);
            this.notesTB.TabIndex = 10;
            // 
            // addProspectBtn
            // 
            this.addProspectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addProspectBtn.Location = new System.Drawing.Point(143, 295);
            this.addProspectBtn.Name = "addProspectBtn";
            this.addProspectBtn.Size = new System.Drawing.Size(29, 23);
            this.addProspectBtn.TabIndex = 11;
            this.addProspectBtn.Text = "+";
            this.addProspectBtn.UseVisualStyleBackColor = true;
            this.addProspectBtn.Click += new System.EventHandler(this.addProspectBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 334);
            this.Controls.Add(this.addProspectBtn);
            this.Controls.Add(this.notesTB);
            this.Controls.Add(this.notesLbl);
            this.Controls.Add(this.lastContactDTP);
            this.Controls.Add(this.lastContactLBl);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.prospectLB);
            this.Name = "MainForm";
            this.Text = "Gestion des prospects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox prospectLB;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label lastContactLBl;
        private System.Windows.Forms.DateTimePicker lastContactDTP;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.TextBox notesTB;
        private System.Windows.Forms.Button addProspectBtn;
    }
}

