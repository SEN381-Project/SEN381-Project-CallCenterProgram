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
using System.Runtime.InteropServices;

namespace CallCenterProgram.Presentation
{
    
    public partial class Individual_Client_Info : Form
    {

        BindingSource source = new BindingSource();

        bool Maximized = false;

        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Individual_Client_Info()
        {
            InitializeComponent();
            Maximized = false;
            CreateMyBorderlessWindow();
        }

        public void CreateMyBorderlessWindow()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area.
            this.ControlBox = false;
        }

        private void Individual_Client_Info_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            IndividualClient client = new IndividualClient();
            source.DataSource = client.GetCustomTable();
            dgvIndividualClients.DataSource = source;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (Maximized == false)
            {
                this.WindowState = FormWindowState.Maximized;
                //btnMax.Text = "Normal";
                Maximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                //btnMax.Text = "Maximize";
                Maximized = false;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Individual_Client_Info_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvIndividualClients.Rows[dgvIndividualClients.CurrentRow.Index].Cells["ClientID"].Value;
            DialogResult result = MessageBox.Show("Are you sure you want to delete Client " + ID, "Delete Client", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                IndividualClient client = new IndividualClient();
                client.DeleteIndividualClient(ID);
                MessageBox.Show("Client " + ID + " was deleted");
            }
            else
            {
                MessageBox.Show("Client was not deleted");
            }
        }
    }
}
