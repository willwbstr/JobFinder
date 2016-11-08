using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    public class Contact
    {
        private string contactID;
        private string contactLastName;
        private string contactFirstName;
        private int businessID;
        private string email;
        private string methodOfContact;
        private string notes;

        public Contact()
        {  
        }

        public string ContactID
        {
            get
            {
                return contactID;
            }
            set
            {
                contactID = value;
            }
        }

        public string ContactLastName
        {
            get
            {
                return contactLastName;
            }
            set
            {
                contactLastName = value;
            }
        }

        public string ContactFirstName
        {
            get
            {
                return contactFirstName;
            }
            set
            {
                contactFirstName = value;
            }
        }

        public int BusinessID
        {
            get
            {
                return businessID;
            }
            set
            {
                businessID = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string MethodOfContact
        {
            get
            {
                return methodOfContact;
            }
            set
            {
                methodOfContact = value;
            }
        }
    }
}

