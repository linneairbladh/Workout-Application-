using System.Runtime.InteropServices;
using System;
namespace AssignmentProg1
{
    partial class Workout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workout));
            this.lblAddWorkout = new System.Windows.Forms.Label();
            this.lblWorkoutType = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSets = new System.Windows.Forms.Label();
            this.lblReps = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.txtWorkout = new System.Windows.Forms.TextBox();
            this.txtSets = new System.Windows.Forms.TextBox();
            this.txtReps = new System.Windows.Forms.TextBox();
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
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddWorkout
            // 
            this.lblAddWorkout.AutoSize = true;
            this.lblAddWorkout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWorkout.ForeColor = System.Drawing.Color.White;
            this.lblAddWorkout.Location = new System.Drawing.Point(434, 23);
            this.lblAddWorkout.Name = "lblAddWorkout";
            this.lblAddWorkout.Size = new System.Drawing.Size(119, 23);
            this.lblAddWorkout.TabIndex = 1;
            this.lblAddWorkout.Text = "Add Workout";
            // 
            // lblWorkoutType
            // 
            this.lblWorkoutType.AutoSize = true;
            this.lblWorkoutType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutType.ForeColor = System.Drawing.Color.White;
            this.lblWorkoutType.Location = new System.Drawing.Point(282, 60);
            this.lblWorkoutType.Name = "lblWorkoutType";
            this.lblWorkoutType.Size = new System.Drawing.Size(189, 13);
            this.lblWorkoutType.TabIndex = 4;
            this.lblWorkoutType.Text = "Workout type ( ex squats, push-ups):";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(576, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(31, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = true;
            this.lblSets.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSets.ForeColor = System.Drawing.Color.White;
            this.lblSets.Location = new System.Drawing.Point(282, 134);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(81, 13);
            this.lblSets.TabIndex = 6;
            this.lblSets.Text = "Number of Sets";
            // 
            // lblReps
            // 
            this.lblReps.AutoSize = true;
            this.lblReps.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReps.ForeColor = System.Drawing.Color.White;
            this.lblReps.Location = new System.Drawing.Point(576, 60);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(84, 13);
            this.lblReps.TabIndex = 7;
            this.lblReps.Text = "Number of Reps";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(282, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(422, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Workout";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sets";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Reps";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(450, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 33);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Register";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddWorkout
            // 
            this.btnAddWorkout.BackColor = System.Drawing.Color.White;
            this.btnAddWorkout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWorkout.Location = new System.Drawing.Point(447, 386);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(93, 33);
            this.btnAddWorkout.TabIndex = 20;
            this.btnAddWorkout.Text = "Create workout";
            this.btnAddWorkout.UseVisualStyleBackColor = false;
            this.btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click);
            // 
            // txtWorkout
            // 
            this.txtWorkout.Location = new System.Drawing.Point(282, 79);
            this.txtWorkout.Name = "txtWorkout";
            this.txtWorkout.Size = new System.Drawing.Size(121, 20);
            this.txtWorkout.TabIndex = 24;
            // 
            // txtSets
            // 
            this.txtSets.Location = new System.Drawing.Point(282, 153);
            this.txtSets.Name = "txtSets";
            this.txtSets.Size = new System.Drawing.Size(121, 20);
            this.txtSets.TabIndex = 25;
            // 
            // txtReps
            // 
            this.txtReps.Location = new System.Drawing.Point(579, 79);
            this.txtReps.Name = "txtReps";
            this.txtReps.Size = new System.Drawing.Size(121, 20);
            this.txtReps.TabIndex = 26;
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
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(200, 446);
            this.navigationPanel.TabIndex = 28;
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
            this.btnMetadata.Location = new System.Drawing.Point(0, 405);
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
            // btnGoToAddWorkout
            // 
            this.btnGoToAddWorkout.FlatAppearance.BorderSize = 0;
            this.btnGoToAddWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToAddWorkout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToAddWorkout.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToAddWorkout.Image")));
            this.btnGoToAddWorkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoToAddWorkout.Location = new System.Drawing.Point(0, 293);
            this.btnGoToAddWorkout.Margin = new System.Windows.Forms.Padding(0);
            this.btnGoToAddWorkout.Name = "btnGoToAddWorkout";
            this.btnGoToAddWorkout.Size = new System.Drawing.Size(200, 34);
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
            // btnUpdateUsers
            // 
            this.btnUpdateUsers.FlatAppearance.BorderSize = 0;
            this.btnUpdateUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUsers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUsers.Image")));
            this.btnUpdateUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUsers.Location = new System.Drawing.Point(0, 215);
            this.btnUpdateUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateUsers.Name = "btnUpdateUsers";
            this.btnUpdateUsers.Size = new System.Drawing.Size(200, 34);
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
            this.btnExit.Location = new System.Drawing.Point(781, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 23);
            this.btnExit.TabIndex = 29;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(754, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(31, 23);
            this.btnMinimize.TabIndex = 30;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(579, 153);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmail.TabIndex = 31;
            // 
            // Workout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(811, 446);
            this.Controls.Add(this.comboBoxEmail);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.txtReps);
            this.Controls.Add(this.txtSets);
            this.Controls.Add(this.txtWorkout);
            this.Controls.Add(this.btnAddWorkout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblReps);
            this.Controls.Add(this.lblSets);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblWorkoutType);
            this.Controls.Add(this.lblAddWorkout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Workout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAddWorkout;
        private System.Windows.Forms.Label lblWorkoutType;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSets;
        private System.Windows.Forms.Label lblReps;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddWorkout;
        private System.Windows.Forms.TextBox txtWorkout;
        private System.Windows.Forms.TextBox txtSets;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
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
        private System.Windows.Forms.ComboBox comboBoxEmail;
    }
}