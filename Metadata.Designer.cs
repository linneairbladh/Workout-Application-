using System.Runtime.InteropServices;
using System;
namespace AssignmentProg1
{
    partial class Metadata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metadata));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddUsers = new System.Windows.Forms.Button();
            this.btnMetadata = new System.Windows.Forms.Button();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.btnDeleteWorkout = new System.Windows.Forms.Button();
            this.btnUpdateUsers = new System.Windows.Forms.Button();
            this.btnUpdateWorkout = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnColumnNames = new System.Windows.Forms.Button();
            this.btnNumberOfRows = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMetaData = new System.Windows.Forms.Label();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.navigationPanel.Controls.Add(this.btnAddWorkout);
            this.navigationPanel.Controls.Add(this.btnDeleteWorkout);
            this.navigationPanel.Controls.Add(this.btnUpdateUsers);
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
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(761, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 23);
            this.btnMinimize.TabIndex = 27;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(786, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 23);
            this.btnExit.TabIndex = 28;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnColumnNames
            // 
            this.btnColumnNames.BackColor = System.Drawing.Color.Snow;
            this.btnColumnNames.Location = new System.Drawing.Point(668, 176);
            this.btnColumnNames.Name = "btnColumnNames";
            this.btnColumnNames.Size = new System.Drawing.Size(122, 23);
            this.btnColumnNames.TabIndex = 29;
            this.btnColumnNames.Text = "Column Names";
            this.btnColumnNames.UseVisualStyleBackColor = false;
            this.btnColumnNames.Click += new System.EventHandler(this.btnColumnNames_Click);
            // 
            // btnNumberOfRows
            // 
            this.btnNumberOfRows.BackColor = System.Drawing.Color.Snow;
            this.btnNumberOfRows.Location = new System.Drawing.Point(668, 239);
            this.btnNumberOfRows.Name = "btnNumberOfRows";
            this.btnNumberOfRows.Size = new System.Drawing.Size(122, 23);
            this.btnNumberOfRows.TabIndex = 30;
            this.btnNumberOfRows.Text = "Number of Rows";
            this.btnNumberOfRows.UseVisualStyleBackColor = false;
            this.btnNumberOfRows.Click += new System.EventHandler(this.btnNumberOfRows_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "dataGrid";
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 230);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.ReadOnly = true;
            // 
            // lblMetaData
            // 
            this.lblMetaData.AutoSize = true;
            this.lblMetaData.BackColor = System.Drawing.Color.Transparent;
            this.lblMetaData.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaData.ForeColor = System.Drawing.Color.White;
            this.lblMetaData.Location = new System.Drawing.Point(314, 65);
            this.lblMetaData.Name = "lblMetaData";
            this.lblMetaData.Size = new System.Drawing.Size(289, 23);
            this.lblMetaData.TabIndex = 32;
            this.lblMetaData.Text = "Metadata from Tables Of Interest";
            // 
            // Metadata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(811, 446);
            this.Controls.Add(this.lblMetaData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNumberOfRows);
            this.Controls.Add(this.btnColumnNames);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.navigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Metadata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metadata";
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnAddWorkout;
        private System.Windows.Forms.Button btnDeleteWorkout;
        private System.Windows.Forms.Button btnUpdateUsers;
        private System.Windows.Forms.Button btnUpdateWorkout;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnColumnNames;
        private System.Windows.Forms.Button btnNumberOfRows;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMetaData;
    }
}