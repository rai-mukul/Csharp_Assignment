using ManagmentInfoSystem.Business;
using ManagmentInfoSystem.Business.Contracts;
using ManagmentInfoSystem.Business.Models;
using ManagmentInfoSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagmentInfoSystem
{
    public partial class Form1 : Form
    {
        private readonly IManager<Student> _studentManager;
        private readonly IManager<Department> _departmentManager;
        private List<Department> departments = null;
        public Form1()
        {
            InitializeComponent();
            _studentManager = new StudentManager();
            _departmentManager = new DepartmentManager();
            btnUpdate.Enabled = false; 
            btnDelete.Enabled = false; 
            GetAllStudents();
            GetAllDepartments();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            GetAllStudents();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFields())
                    return;

                var student = new Student
                {
                    FirstName = firstName.Text,
                    LastName = lastName.Text,
                    Address = new Address
                    {
                        Line1 = line1.Text,
                        Line2 = line2.Text,
                        City = city.Text,
                        State = state.Text,
                        ZipCode = zipCode.Text
                    },
                    DepartmentId = Convert.ToInt32(Departments.SelectedValue)
                };

                var data = _studentManager.Get()?.ToList();

                var response = _studentManager.Insert(student);
                if (response > 0)
                {
                    MessageBox.Show("Student Record inserted successfully");
                    ClearFields();
                    GetAllStudents();
                    btnInsert.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error occured while insertion, try again later!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Ocurred please try again");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an item to update");
                    return;
                }

                if (!ValidateFields())
                    return;

                var student = new Student
                {
                    Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value),
                    FirstName = firstName.Text,
                    LastName = lastName.Text,
                    Address = new Address
                    {
                        Line1 = line1.Text,
                        Line2 = line2.Text,
                        City = city.Text,
                        State = state.Text,
                        ZipCode = zipCode.Text,
                        StudentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
                    },
                    DepartmentId = Convert.ToInt32(Departments.SelectedValue)
                };

                var resp = _studentManager.Update(student);
                MessageBox.Show(resp);
                GetAllStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Ocurred please try again");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to delete");
                return;
            }
            var resp = _studentManager.Delete(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            MessageBox.Show(resp);
            ClearFields();
            GetAllStudents();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void GetAllStudents()
        {
            var data = _studentManager.Get()?.ToList();
            if (data != null)
            {
                var viewModels = data.Select(student => new StudentViewModel
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Line1 = student.Address.Line1,
                    Line2 = student.Address.Line2,
                    City = student.Address.City,
                    State = student.Address.State,
                    ZipCode = student.Address.ZipCode,
                    DepartmentName = student.Department.Name
                }).ToList();
                dataGridView1.DataSource = viewModels;
            }
        }

        private void GetAllDepartments()
        {
            departments = _departmentManager.Get()?.ToList();
            Departments.DataSource = departments;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void ClearFields()
        {
            firstName.Text = null;
            lastName.Text = null;
            line1.Text = null;
            line2.Text = null;
            city.Text = null;
            state.Text = null;
            zipCode.Text = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                firstName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                lastName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                line1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                line2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                city.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                state.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                zipCode.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                Departments.SelectedIndex = departments.FindIndex(x => x.Name == dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
            }

            btnInsert.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateFields()
        {
            if(string.IsNullOrEmpty(firstName.Text))
            {
                MessageBox.Show("Firstname cannot be empty");
                return false;
            }
            if (string.IsNullOrEmpty(lastName.Text))
            {
                MessageBox.Show("Lastname cannot be empty");
                return false;
            }
            if (string.IsNullOrEmpty(line1.Text))
            {
                MessageBox.Show("Line1 Address cannot be empty");
                return false;
            }
            if (string.IsNullOrEmpty(city.Text))
            {
                MessageBox.Show("City cannot be empty");
                return false;
            }
            if (string.IsNullOrEmpty(state.Text))
            {
                MessageBox.Show("State cannot be empty");
                return false;
            }
            if (string.IsNullOrEmpty(zipCode.Text))
            {
                MessageBox.Show("Zipcode cannot be empty");
                return false;
            }
            if (Departments.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Department");
                return false;
            }
            return true;
        }

        private void line1Label_Click(object sender, EventArgs e)
        {

        }
    }
}
