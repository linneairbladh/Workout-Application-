using System.Runtime.InteropServices;
using System;
namespace AssignmentProg1
{
    partial class DeleteWorkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteWorkout));
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
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
            this.lblDeleteWorkout = new System.Windows.Forms.Label();
            this.lblDeleteInstruction = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDelete.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.Location = new System.Drawing.Point(218, 92);
            this.dataGridViewDelete.MultiSelect = false;
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.RowHeadersWidth = 62;
            this.dataGridViewDelete.Size = new System.Drawing.Size(570, 249);
            this.dataGridViewDelete.TabIndex = 0;
            this.dataGridViewDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDelete_CellClick);

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
            this.navigationPanel.TabIndex = 25;
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
            // lblDeleteWorkout
            // 
            this.lblDeleteWorkout.AutoSize = true;
            this.lblDeleteWorkout.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteWorkout.ForeColor = System.Drawing.Color.White;
            this.lblDeleteWorkout.Location = new System.Drawing.Point(435, 47);
            this.lblDeleteWorkout.Name = "lblDeleteWorkout";
            this.lblDeleteWorkout.Size = new System.Drawing.Size(136, 23);
            this.lblDeleteWorkout.TabIndex = 2;
            this.lblDeleteWorkout.Text = "Delete workout";
            // 
            // lblDeleteInstruction
            // 
            this.lblDeleteInstruction.AutoSize = true;
            this.lblDeleteInstruction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteInstruction.ForeColor = System.Drawing.Color.White;
            this.lblDeleteInstruction.Location = new System.Drawing.Point(218, 359);
            this.lblDeleteInstruction.Name = "lblDeleteInstruction";
            this.lblDeleteInstruction.Size = new System.Drawing.Size(172, 19);
            this.lblDeleteInstruction.TabIndex = 3;
            this.lblDeleteInstruction.Text = "How to delete Workout";
            this.lblDeleteInstruction.Click += new System.EventHandler(this.lblDeleteInstruction_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(782, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 23);
            this.btnExit.TabIndex = 26;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(757, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(31, 23);
            this.btnMinimize.TabIndex = 25;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // DeleteWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(811, 446);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.lblDeleteInstruction);
            this.Controls.Add(this.lblDeleteWorkout);
            this.Controls.Add(this.dataGridViewDelete);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteWorkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteWorkout";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDelete;
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
        private System.Windows.Forms.Label lblDeleteWorkout;
        private System.Windows.Forms.Label lblDeleteInstruction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
    }
}