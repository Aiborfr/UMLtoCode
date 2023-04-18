using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtoCode
{
    public class Account
    {
        public string IBAN;
        private float amount;
        private Customer customer;

        public Account(string iban1, Customer customer, string iban)
        {
            this.customer = customer;
            IBAN = iban;
        }

        public Account(string iban, float amount, Customer customer)
        {
            IBAN = iban;
            this.amount = amount;
            this.customer = customer;
        }

        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public bool Transaction(string transactionType, float interestAmount)
        {            
            return true; 
        }
        
    }
}
