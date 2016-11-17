using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderBU
{
    public class Job
    {
        private int jobID;
        private string jobDescrption;
        private string sourceOfJob;
        private decimal salary;
        private string status;
        private int contactID;
        private string notes;

        public Job()
        { 
        }



        public int JobID
{
	get
	{
		return jobID;
	}
	set
	{
		 jobID = value;
	}
}

        public string JobDescription 
{
	get
	{
		return jobDescrption;
	}
	set
	{
		jobDescrption = value;
	}
}

        public string SourceOfJob
{
	get
	{
		return sourceOfJob;
	}
	set
	{
		 sourceOfJob = value;
	}
}

        public decimal Salary
{
	get
	{
		return salary;
	}
	set
	{
		salary = value;
	}
}

        public string Status  
{
	get
	{
		return status;
	}
	set
	{
		 status = value;
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
