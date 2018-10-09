using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// POCO class representing a propect (future client)
    /// </summary>
    public class Prospect
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public DateTime LastContact { get; set; }
        public string Notes { get; set; }

        public Prospect(string lastName, string firstName, string email, DateTime lastContact, string notes)
            : this(lastName, firstName, email, lastContact)
        {
            Notes = notes;
        }
        
        public Prospect(string lastName, string firstName, string email, DateTime lastContact)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            LastContact = lastContact;
        }

        public override string ToString()
        {
            return LastName + " " + FirstName;
        }
    }
}
