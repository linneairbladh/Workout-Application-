using System;
using System.Runtime.InteropServices;
namespace AssignmentProg1
{
    partial class UpdateUsers
    {
        //Source code for making rounded corners: https://stackoverflow.com/questions/18822067/rounded-corners-in-c-sharp-windows-forms
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse

         );
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUsers));
            this.dataGridViewUpdateUsers = new System.Windows.Forms.DataGridView();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblUpdateUsers = new System.Windows.Forms.Label();
            this.btnUpdateUsers = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnMetadata = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.btnDeleteWorkout = new System.Windows.Forms.Button();
            this.btnGoToUpdateUsers = new System.Windows.Forms.Button();
            this.btnUpdateWorkout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateUsers)).BeginInit();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUpdateUsers
            // 
            this.dataGridViewUpdateUsers.AllowUserToAddRows = false;
            this.dataGridViewUpdateUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUpdateUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUpdateUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUpdateUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdateUsers.Location = new System.Drawing.Point(235, 76);
            this.dataGridViewUpdateUsers.Name = "dataGridViewUpdateUsers";
            this.dataGridViewUpdateUsers.ReadOnly = true;
            this.dataGridViewUpdateUsers.RowHeadersWidth = 62;
            this.dataGridViewUpdateUsers.Size = new System.Drawing.Size(537, 212);
            this.dataGridViewUpdateUsers.TabIndex = 0;
            this.dataGridViewUpdateUsers.SelectionChanged += new System.EventHandler(this.dataGridViewUpdateUsers_SelectionChanged);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(235, 332);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 21);
            this.txtFirstname.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(455, 332);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 21);
            this.txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(672, 332);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(100, 21);
            this.txtEmail.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(235, 379);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 21);
            this.txtAge.TabIndex = 4;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(455, 379);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 21);
            this.txtWeight.TabIndex = 5;
            // 
            // lblUpdateUsers
            // 
            this.lblUpdateUsers.AutoSize = true;
            this.lblUpdateUsers.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateUsers.ForeColor = System.Drawing.Color.White;
            this.lblUpdateUsers.Location = new System.Drawing.Point(451, 34);
            this.lblUpdateUsers.Name = "lblUpdateUsers";
            this.lblUpdateUsers.Size = new System.Drawing.Size(121, 23);
            this.lblUpdateUsers.TabIndex = 6;
            this.lblUpdateUsers.Text = "Update Users";
            // 
            // btnUpdateUsers
            // 
            this.btnUpdateUsers.BackColor = System.Drawing.Color.Snow;
            this.btnUpdateUsers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUsers.Location = new System.Drawing.Point(672, 381);
            this.btnUpdateUsers.Name = "btnUpdateUsers";
            this.btnUpdateUsers.Size = new System.Drawing.Size(100, 24);
            this.btnUpdateUsers.TabIndex = 7;
            this.btnUpdateUsers.Text = "Update";
            this.btnUpdateUsers.UseVisualStyleBackColor = false;
            this.btnUpdateUsers.Click += new System.EventHandler(this.btnUpdateUsers_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.White;
            this.lblInstructions.Location = new System.Drawing.Point(634, 408);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(165, 13);
            this.lblInstructions.TabIndex = 8;
            this.lblInstructions.Text = "Click this button to update user..";
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.White;
            this.navigationPanel.Controls.Add(this.btnDashboard);
            this.navigationPanel.Controls.Add(this.pictureBox1);
            this.navigationPanel.Controls.Add(this.btnAddUsers);
            this.navigationPanel.Controls.Add(this.btnMetadata);
            this.navigationPanel.Controls.Add(this.btnDeleteUsers);
            this.navigationPanel.Controls.Add(this.btnAddWorkout);
            this.navigationPanel.Controls.Add(this.btnDeleteWorkout);
            this.navigationPanel.Controls.Add(this.btnGoToUpdateUsers);
            this.navigationPanel.Controls.Add(this.btnUpdateWorkout);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(200, 446);
            this.navigationPanel.TabIndex = 24;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 137);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(200, 34);
            this.btnDashboard.TabIndex = 24;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddUsers
            // 
            this.btnAddUsers.FlatAppearance.BorderSize = 0;
            this.btnAddUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUsers.Image")));
            this.btnAddUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUsers.Location = new System.Drawing.Point(0, 176);
            this.btnAddUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(200, 34);
            this.btnAddUsers.TabIndex = 17;
            this.btnAddUsers.Text = "Add Users";
            this.btnAddUsers.UseVisualStyleBackColor = true;
            this.btnAddUsers.Click += new System.EventHandler(this.btnAddUsers_Click);
            // 
            // btnMetadata
            // 
            this.btnMetadata.FlatAppearance.BorderSize = 0;
            this.btnMetadata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetadata.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetadata.Image = ((System.Drawing.Image)(resources.GetObject("btnMetadata.Image")));
            this.btnMetadata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetadata.Location = new System.Drawing.Point(0, 410);
            this.btnMetadata.Margin = new System.Windows.Forms.Padding(0);
            this.btnMetadata.Name = "btnMetadata";
            this.btnMetadata.Size = new System.Drawing.Size(200, 34);
            this.btnMetadata.TabIndex = 22;
            this.btnMetadata.Text = "Metadata";
            this.btnMetadata.UseVisualStyleBackColor = true;
            this.btnMetadata.Click += new System.EventHandler(this.btnMetadata_Click);
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.FlatAppearance.BorderSize = 0;
            this.btnDeleteUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUsers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUsers.Image")));
            this.btnDeleteUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUsers.Location = new System.Drawing.Point(0, 254);
            this.btnDeleteUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(200, 34);
            this.btnDeleteUsers.TabIndex = 20;
            this.btnDeleteUsers.Text = "Delete Users";
            this.btnDeleteUsers.UseVisualStyleBackColor = true;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUsers_Click);
            // 
            // btnAddWorkout
            // 
            this.btnAddWorkout.FlatAppearance.BorderSize = 0;
            this.btnAddWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWorkout.Image = ((System.Drawing.Image)(resources.GetObject("btnAddWorkout.Image")));
            this.btnAddWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddWorkout.Location = new System.Drawing.Point(0, 293);
            this.btnAddWorkout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(200, 34);
            this.btnAddWorkout.TabIndex = 19;
            this.btnAddWorkout.Text = "Add Workout";
            this.btnAddWorkout.UseVisualStyleBackColor = true;
            this.btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click);
            // 
            // btnDeleteWorkout
            // 
            this.btnDeleteWorkout.FlatAppearance.BorderSize = 0;
            this.btnDeleteWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWorkout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWorkout.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteWorkout.Image")));
            this.btnDeleteWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteWorkout.Location = new System.Drawing.Point(0, 371);
            this.btnDeleteWorkout.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteWorkout.Name = "btnDeleteWorkout";
            this.btnDeleteWorkout.Size = new System.Drawing.Size(200, 34);
            this.btnDeleteWorkout.TabIndex = 18;
            this.btnDeleteWorkout.Text = "Delete Workout";
            this.btnDeleteWorkout.UseVisualStyleBackColor = true;
            this.btnDeleteWorkout.Click += new System.EventHandler(this.btnDeleteWorkout_Click);
            // 
            // btnGoToUpdateUsers
            // 
            this.btnGoToUpdateUsers.FlatAppearance.BorderSize = 0;
            this.btnGoToUpdateUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToUpdateUsers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToUpdateUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToUpdateUsers.Image")));
            this.btnGoToUpdateUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToUpdateUsers.Location = new System.Drawing.Point(0, 215);
            this.btnGoToUpdateUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnGoToUpdateUsers.Name = "btnGoToUpdateUsers";
            this.btnGoToUpdateUsers.Size = new System.Drawing.Size(200, 34);
            this.btnGoToUpdateUsers.TabIndex = 16;
            this.btnGoToUpdateUsers.Text = "Update Users";
            this.btnGoToUpdateUsers.UseVisualStyleBackColor = true;
            this.btnGoToUpdateUsers.Click += new System.EventHandler(this.btnGoToUpdateUsers_Click);
            // 
            // btnUpdateWorkout
            // 
            this.btnUpdateWorkout.FlatAppearance.BorderSize = 0;
            this.btnUpdateWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateWorkout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWorkout.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateWorkout.Image")));
            this.btnUpdateWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateWorkout.Location = new System.Drawing.Point(0, 332);
            this.btnUpdateWorkout.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateWorkout.Name = "btnUpdateWorkout";
            this.btnUpdateWorkout.Size = new System.Drawing.Size(200, 34);
            this.btnUpdateWorkout.TabIndex = 21;
            this.btnUpdateWorkout.Text = "Update Workout";
            this.btnUpdateWorkout.UseVisualStyleBackColor = true;
            this.btnUpdateWorkout.Click += new System.EventHandler(this.btnUpdateWorkout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(780, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(752, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(31, 23);
            this.btnMinimize.TabIndex = 26;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(234, 356);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 27;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(455, 358);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 28;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(673, 356);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(234, 403);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 30;
            this.lblAge.Text = "Age";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.ForeColor = System.Drawing.Color.White;
            this.lblWeight.Location = new System.Drawing.Point(455, 403);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 31;
            this.lblWeight.Text = "Weight";
            // 
            // UpdateUsers
            // 
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(811, 446);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnUpdateUsers);
            this.Controls.Add(this.lblUpdateUsers);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.dataGridViewUpdateUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateUsers)).EndInit();
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUpdateUsers;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblUpdateUsers;
        private System.Windows.Forms.Button btnUpdateUsers;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button btnMetadata;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.Button btnAddWorkout;
        private System.Windows.Forms.Button btnDeleteWorkout;
        private System.Windows.Forms.Button btnGoToUpdateUsers;
        private System.Windows.Forms.Button btnUpdateWorkout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblWeight;
    }
}