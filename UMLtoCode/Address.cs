using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtoCode
{
    public struct Address
    {
        public string Street;
        public string City;
        public string State;
        public int PostalCode;
        public string Country;
        private string v1;
        private string v2;
        private string v3;
        private int v4;
        private string v5;

        public Address(string v1, string v2, string v3, int v4, string v5) : this()
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        public bool Validate()
        {            
            return true;
        }
    }

}
