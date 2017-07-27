using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Models.CreditCards
{
    public class Visa : CreditCard
    {
        public Visa()
        {
            InterestRate = 10;
        }        
    }
}
