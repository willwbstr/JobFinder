using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    public class Business
    {
        private int businessID;
        private string businessName;
        private string address;
        private string address2;
        private string city;
        private string state;
        private int zip;
        private string fax;
        private string businessPhone;
        private string email;
        private string website;
        private string notes;

        public Business()
        { 
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

        public string BusinessName
{
	get
	{
		return businessName;
	}
	set
	{
		 businessName = value;
	}
}

        public string Address
{
	get
	{
		return address;
	}
	set
	{
		 address = value;
	}
}

        public string Address2
{
	get
	{
		return address2;
	}
	set
	{
		address2 = value;
	}
}

        public string City
{
	get
	{
		return city;
	}
	set
	{
		 city = value;
	}
}

        public string State
{
	get
	{
		return state;
	}
	set
	{
		 state = value;
	}
}

        public int Zip
{
	get
	{
		return zip;
	}
	set
	{
		 zip = value;
	}
}

        public string Fax 
{
	get
	{
		return fax;
	}
	set
	{
		 fax = value;
	}
}

        public string BusinessPhone
{
	get
	{
		return businessPhone;
	}
	set
	{
		 businessPhone = value;
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

        public string Website
{
	get
	{
		return website;
	}
	set
	{
		 website = value;
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



    }
}
