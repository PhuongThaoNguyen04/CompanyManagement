using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    public class Manager : Employee
    {
        public float Bonus { get; set; }

        public Manager(
            string ID,
            string firstname,
            string surname,
            string address,
            string county,
            DateTime DOB,
            string email,
            string phone,
            float bonus)
        {
            this.ID = ID;
            this.FirstName = firstname;
            this.Surname = surname;
            this.Address = address;
            this.County = county;
            this.DOB = DOB;
            this.Email = email;
            this.Phone = phone;
            this.Bonus = bonus;
            this.Name = firstname + surname;
        }

        override
        public string ToString()
        {
            return base.ToString() + " Bonus: " + Bonus.ToString();
        }
    }
}
