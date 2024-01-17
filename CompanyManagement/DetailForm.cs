using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagement
{
    public partial class DetailForm : Form
    {
        public Type type;
        public List<Employee> employees;
        public Employee employee;

        public DetailForm(Type type)
        {
            this.type = type;
            InitializeComponent();
        }

        public DetailForm()
        {
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true; 
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isEditing = false;
            AddForm addForm = new AddForm(this, isEditing);
            addForm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isEditing = true;
            AddForm editForm = new AddForm(this, isEditing);
            editForm.Show();
            
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Are you sure to delete current selected row?", "Row Deleted", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                if(this.dataGridView1.SelectedRows.Count > 0)
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                Form1.Employees.Remove(this.employee);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.Write(e.RowIndex.ToString());
        }

        public void UpdateDataGridView(List<Employee> employees)
        {
            this.employees = employees;
            DataTable dt = ListToDataTable(employees, "Employees list");
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dt;
            dataGridView1.DataSource = bindingSource;
        }

        private DataTable ListToDataTable<Employee>(List<Employee> list, string _tableName)
        {
            List<string> excludedColumns = new List<string>() { "Age", "FirstName", "Surname" };
             DataTable dt = new DataTable(_tableName);


            var infos = type.GetProperties().ToList();

            while (infos.ElementAt(0).Name != "ID")
            {
                var info = infos.First();
                infos.RemoveAt(0);
                infos.Add(info);
            }

            foreach (PropertyInfo info in infos)
            {
                if (!excludedColumns.Contains(info.Name))
                {
                    dt.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
                }
                
            }
            foreach (Employee t in list)
            {
                DataRow row = dt.NewRow();
                foreach (PropertyInfo info in infos)
                {
                    if (!excludedColumns.Contains(info.Name))
                    {
                        row[info.Name] = info.GetValue(t, null) ?? DBNull.Value;
                    }
                    
                }
                dt.Rows.Add(row);
            }
            return dt;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.employee = employees.ElementAt(e.RowIndex);
            
            
        }
    }
}   
