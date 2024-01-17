using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    public class GeneralWorker : Employee
    {
        public float Salary { get; set; }
        public GeneralWorker(
            string ID,
            string firstname,
            string surname,
            string address,
            string county,
            DateTime DOB,
            string email,
            string phone,
            float salary)
        {
            this.ID = ID;
            this.FirstName = firstname;
            this.Surname = surname;
            this.Address = address;
            this.County = county;
            this.DOB = DOB;
            this.Email = email;
            this.Phone = phone;
            this.Salary = salary;
            this.Name = firstname + surname;
        }

        override
        public string ToString()
        {
            return base.ToString() + " Salary: " + Salary.ToString();
        }
    }
}
