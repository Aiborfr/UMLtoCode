using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtoCode
{
    public class Savings : Account
    {
        public float ProtectedAmount { get; set; }

        public Savings(string iban, float amount, Customer customer, float protectedAmount)
            : base(iban, amount, customer)
        {
            ProtectedAmount = protectedAmount;
        }

        public bool LiberateSavings(float amount)
        {
            try
            {
                if (amount <= ProtectedAmount)
                {
                    throw new Exception("Cannot liberate protected amount");
                }

                if (amount > Amount)
                {
                    throw new Exception("Not enough funds to liberate savings");
                }

                Transaction("Liberate Savings", amount);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
