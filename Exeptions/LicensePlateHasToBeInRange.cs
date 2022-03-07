using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave.Exeptions
{
    public class LicensePlateHasToBeInRange : Exception
    {
        public string LicensePlate { get; set; }

        public LicensePlateHasToBeInRange(string message, string plate) : base(message)
        {
            LicensePlate = plate;
        }
    }
}
