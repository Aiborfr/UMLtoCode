using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtoCode
{
    public abstract class Person
    {        
        public int ID;
        public string Name;
        protected string Phone;
        public string Email;

        protected Person(int id, string name, string phone, string email)
        {
            ID = id;
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
    

}
