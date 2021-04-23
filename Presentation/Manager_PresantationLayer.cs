﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CallCenterProgram.Bussiness_Logic;


namespace CallCenterProgram.Presentation
{
    public partial class Manager_PresantationLayer : Form
    {
        public Manager_PresantationLayer()
        {
            InitializeComponent();
        }


        public void datagridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                txtEmployeeId.Text = dataGridView1.Rows[e.RowIndex].Cells["EmployeeId"].FormattedValue.ToString();
                txtEmployeename.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtEmployeesurname.Text = dataGridView1.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
                txtEmployeeAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                txtContactDetails.Text = dataGridView1.Rows[e.RowIndex].Cells["ContactDetails"].FormattedValue.ToString();
                txtMjobtitle.Text = dataGridView1.Rows[e.RowIndex].Cells["JobTitle"].FormattedValue.ToString();
                txtMjobDespription.Text = dataGridView1.Rows[e.RowIndex].Cells["JobDescription"].FormattedValue.ToString();
            }
        }

        public void datagridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView2.CurrentRow.Selected = true;

                txtidDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells["DepartmentId"].FormattedValue.ToString();
                txtNameDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells["DepartmentName"].FormattedValue.ToString();
                txtSationNo.Text = dataGridView1.Rows[e.RowIndex].Cells["StationNumber"].FormattedValue.ToString();

            }

        }
        Manager manager = new Manager();
        private void UpdateEm_Click(object sender, EventArgs e)
        {
            manager.UpdateEmployeeInf(int.Parse(txtEmployeeId.Text),txtEmployeename.Text, txtEmployeesurname.Text, txtAddress.Text, txtContactDetails.Text, txtMjobtitle.Text, txtMjobDespription.Text);
        }

        private void DeleteEm_Click(object sender, EventArgs e)
        {

            manager.FireEmployee(int.Parse(txtEmployeeId.Text), txtEmployeename.Text, txtEmployeesurname.Text, txtAddress.Text, txtContactDetails.Text, txtMjobtitle.Text, txtMjobDespription.Text);
        }

        private void UpdateDp_Click(object sender, EventArgs e)
        {
            manager.UpdateDepartment(int.Parse(txtidDepartment.Text), txtNameDepartment.Text,int.Parse(txtSationNo.Text));
        }

        private void DeleteDp_Click(object sender, EventArgs e)
        {
            manager.RemoveDepartment(int.Parse(txtidDepartment.Text), txtNameDepartment.Text, int.Parse(txtSationNo.Text));
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            HomeForm MainMenu = new HomeForm();
            MainMenu.Show();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Emploee_PresantationLayer Employee = new Emploee_PresantationLayer();
            Employee.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Manager_PresantationLayer_Load(object sender, EventArgs e)
        {
            manager.ViewEmployee();
            manager.ViewDepartment();
        }
    }
}