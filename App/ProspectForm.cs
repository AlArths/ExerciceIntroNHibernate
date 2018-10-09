using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProspectApp
{
    public partial class ProspectForm : Form
    {
        public ProspectForm()
        {
            InitializeComponent();
        }

        public string LastName
        {
            get { return lastNameTB.Text; }
            set { lastNameTB.Text = value; }
        }

        public string FirstName
        {
            get { return firstNameTB.Text; }
            set { firstNameTB.Text = value; }
        }

        public string Email
        {
            get { return emailTB.Text; }
            set { emailTB.Text = value; }
        }

        public DateTime LastContact
        {
            get { return lastContactDTP.Value; }
            set { lastContactDTP.Value = value; }
        }

        public string Notes
        {
            get { return notesTB.Text; }
            set { notesTB.Text = value; }
        }
    }
}
