namespace ProspectApp
{
    partial class ProspectForm
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
            this.notesTB = new System.Windows.Forms.TextBox();
            this.notesLbl = new System.Windows.Forms.Label();
            this.lastContactDTP = new System.Windows.Forms.DateTimePicker();
            this.lastContactLBl = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notesTB
            // 
            this.notesTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTB.Location = new System.Drawing.Point(123, 163);
            this.notesTB.Multiline = true;
            this.notesTB.Name = "notesTB";
            this.notesTB.Size = new System.Drawing.Size(194, 112);
            this.notesTB.TabIndex = 20;
            // 
            // notesLbl
            // 
            this.notesLbl.Location = new System.Drawing.Point(19, 160);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(98, 23);
            this.notesLbl.TabIndex = 19;
            this.notesLbl.Text = "Notes :";
            this.notesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastContactDTP
            // 
            this.lastContactDTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastContactDTP.Location = new System.Drawing.Point(123, 126);
            this.lastContactDTP.Name = "lastContactDTP";
            this.lastContactDTP.Size = new System.Drawing.Size(194, 20);
            this.lastContactDTP.TabIndex = 18;
            // 
            // lastContactLBl
            // 
            this.lastContactLBl.Location = new System.Drawing.Point(19, 123);
            this.lastContactLBl.Name = "lastContactLBl";
            this.lastContactLBl.Size = new System.Drawing.Size(98, 23);
            this.lastContactLBl.TabIndex = 17;
            this.lastContactLBl.Text = "Dernier contact :";
            this.lastContactLBl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTB
            // 
            this.emailTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTB.Location = new System.Drawing.Point(123, 86);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(194, 20);
            this.emailTB.TabIndex = 16;
            // 
            // emailLbl
            // 
            this.emailLbl.Location = new System.Drawing.Point(33, 84);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(84, 23);
            this.emailLbl.TabIndex = 15;
            this.emailLbl.Text = "Courriel :";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTB.Location = new System.Drawing.Point(123, 48);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(194, 20);
            this.firstNameTB.TabIndex = 14;
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.Location = new System.Drawing.Point(33, 46);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(84, 23);
            this.firstNameLbl.TabIndex = 13;
            this.firstNameLbl.Text = "Prénom :";
            this.firstNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTB.Location = new System.Drawing.Point(123, 12);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(194, 20);
            this.lastNameTB.TabIndex = 12;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.Location = new System.Drawing.Point(33, 10);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(84, 23);
            this.lastNameLbl.TabIndex = 11;
            this.lastNameLbl.Text = "Nom :";
            this.lastNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(224, 293);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(92, 23);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Ajouter";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(123, 293);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(92, 23);
            this.cancelBtn.TabIndex = 22;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // ProspectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 328);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProspectForm";
            this.Text = "Nouveau prospect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notesTB;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.DateTimePicker lastContactDTP;
        private System.Windows.Forms.Label lastContactLBl;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}