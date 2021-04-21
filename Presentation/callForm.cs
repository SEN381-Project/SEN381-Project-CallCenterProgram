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
using CallCenterProgram.Data_Access;
using CallCenterProgram;

namespace CallCenterProgram.Presentation
{
    public partial class callForm : System.Windows.Forms.Form
    {
        //classes
        Call call = new Call();
        colors RGB = new colors();
        //constructor
        public callForm()
        {
            InitializeComponent();
        }
        //methods
        //styling methods
        private void colorButtons()
        {
            //btn Insert Into DB
            btnInsertIntoDB.ForeColor = RGB.accentColorLighterColor;
            btnInsertIntoDB.FlatAppearance.MouseDownBackColor = RGB.accentDarkerColor;
            //btn generate reports
            //btnGenerateReports.ForeColor = RGB.accentColorLighterColor;
            //btnGenerateReports.FlatAppearance.MouseDownBackColor = RGB.accentDarkerColor;
            //btn home
            btnHome.ForeColor = RGB.accentColor;
            btnHome.FlatAppearance.BorderColor = RGB.accentColorLighterColor;
            btnHome.FlatAppearance.MouseDownBackColor = RGB.accentDarkerColor;
            //btn make call
            btnMakeCall.FlatAppearance.MouseDownBackColor = RGB.green;
            btnMakeCall.FlatAppearance.MouseOverBackColor = RGB.hoverGreen;
            //btn take call
            btnTakeCall.FlatAppearance.MouseDownBackColor = RGB.green;
            btnTakeCall.FlatAppearance.MouseOverBackColor = RGB.hoverGreen;
            //btn end call
            btnEndCall.FlatAppearance.MouseDownBackColor = RGB.red;
            btnEndCall.FlatAppearance.MouseOverBackColor = RGB.hoverRed;
            //btn find client info
            btnFindClientInfo.ForeColor = RGB.accentColor;
            btnFindClientInfo.FlatAppearance.MouseDownBackColor = RGB.accentDarkerColor;
            btnFindClientInfo.FlatAppearance.MouseOverBackColor = RGB.hoverAccent;

        }

        private void colorPanels()
        {
            pnlReports.BackColor = RGB.bgLighterColor;
            pnlClientInfo.BackColor = RGB.bgLighterColor;
            pnlTitleBar.BackColor = RGB.bgDarkerColor;
            pnlRightSide.BackColor = RGB.bgDarkerColor;
            pnlRightBottom.BackColor = RGB.bgLighterColor;
        }

        private void colorLabels()
        {
            //header labels
            lblTitle.ForeColor = RGB.accentColor;
            lblReports.ForeColor = RGB.accentColor;
            lblClientInfo.ForeColor = RGB.accentColor;

            //labels
            lblFaultReport.ForeColor = RGB.grey;
            lblCallReport.ForeColor = RGB.grey;
            lblProblemInfo.ForeColor = RGB.grey;
            lblWorkRequest.ForeColor = RGB.grey;
            lblClientCallHistory.ForeColor = RGB.grey;
            lblAgreements.ForeColor = RGB.grey;
            lblClientNumber.ForeColor = RGB.grey;
        }

        private void colorReportRichTextBoxs()
        {
            colorRichTextBox(rtbCallReport);
            colorRichTextBox(rtbFaultReport);
            colorRichTextBox(rtbProblemInfo);
            colorRichTextBox(rtbWorkRequest);
        }

        private void colorRichTextBox(RichTextBox rtb)
        {
            rtb.BackColor = RGB.bgColor;
            rtb.ForeColor = RGB.grey;
        }

        private void colorTextbox()
        {
            txtClientInfo.BackColor = RGB.bgColor;
            txtClientInfo.ForeColor = RGB.grey;
        }
        //logic methods
        private void setValues()
        {
            //set call values
            call.CallReport = rtbCallReport.Text;
            call.ProblemInfo = rtbProblemInfo.Text;
            call.WorkRequest = rtbWorkRequest.Text;
            call.FaultReport = rtbFaultReport.Text;
        }

        //form components
        private void call_Load(object sender, EventArgs e)
        {
            this.BackColor = RGB.bgColor;
            colorButtons();
            colorPanels();
            colorLabels();
            colorTextbox();
            colorReportRichTextBoxs();
        }

        private void btnTakeCall_Click(object sender, EventArgs e)
        {
            call.createInitialTimestamp();
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            call.createInitialTimestamp();
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            call.createFinalTimestamp();
        }

        private void btnInsertIntoDB_Click(object sender, EventArgs e)
        {
            call.InsertCallIntoDB();
        }

        private void btnFindClientInfo_Click(object sender, EventArgs e)
        {
            //find clients info based on client ID
            //display the information in the data grid views
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //go to home form
        }
    }
}
