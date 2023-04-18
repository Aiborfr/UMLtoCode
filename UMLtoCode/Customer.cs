using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtoCode
{
    public class Customer : Person
    {
        public DateTime Registration;
        private int creditScore;

        public Customer(int id, string name, string phone, string email, DateTime dateTime, int v) : base(id, name, phone, email)
        {
        }

        public int CreditScore
        {
            get { return creditScore; }
            set { creditScore = value; }
        }

        public Address Address { get; internal set; }
    }

}
