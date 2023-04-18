using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtoCode
{
    public struct Transaction
    {
        public string From;
        public string To;
        public float Amount;
        public DateTime Request;

        public Transaction(string from, string to, float amount, DateTime request)
        {
            From = from;
            To = to;
            Amount = amount;
            Request = request;
        }

        
    }


}
