using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers
{
    class Maintenance
    {
        int maintenanceID, vanID, duration;
        string maintenanceType, details;
        DateTime maintenanceDate;


        public Maintenance()
        {

        }

        public Maintenance(int mID, int vID, string type, DateTime mDate, int dur, string details)
        {
            MaintenanceID = mID;
            VanID = vID;
            MaintenanceType = type;
            maintenanceDate = mDate;
            Duration = dur;
            Details = details;
        }

        public int MaintenanceID
        {
            get { return maintenanceID; }
            set { maintenanceID = value; }
        }

        public int VanID
        {
            get { return vanID; }
            set { vanID = value; }
        }

        public string MaintenanceType
        {
            get { return maintenanceType; }
            set { maintenanceType = value; }
        }

        public DateTime MaintenanceDate
        {
            get { return maintenanceDate; }
            set { maintenanceDate = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public string Details
        {
            get { return details; }
            set { details = value; }
        }
    }
}
