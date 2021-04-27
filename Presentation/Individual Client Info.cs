﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallCenterProgram.Bussiness_Logic;
using CallCenterProgram;

namespace CallCenterProgram.Presentation
{
    
    public partial class Individual_Client_Info : Form
    {

        BindingSource source = new BindingSource();

        public Individual_Client_Info()
        {
            InitializeComponent();
        }

        private void Individual_Client_Info_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);

            IndividualClient client = new IndividualClient();
            source.DataSource = client.GetCustomTable();
            dgvIndividualClients.DataSource = source;
        }

        private void btnViewBusinessClients_Click(object sender, EventArgs e)
        {
            Business_Client_Info businessform = new Business_Client_Info();
            businessform.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Client_Home homeform = new Client_Home();
            homeform.Show();
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Insert_Client insert = new Insert_Client();
            insert.Show();
            this.Close();
        }

        
    }
}
