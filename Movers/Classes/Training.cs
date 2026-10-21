using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers
{
    class Training
    {
        int trainingID, duration;
        string trainingType;
        DateTime trainingDate;


        public Training()
        {

        }

        public Training(int tID, string type, DateTime tDate, int duration)
        {
            TrainingID = tID;
            TrainingType = type;
            TrainingDate = tDate;
            Duration = duration;
        }

        public int TrainingID
        {
            get { return trainingID; }
            set { trainingID = value; }
        }

        public string TrainingType
        {
            get { return trainingType; }
            set { trainingType = value; }
        }

        public DateTime TrainingDate
        {
            get { return trainingDate; }
            set { trainingDate = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
