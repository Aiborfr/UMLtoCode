using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtoCode
{
    public class Investing : Account
    {
        public float Interest { get; set; }

        public Investing(string iban, float amount, Customer customer, float interest)
            : base(iban, amount, customer)
        {
            Interest = interest;
        }

        public bool ApplyInterest()
        {
            try
            {
                float interestAmount = Amount * (Interest / 100);
                Transaction($"Interest ({Interest}%)", interestAmount);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }        
    }
}

