using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagement
{
    public partial class Form1 : Form
    {
        public static List<Employee> Employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            Type type = typeof(Manager);
            var managers = Employees.FindAll(emp => emp.GetType().ToString().Equals(type.ToString()));
            this.ToggleDetailForm(type, managers);
        }

        private void btnGw_Click(object sender, EventArgs e)
        {
            Type type = typeof(GeneralWorker);
            var generalworker = Employees.FindAll(emp => emp.GetType().ToString().Equals(type.ToString()));
            this.ToggleDetailForm(type, generalworker);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Type type = typeof(PartTime);
            var parttime = Employees.FindAll(emp => emp.GetType().ToString().Equals(type.ToString()));
            this.ToggleDetailForm(type, parttime);
        }

        private void ToggleDetailForm(Type type, List<Employee> data)
        {
            DetailForm detailForm = new DetailForm(type);
            detailForm.UpdateDataGridView(data);
            detailForm.Show();
        }
    }
}
