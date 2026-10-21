using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers
{
    public class Job
    {
        int jobID, addressID;
        string jobType;
        DateTime dateOfJob;

        public Job()
        {

        }

        public Job(int jID, int aID, string type, DateTime date)
        {
            JobID = jID;
            AddressID = aID;
            JobType = type;
            DateOfJob = date;
        }

        public int JobID
        {
            set { jobID = value; }
            get { return jobID; }
        }

        public int AddressID
        {
            set { addressID = value; }
            get { return addressID; }
        }

        public string JobType
        {
            set { jobType = value; }
            get { return jobType; }
        }

        public DateTime DateOfJob
        {
            set { dateOfJob = value; }
            get { return dateOfJob; }
        }
    }
}
