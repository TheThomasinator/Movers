using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers
{
    class Van
    {
        string size, registrationPlate, make;
        int vanID;

        public Van()
        {

        }

        public Van(string size, string regPlate, string make, int vanId)
        {
            Make = make;
            Size = size;
            RegistrationPlate = regPlate;
            VanID = vanId;
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public string RegistrationPlate
        {
            get { return registrationPlate; }
            set { registrationPlate = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int VanID
        {
            get { return vanID; }
            set { vanID = value; }
        }

    }
}
