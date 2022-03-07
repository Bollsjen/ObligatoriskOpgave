using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave.Exeptions
{
    public class ModelNotLongEnough : Exception
    {
        public string Model { get; set; }

        public ModelNotLongEnough(string message, string model) : base(message)
        {
            Model = model;
        }
    }
}
