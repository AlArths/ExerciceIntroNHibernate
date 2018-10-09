using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domain;
using DAL;

namespace ProspectApp
{
    public partial class MainForm : Form
    {
        private IProspectRepository _prospectRepository;

        public MainForm(IProspectRepository prospectRepository)
        {
            InitializeComponent();

            _prospectRepository = prospectRepository;

            RefreshProspectListView();
        }

        private void prospectLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prospectLB.SelectedItem != null)
            {
                // Display Prospect details
                Prospect selectedProspect = (Prospect)prospectLB.SelectedItem;
                lastNameTB.Text = selectedProspect.LastName;
                firstNameTB.Text = selectedProspect.FirstName;
                emailTB.Text = selectedProspect.Email;
                lastContactDTP.Value = selectedProspect.LastContact;
                notesTB.Text = selectedProspect.Notes;
            }
        }

        private void addProspectBtn_Click(object sender, EventArgs e)
        {
            ProspectForm prospectForm = new ProspectForm();
            if (prospectForm.ShowDialog() == DialogResult.OK)
            {
                string lastName = prospectForm.LastName;
                string firstName = prospectForm.FirstName;
                string email = prospectForm.Email;
                DateTime lastContact = prospectForm.LastContact;
                string notes = prospectForm.Notes;

                // Save the new prospect
                Prospect newProspect = new Prospect(lastName, firstName, email, lastContact, notes);
                _prospectRepository.Save(newProspect);

                RefreshProspectListView();
            }
        }

        private void RefreshProspectListView()
        {
            prospectLB.DataSource = null;
            // Lie la liste et la vue des propects
            List<Prospect> prospects = _prospectRepository.GetAll();
            prospectLB.DataSource = prospects;
            if (prospects.Count > 0)
                prospectLB.SelectedIndex = 0; // Sélectionne le 1er prospect
        }
    }
}
