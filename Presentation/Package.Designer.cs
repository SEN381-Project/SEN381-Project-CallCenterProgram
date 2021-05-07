﻿
namespace CallCenterProgram.Presentation
{
    partial class Package
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Package));
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.txtServiceLevelsIDs = new System.Windows.Forms.TextBox();
            this.txtServiceIDs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSecurityLevels = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvServiceLevels = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdatePackage = new System.Windows.Forms.Button();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.txtUPdateServiceLevelIDs = new System.Windows.Forms.TextBox();
            this.txtUpdateServiceIDs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurityLevels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceLevels)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnAddPackage.Location = new System.Drawing.Point(649, 810);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(147, 48);
            this.btnAddPackage.TabIndex = 46;
            this.btnAddPackage.Text = "ADD PACKAGE";
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(355, 757);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(441, 22);
            this.txtPackageName.TabIndex = 44;
            // 
            // txtServiceLevelsIDs
            // 
            this.txtServiceLevelsIDs.Location = new System.Drawing.Point(355, 695);
            this.txtServiceLevelsIDs.Name = "txtServiceLevelsIDs";
            this.txtServiceLevelsIDs.Size = new System.Drawing.Size(441, 22);
            this.txtServiceLevelsIDs.TabIndex = 43;
            // 
            // txtServiceIDs
            // 
            this.txtServiceIDs.Location = new System.Drawing.Point(355, 646);
            this.txtServiceIDs.Name = "txtServiceIDs";
            this.txtServiceIDs.Size = new System.Drawing.Size(441, 22);
            this.txtServiceIDs.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 758);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Enter Package Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 694);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 42);
            this.label4.TabIndex = 38;
            this.label4.Text = "Enter Service Level IDs: \r\n(first table on the right) ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Enter Service IDs (from table above):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(703, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "ADD PACKAGE SECTION: (ALL FIELDS TO BE FILLED IN!)";
            // 
            // dgvSecurityLevels
            // 
            this.dgvSecurityLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecurityLevels.Location = new System.Drawing.Point(29, 296);
            this.dgvSecurityLevels.Name = "dgvSecurityLevels";
            this.dgvSecurityLevels.RowHeadersWidth = 51;
            this.dgvSecurityLevels.RowTemplate.Height = 24;
            this.dgvSecurityLevels.Size = new System.Drawing.Size(781, 145);
            this.dgvSecurityLevels.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(279, 25);
            this.label10.TabIndex = 55;
            this.label10.Text = "Existing Security Levels:";
            // 
            // dgvServiceLevels
            // 
            this.dgvServiceLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceLevels.Location = new System.Drawing.Point(29, 77);
            this.dgvServiceLevels.Name = "dgvServiceLevels";
            this.dgvServiceLevels.RowHeadersWidth = 51;
            this.dgvServiceLevels.RowTemplate.Height = 24;
            this.dgvServiceLevels.Size = new System.Drawing.Size(781, 144);
            this.dgvServiceLevels.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Existing Service Levels:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSecurityLevels);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dgvServiceLevels);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.groupBox1.Location = new System.Drawing.Point(885, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 462);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Level Details";
            // 
            // dgvServices
            // 
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(21, 80);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.Size = new System.Drawing.Size(781, 151);
            this.dgvServices.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 25);
            this.label11.TabIndex = 58;
            this.label11.Text = "Existing Services:";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnMainMenu.Location = new System.Drawing.Point(690, 958);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(525, 48);
            this.btnMainMenu.TabIndex = 60;
            this.btnMainMenu.Text = "MAIN MENU";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(658, 119);
            this.label6.TabIndex = 61;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(911, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(749, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "UPDATE PACKAGE SECTION: (ALL FIELDS TO BE FILLED IN!)";
            // 
            // btnUpdatePackage
            // 
            this.btnUpdatePackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnUpdatePackage.Location = new System.Drawing.Point(1527, 802);
            this.btnUpdatePackage.Name = "btnUpdatePackage";
            this.btnUpdatePackage.Size = new System.Drawing.Size(147, 48);
            this.btnUpdatePackage.TabIndex = 69;
            this.btnUpdatePackage.Text = "UPDATE PACKAGE";
            this.btnUpdatePackage.UseVisualStyleBackColor = true;
            this.btnUpdatePackage.Click += new System.EventHandler(this.btnUpdatePackage_Click);
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(1233, 729);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(441, 22);
            this.txtUpdateName.TabIndex = 68;
            // 
            // txtUPdateServiceLevelIDs
            // 
            this.txtUPdateServiceLevelIDs.Location = new System.Drawing.Point(1233, 676);
            this.txtUPdateServiceLevelIDs.Name = "txtUPdateServiceLevelIDs";
            this.txtUPdateServiceLevelIDs.Size = new System.Drawing.Size(441, 22);
            this.txtUPdateServiceLevelIDs.TabIndex = 67;
            // 
            // txtUpdateServiceIDs
            // 
            this.txtUpdateServiceIDs.Location = new System.Drawing.Point(1233, 618);
            this.txtUpdateServiceIDs.Name = "txtUpdateServiceIDs";
            this.txtUpdateServiceIDs.Size = new System.Drawing.Size(441, 22);
            this.txtUpdateServiceIDs.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(912, 730);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 21);
            this.label8.TabIndex = 65;
            this.label8.Text = "Package Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(912, 666);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 42);
            this.label9.TabIndex = 64;
            this.label9.Text = "Service Level IDs: \r\n(first table on the right) ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(912, 619);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(303, 42);
            this.label12.TabIndex = 63;
            this.label12.Text = "Service IDs (from existing services \r\ntable):";
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(1233, 575);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(441, 22);
            this.txtUpdateID.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(912, 576);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 21);
            this.label13.TabIndex = 70;
            this.label13.Text = "Package ID:";
            // 
            // dgvPackages
            // 
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Location = new System.Drawing.Point(17, 288);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.RowHeadersWidth = 51;
            this.dgvPackages.RowTemplate.Height = 24;
            this.dgvPackages.Size = new System.Drawing.Size(781, 151);
            this.dgvPackages.TabIndex = 72;
            this.dgvPackages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackages_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(212, 25);
            this.label14.TabIndex = 73;
            this.label14.Text = "Existing Packages:";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.button1.Location = new System.Drawing.Point(759, 892);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(398, 48);
            this.button1.TabIndex = 74;
            this.button1.Text = "PACKAGE PERFORMANCE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1773, 1018);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvPackages);
            this.Controls.Add(this.txtUpdateID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnUpdatePackage);
            this.Controls.Add(this.txtUpdateName);
            this.Controls.Add(this.txtUPdateServiceLevelIDs);
            this.Controls.Add(this.txtUpdateServiceIDs);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.txtServiceLevelsIDs);
            this.Controls.Add(this.txtServiceIDs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.Name = "Package";
            this.Text = "Package";
            this.Load += new System.EventHandler(this.Package_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurityLevels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceLevels)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.TextBox txtServiceLevelsIDs;
        private System.Windows.Forms.TextBox txtServiceIDs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSecurityLevels;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvServiceLevels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdatePackage;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtUPdateServiceLevelIDs;
        private System.Windows.Forms.TextBox txtUpdateServiceIDs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
    }
}