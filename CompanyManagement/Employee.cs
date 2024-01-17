using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    public class Employee : Person
    {
        public string ID { get; set; }

        override
        public string ToString()
        {
            return "ID: " + ID + " Name: " + Name + " Address: " + Address + " County: " + County + " Age: " + Age.ToString() +
                " Phone: " + Phone + " Email: " + Email;
        }
    }
}
