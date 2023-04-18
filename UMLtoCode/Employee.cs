using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtoCode
{
    public enum Department
    {
        Sales,
        Marketing,
        HR,
        Finance,
        IT,
        Operations
    }
    public class Employee : Person
    {
        public Department Department;
        private float salary;

        public Employee(int id, string name, string phone, string email, object humanResources1, object humanResources) : base(id, name, phone, email)
        {
        }

        public float Salary
        {
            get { return salary; }
            set { salary = value; }
        }
                
    }
}
