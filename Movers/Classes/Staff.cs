using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers
{
    public class Staff
    {
        string firstName, secondName, jobTitle, partOrFullTime;
        int staffID;
        public Staff()
        {

        }

        public Staff(string fName, string sName, string jTitle, string pORf, int sID)
        {
            FirstName = fName;
            SecondName = sName;
            JobTitle = jTitle;
            PartOrFullTime = pORf;
            StaffID = sID;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public string PartOrFullTime
        {
            get { return partOrFullTime; }
            set { partOrFullTime = value; }
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
    }
}
