using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    public class Phone

    {
        private int phoneID;
        private string contactNumber = "";
        private string notes;
        private int contactID;

        public Phone()
        { 
        }

        public int PhoneID
{
	get
	{
		return phoneID;
	}
	set
	{
		 phoneID = value;
	}
}

        public string ContactNumber
{
	get
	{
		return contactNumber;
	}
	set
	{
		contactNumber = value;
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

        public int ContactID
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

    }
}
