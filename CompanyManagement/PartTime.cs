using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement
{
    public class PartTime : Employee
    {
        public int NumOfHours { get; set; }
        public PartTime(
            string ID,
            string firstname,
            string surname,
            string address,
            string county,
            DateTime DOB,
            string email,
            string phone,
            int numOfHours)
        {
            this.ID = ID;
            this.FirstName = firstname;
            this.Surname = surname;
            this.Address = address;
            this.County = county;
            this.DOB = DOB;
            this.Email = email;
            this.Phone = phone;
            this.NumOfHours = numOfHours;
            this.Name = firstname + surname;
        }
        override
        public string ToString()
        {
            return base.ToString() + " Number of hours: " + NumOfHours.ToString();
        }
    }
}
