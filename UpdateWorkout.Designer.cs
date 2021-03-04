using System.Runtime.InteropServices;
using System;
namespace AssignmentProg1
{
    partial class UpdateWorkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateWorkout));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnMetadata = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnGoToAddWorkout = new System.Windows.Forms.Button();
            this.btnDeleteWorkout = new System.Windows.Forms.Button();
            this.btnUpdateUsers = new System.Windows.Forms.Button();
            this.btnUpdateWorkout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateWorkout = new System.Windows.Forms.Label();
            this.txtWorkoutType = new System.Windows.Forms.TextBox();
            this.txtSets = new System.Windows.Forms.TextBox();
            this.txtReps = new System.Windows.Forms.TextBox();
            this.lblWorkoutType = new System.Windows.Forms.Label();
            this.lblSets = new System.Windows.Forms.Label();
            this.lblReps = new System.Windows.Forms.Label();
            this.lblWorkoutID = new System.Windows.Forms.Label();
            this.txtWorkoutID = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dataGridViewUpdateWorkout = new System.Windows.Forms.DataGridView();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateWorkout)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.White;
            this.navigationPanel.Controls.Add(this.btnDashboard);
            this.navigationPanel.Controls.Add(this.pictureBox1);
            this.navigationPanel.Controls.Add(this.btnAddUsers);
            this.navigationPanel.Controls.Add(this.btnMetadata);
            this.navigationPanel.Controls.Add(this.btnDeleteUsers);
            this.navigationPanel.Controls.Add(this.btnGoToAddWorkout);
            this.navigationPanel.Controls.Add(this.btnDeleteWorkout);
            this.navigationPanel.Controls.Add(this.btnUpdateUsers);
            this.navigationPanel.Controls.Add(this.btnUpdateWorkout);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(300, 686);
            this.navigationPanel.TabIndex = 29;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 211);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(300, 52);
            this.btnDashboard.TabIndex = 24;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.btnAddUsers.ForeColor = System.Drawing.Color.Black;
            this.btnAddUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUsers.Image")));
            this.btnAddUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUsers.Location = new System.Drawing.Point(0, 271);
            this.btnAddUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddUsers.Name = "btnAddUsers";
            this.btnAddUsers.Size = new System.Drawing.Size(300, 52);
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
            this.btnMetadata.ForeColor = System.Drawing.Color.Black;
            this.btnMetadata.Image = ((System.Drawing.Image)(resources.GetObject("btnMetadata.Image")));
            this.btnMetadata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetadata.Location = new System.Drawing.Point(0, 631);
            this.btnMetadata.Margin = new System.Windows.Forms.Padding(0);
            this.btnMetadata.Name = "btnMetadata";
            this.btnMetadata.Size = new System.Drawing.Size(300, 52);
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
            this.btnDeleteUsers.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteUsers.Image")));
            this.btnDeleteUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUsers.Location = new System.Drawing.Point(0, 391);
            this.btnDeleteUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(300, 52);
            this.btnDeleteUsers.TabIndex = 20;
            this.btnDeleteUsers.Text = "Delete Users";
            this.btnDeleteUsers.UseVisualStyleBackColor = true;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUsers_Click);
            // 
            // btnGoToAddWorkout
            // 
            this.btnGoToAddWorkout.FlatAppearance.BorderSize = 0;
            this.btnGoToAddWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToAddWorkout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToAddWorkout.ForeColor = System.Drawing.Color.Black;
            this.btnGoToAddWorkout.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToAddWorkout.Image")));
            this.btnGoToAddWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToAddWorkout.Location = new System.Drawing.Point(0, 451);
            this.btnGoToAddWorkout.Margin = new System.Windows.Forms.Padding(0);
            this.btnGoToAddWorkout.Name = "btnGoToAddWorkout";
            this.btnGoToAddWorkout.Size = new System.Drawing.Size(300, 52);
            this.btnGoToAddWorkout.TabIndex = 19;
            this.btnGoToAddWorkout.Text = "Add Workout";
            this.btnGoToAddWorkout.UseVisualStyleBackColor = true;
            this.btnGoToAddWorkout.Click += new System.EventHandler(this.btnGoToAddWorkout_Click);
            // 
            // btnDeleteWorkout
            // 
            this.btnDeleteWorkout.FlatAppearance.BorderSize = 0;
            this.btnDeleteWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWorkout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWorkout.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteWorkout.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteWorkout.Image")));
            this.btnDeleteWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteWorkout.Location = new System.Drawing.Point(0, 571);
            this.btnDeleteWorkout.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteWorkout.Name = "btnDeleteWorkout";
            this.btnDeleteWorkout.Size = new System.Drawing.Size(300, 52);
            this.btnDeleteWorkout.TabIndex = 18;
            this.btnDeleteWorkout.Text = "Delete Workout";
            this.btnDeleteWorkout.UseVisualStyleBackColor = true;
            this.btnDeleteWorkout.Click += new System.EventHandler(this.btnDeleteWorkout_Click);
            // 
            // btnUpdateUsers
            // 
            this.btnUpdateUsers.FlatAppearance.BorderSize = 0;
            this.btnUpdateUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUsers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUsers.Image")));
            this.btnUpdateUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUsers.Location = new System.Drawing.Point(0, 331);
            this.btnUpdateUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateUsers.Name = "btnUpdateUsers";
            this.btnUpdateUsers.Size = new System.Drawing.Size(300, 52);
            this.btnUpdateUsers.TabIndex = 16;
            this.btnUpdateUsers.Text = "Update Users";
            this.btnUpdateUsers.UseVisualStyleBackColor = true;
            this.btnUpdateUsers.Click += new System.EventHandler(this.btnUpdateUsers_Click);
            // 
            // btnUpdateWorkout
            // 
            this.btnUpdateWorkout.FlatAppearance.BorderSize = 0;
            this.btnUpdateWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateWorkout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWorkout.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateWorkout.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateWorkout.Image")));
            this.btnUpdateWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateWorkout.Location = new System.Drawing.Point(0, 511);
            this.btnUpdateWorkout.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateWorkout.Name = "btnUpdateWorkout";
            this.btnUpdateWorkout.Size = new System.Drawing.Size(300, 52);
            this.btnUpdateWorkout.TabIndex = 21;
            this.btnUpdateWorkout.Text = "Update Workout";
            this.btnUpdateWorkout.UseVisualStyleBackColor = true;
            this.btnUpdateWorkout.Click += new System.EventHandler(this.btnUpdateWorkout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1168, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 35);
            this.btnExit.TabIndex = 30;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1126, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 35);
            this.btnMinimize.TabIndex = 31;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(978, 575);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 42);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateWorkout
            // 
            this.lblUpdateWorkout.AutoSize = true;
            this.lblUpdateWorkout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateWorkout.ForeColor = System.Drawing.Color.White;
            this.lblUpdateWorkout.Location = new System.Drawing.Point(651, 128);
            this.lblUpdateWorkout.Name = "lblUpdateWorkout";
            this.lblUpdateWorkout.Size = new System.Drawing.Size(223, 35);
            this.lblUpdateWorkout.TabIndex = 34;
            this.lblUpdateWorkout.Text = "Update Workout";
            // 
            // txtWorkoutType
            // 
            this.txtWorkoutType.BackColor = System.Drawing.Color.White;
            this.txtWorkoutType.Location = new System.Drawing.Point(693, 511);
            this.txtWorkoutType.Name = "txtWorkoutType";
            this.txtWorkoutType.Size = new System.Drawing.Size(134, 26);
            this.txtWorkoutType.TabIndex = 35;
            // 
            // txtSets
            // 
            this.txtSets.BackColor = System.Drawing.Color.White;
            this.txtSets.Location = new System.Drawing.Point(975, 511);
            this.txtSets.Name = "txtSets";
            this.txtSets.Size = new System.Drawing.Size(134, 26);
            this.txtSets.TabIndex = 36;
            // 
            // txtReps
            // 
            this.txtReps.BackColor = System.Drawing.Color.White;
            this.txtReps.Location = new System.Drawing.Point(411, 586);
            this.txtReps.Name = "txtReps";
            this.txtReps.Size = new System.Drawing.Size(134, 26);
            this.txtReps.TabIndex = 37;
            // 
            // lblWorkoutType
            // 
            this.lblWorkoutType.AutoSize = true;
            this.lblWorkoutType.ForeColor = System.Drawing.Color.White;
            this.lblWorkoutType.Location = new System.Drawing.Point(693, 486);
            this.lblWorkoutType.Name = "lblWorkoutType";
            this.lblWorkoutType.Size = new System.Drawing.Size(103, 20);
            this.lblWorkoutType.TabIndex = 38;
            this.lblWorkoutType.Text = "WorkoutType";
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = true;
            this.lblSets.ForeColor = System.Drawing.Color.White;
            this.lblSets.Location = new System.Drawing.Point(974, 486);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(42, 20);
            this.lblSets.TabIndex = 39;
            this.lblSets.Text = "Sets";
            // 
            // lblReps
            // 
            this.lblReps.AutoSize = true;
            this.lblReps.ForeColor = System.Drawing.Color.White;
            this.lblReps.Location = new System.Drawing.Point(411, 563);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(47, 20);
            this.lblReps.TabIndex = 40;
            this.lblReps.Text = "Reps";
            // 
            // lblWorkoutID
            // 
            this.lblWorkoutID.AutoSize = true;
            this.lblWorkoutID.ForeColor = System.Drawing.Color.White;
            this.lblWorkoutID.Location = new System.Drawing.Point(411, 486);
            this.lblWorkoutID.Name = "lblWorkoutID";
            this.lblWorkoutID.Size = new System.Drawing.Size(86, 20);
            this.lblWorkoutID.TabIndex = 42;
            this.lblWorkoutID.Text = "WorkoutID";
            // 
            // txtWorkoutID
            // 
            this.txtWorkoutID.BackColor = System.Drawing.Color.White;
            this.txtWorkoutID.Location = new System.Drawing.Point(411, 512);
            this.txtWorkoutID.Name = "txtWorkoutID";
            this.txtWorkoutID.ReadOnly = true;
            this.txtWorkoutID.Size = new System.Drawing.Size(134, 26);
            this.txtWorkoutID.TabIndex = 41;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(693, 563);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 44;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(693, 586);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(134, 26);
            this.txtEmail.TabIndex = 43;
            // 
            // dataGridViewUpdateWorkout
            // 
            this.dataGridViewUpdateWorkout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdateWorkout.Location = new System.Drawing.Point(415, 215);
            this.dataGridViewUpdateWorkout.Name = "dataGridViewUpdateWorkout";
            this.dataGridViewUpdateWorkout.ReadOnly = true;
            this.dataGridViewUpdateWorkout.RowHeadersWidth = 62;
            this.dataGridViewUpdateWorkout.RowTemplate.Height = 28;
            this.dataGridViewUpdateWorkout.Size = new System.Drawing.Size(696, 236);
            this.dataGridViewUpdateWorkout.TabIndex = 45;
            this.dataGridViewUpdateWorkout.SelectionChanged += new System.EventHandler(this.dataGridViewUpdateWorkout_SelectionChanged_1);
            // 
            // UpdateWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1216, 686);
            this.Controls.Add(this.dataGridViewUpdateWorkout);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblWorkoutID);
            this.Controls.Add(this.txtWorkoutID);
            this.Controls.Add(this.lblReps);
            this.Controls.Add(this.lblSets);
            this.Controls.Add(this.lblWorkoutType);
            this.Controls.Add(this.txtReps);
            this.Controls.Add(this.txtSets);
            this.Controls.Add(this.txtWorkoutType);
            this.Controls.Add(this.lblUpdateWorkout);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.navigationPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateWorkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateWorkout";
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateWorkout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddUsers;
        private System.Windows.Forms.Button btnMetadata;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.Button btnGoToAddWorkout;
        private System.Windows.Forms.Button btnDeleteWorkout;
        private System.Windows.Forms.Button btnUpdateUsers;
        private System.Windows.Forms.Button btnUpdateWorkout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateWorkout;
        private System.Windows.Forms.TextBox txtWorkoutType;
        private System.Windows.Forms.TextBox txtSets;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.Label lblWorkoutType;
        private System.Windows.Forms.Label lblSets;
        private System.Windows.Forms.Label lblReps;
        private System.Windows.Forms.Label lblWorkoutID;
        private System.Windows.Forms.TextBox txtWorkoutID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dataGridViewUpdateWorkout;
    }
}