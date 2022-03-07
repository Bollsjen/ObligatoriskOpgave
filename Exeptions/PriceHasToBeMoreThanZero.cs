using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave.Exeptions
{
    public class PriceHasToBeMoreThanZero : Exception
    {
        public double Price { get; set; }

        public PriceHasToBeMoreThanZero(string message, double price) : base(message)
        {
            Price = price;
        }
    }
}
