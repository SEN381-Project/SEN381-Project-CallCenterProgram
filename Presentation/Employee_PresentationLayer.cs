﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenterProgram
{
    public partial class Emploee_PresantationLayer : Form
    {
        public Emploee_PresantationLayer()
        {
            InitializeComponent();
        }
        Employee_DataAccess handler = new Employee_DataAccess();

        private void Insert_Click(object sender, EventArgs e)
        {
            handler.InsertEmployee(int.Parse(txtiD.Text), txtName.Text, txtSurname.Text, txtAddress.Text, txtContact.Text, txtjob.Text, txtjobdescription.Text);

           
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form1 MainMenu = new Form1();
            MainMenu.Show();
        }
    

        private void Techician_Click(object sender, EventArgs e)
        {
            Technician_PresantationLayer technician = new Technician_PresantationLayer();
            technician.Show();
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            Manager_PresantationLayer Manager = new Manager_PresantationLayer();
            Manager.Show();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InsertDepartment_Click(object sender, EventArgs e)
        { 
            handler.InsertDepartMent(int.Parse(txtdepartmentid.Text), txtdepartmentname.Text, int.Parse(txtstationnumber.Text));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);
        }
    }
}