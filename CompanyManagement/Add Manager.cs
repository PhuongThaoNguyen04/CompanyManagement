using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CompanyManagement
{
    public partial class AddForm : Form
    {
        enum County
        {
            Antrim,
            Armagh,
            Carlow,
            Cavan,
            Clare,
            Cork,
            Derry,
            Donegal,
            Down,
            Dublin,
            Fermanagh,
            Galway,
            Kerry,
            Kildare,
            Kilkenny,
            Laois,
            Leitrim,
            Limerick,
            Longford,
            Louth,
            Mayo,
            Meath,
            Monaghan,
            Offaly,
            Roscommon,
            Sligo,
            Tipperary,
            Tyrone,
            Waterford,
            Westmeath,
            Wexford,
            Wicklow
        }
        private bool isEditing;
        private List<Employee> employees;
        private DetailForm detailForm;
        private Type type;
        private Employee employee;

        public AddForm(DetailForm detailForm, bool isEditing)
        {
            InitializeComponent();
            this.detailForm = detailForm;
            this.type = detailForm.type;
            this.isEditing = isEditing;
            if (isEditing)
            {
                this.employee = detailForm.employee;
                txtNo.Text = this.employee.ID;
                txtNo.ReadOnly = true;
                txtFn.Text = this.employee.FirstName;
                txtSn.Text = this.employee.Surname;
                dtp.Value = this.employee.DOB;
                txtPn.Text = this.employee.Phone;
                cboCounty.SelectedText = this.employee.County;
                txtEmail.Text = this.employee.Email;
                txtAddress.Text = this.employee.Address;
                if (type.Equals(typeof(Manager)))
                {
                    Manager manager = (Manager)employee;
                    txtBonus.Text = manager.Bonus.ToString();
                    
                }

                else if (type.Equals(typeof(PartTime)))
                {
                    PartTime partTime = (PartTime)employee;
                    txtNoH.Text = partTime.NumOfHours.ToString();
                }
                else
                {
                    GeneralWorker generalWorker = (GeneralWorker)employee;
                    txtSalary.Text = generalWorker.Salary.ToString();
                }
            }
            
            
                this.employees = detailForm.employees;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpManager_Enter(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblCounty_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(County));
            if (type.Equals(typeof(Manager)))
            {
                this.Controls.Remove(grpSalary);
                this.Controls.Remove(grpNoH);
                grpSalary.Dispose();
                grpNoH.Dispose();   
            }
            else if (type.Equals(typeof(PartTime)))
            {
                this.Controls.Remove(grpSalary);
                this.Controls.Remove(grpBonus);
                grpSalary.Dispose();
                grpBonus.Dispose(); 
            }
            else
            {
                this.Controls.Remove(grpBonus);
                this.Controls.Remove(grpNoH);
                grpBonus.Dispose();
                grpNoH.Dispose(); 
            }

            
        }

        private void txtPn_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string ID = txtNo.Text;
            string firstname = txtFn.Text;
            string surname = txtSn.Text;
            DateTime DOB = dtp.Value;
            string phone = txtPn.Text;
            string county = cboCounty.SelectedItem.ToString();
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            Employee newEmployee; 
            if (type.Equals(typeof(Manager))){
                float bonus = float.Parse(txtBonus.Text);
                newEmployee = new Manager(ID, firstname, surname, address, county, DOB, email, phone, bonus);
                
            }

            else if (type.Equals(typeof(PartTime)))
            {
                int noOfHours = int.Parse(txtNoH.Text);
                newEmployee = new PartTime(ID, firstname, surname, address, county, DOB, email, phone, noOfHours);
            }
            else
            {
                float salary = float.Parse(txtSalary.Text);
                newEmployee = new GeneralWorker(ID, firstname, surname, address, county, DOB, email, phone, salary);
            }

            if (newEmployee != null)
            {

            }

            if (isEditing) {
                Update(newEmployee);
            }
            else
            {
                this.employees.Add(newEmployee);
                this.detailForm.UpdateDataGridView(employees);
                Form1.Employees.Add(newEmployee);
            }
           
            this.Close();

            
        }
        private void Update( Employee newEmployee)
        {
            int sourceIndex = Form1.Employees.IndexOf(employee);
            int detailFormIndex = this.employees.IndexOf(employee);

            //
            Form1.Employees.RemoveAt(sourceIndex);
            employees.RemoveAt(detailFormIndex);


            employees.Insert(sourceIndex, newEmployee);
            Form1.Employees.Insert(sourceIndex, newEmployee);

            this.detailForm.UpdateDataGridView(employees);

        }
    }
}
