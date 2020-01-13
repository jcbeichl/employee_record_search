using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaWeekThree
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //allow user to select 3 employee records
            if (radioButtonDisplayThree.Checked == true)
            {
                //DataTable table = new DataTable();
                table.Columns.Add("firstName");
                table.Columns.Add("lastName");
                table.Columns.Add("address");
                table.Columns.Add("city");
                table.Columns.Add("state");
                table.Columns.Add("zipCode");
                table.Columns.Add("empType");
                table.Columns.Add("costCenter");
                table.Columns.Add("devType");
                table.Columns.Add("supervisor");
                table.Columns.Add("taxType");

                fileEmpInfo.ShowDialog();
                string displayThree = fileEmpInfo.FileName;

                List<string> lines = System.IO.File.ReadAllLines(displayThree).Take(3).ToList();

                List<EmployeeInfo> employees = new List<EmployeeInfo>();

                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');

                    EmployeeInfo newEmployee = new EmployeeInfo();

                    newEmployee.FirstName = entries[0];
                    newEmployee.LastName = entries[1];
                    newEmployee.Address = entries[2];
                    newEmployee.City = entries[3];
                    newEmployee.State = entries[4];
                    newEmployee.ZipCode = entries[5];
                    newEmployee.EmployeeType = entries[6];
                    newEmployee.CostCenter = entries[7];
                    newEmployee.DeveloperType = entries[8];
                    newEmployee.Supervisor = entries[9];
                    newEmployee.TaxType = entries[10];

                    DataRow row = table.NewRow();
                    for (int cIndex = 0; cIndex < 11; cIndex++)
                    {
                        row[cIndex] = entries[cIndex];
                    }//end datarow

                    table.Rows.Add(row);

                    dataGridViewEmpInfo.DataSource = table;

                }//end foreach statement
            }//end display 3 is true statement

            //allow user to select 5 employee records
            else if (radioButtonDisplayFive.Checked == true)
            {
                //DataTable table = new DataTable();
                table.Columns.Add("firstName");
                table.Columns.Add("lastName");
                table.Columns.Add("address");
                table.Columns.Add("city");
                table.Columns.Add("state");
                table.Columns.Add("zipCode");
                table.Columns.Add("empType");
                table.Columns.Add("costCenter");
                table.Columns.Add("devType");
                table.Columns.Add("supervisor");
                table.Columns.Add("taxType");

                fileEmpInfo.ShowDialog();
                string displayFive = fileEmpInfo.FileName;

                List<string> lines = System.IO.File.ReadAllLines(displayFive).Take(5).ToList();

                List<EmployeeInfo> employees = new List<EmployeeInfo>();

                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');

                    EmployeeInfo newEmployee = new EmployeeInfo();

                    newEmployee.FirstName = entries[0];
                    newEmployee.LastName = entries[1];
                    newEmployee.Address = entries[2];
                    newEmployee.City = entries[3];
                    newEmployee.State = entries[4];
                    newEmployee.ZipCode = entries[5];
                    newEmployee.EmployeeType = entries[6];
                    newEmployee.CostCenter = entries[7];
                    newEmployee.DeveloperType = entries[8];
                    newEmployee.Supervisor = entries[9];
                    newEmployee.TaxType = entries[10];

                    DataRow row = table.NewRow();
                    for (int cIndex = 0; cIndex < 11; cIndex++)
                    {
                        row[cIndex] = entries[cIndex];
                    }

                    table.Rows.Add(row);

                    dataGridViewEmpInfo.DataSource = table;

                }//end foreach statement
            }//end display 5 is true statement

            //allow user to select all employee records
            else
            {
                //DataTable table = new DataTable();
                table.Columns.Add("firstName");
                table.Columns.Add("lastName");
                table.Columns.Add("address");
                table.Columns.Add("city");
                table.Columns.Add("state");
                table.Columns.Add("zipCode");
                table.Columns.Add("empType");
                table.Columns.Add("costCenter");
                table.Columns.Add("devType");
                table.Columns.Add("supervisor");
                table.Columns.Add("taxType");

                fileEmpInfo.ShowDialog();
                string displayAll = fileEmpInfo.FileName;

                List<string> lines = System.IO.File.ReadAllLines(displayAll).ToList();

                List<EmployeeInfo> employees = new List<EmployeeInfo>();
                
                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');

                    EmployeeInfo newEmployee = new EmployeeInfo();

                    newEmployee.FirstName = entries[0];
                    newEmployee.LastName = entries[1];
                    newEmployee.Address = entries[2];
                    newEmployee.City = entries[3];
                    newEmployee.State = entries[4];
                    newEmployee.ZipCode = entries[5];
                    newEmployee.EmployeeType = entries[6];
                    newEmployee.CostCenter = entries[7];
                    newEmployee.DeveloperType = entries[8];
                    newEmployee.Supervisor = entries[9];
                    newEmployee.TaxType = entries[10];

                    DataRow row = table.NewRow();
                    for (int cIndex = 0; cIndex < 11; cIndex++)
                    {
                        row[cIndex] = entries[cIndex];
                    }

                    table.Rows.Add(row);


                    dataGridViewEmpInfo.DataSource = table;

                }//end foreach statement
            }//end display all is true statement

        }//end button click


        //binding textbox with datatable to search employee first name, last name, street address, and state
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource tBox = new BindingSource();
            tBox.DataSource = dataGridViewEmpInfo.DataSource;
            tBox.Filter = "[firstName] like '%" + textBox1.Text + "%' or [lastName] like '%" + textBox1.Text + "%' or [address] like '%" + textBox1.Text + "%' or [state] like '%" + textBox1.Text + "%'";
            dataGridViewEmpInfo.DataSource = tBox;
        }

    }//end class form1 : forms
}//end namespace
