
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cmbSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.lblSelectTeamMember = new System.Windows.Forms.Label();
            this.gbAddNewMember = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.lsbTeamMembers = new System.Windows.Forms.ListBox();
            this.btnDeleteSelectedMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.gbAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(26, 91);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(274, 35);
            this.txtTeamName.TabIndex = 13;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(21, 58);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(124, 30);
            this.lblTeamName.TabIndex = 12;
            this.lblTeamName.Text = "Team Name";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(128, 30);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Create Team";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(75, 238);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(190, 49);
            this.btnAddMember.TabIndex = 19;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // cmbSelectTeamMember
            // 
            this.cmbSelectTeamMember.FormattingEnabled = true;
            this.cmbSelectTeamMember.Location = new System.Drawing.Point(26, 179);
            this.cmbSelectTeamMember.Name = "cmbSelectTeamMember";
            this.cmbSelectTeamMember.Size = new System.Drawing.Size(274, 38);
            this.cmbSelectTeamMember.TabIndex = 18;
            // 
            // lblSelectTeamMember
            // 
            this.lblSelectTeamMember.AutoSize = true;
            this.lblSelectTeamMember.Location = new System.Drawing.Point(21, 146);
            this.lblSelectTeamMember.Name = "lblSelectTeamMember";
            this.lblSelectTeamMember.Size = new System.Drawing.Size(207, 30);
            this.lblSelectTeamMember.TabIndex = 17;
            this.lblSelectTeamMember.Text = "Select Team Member";
            // 
            // gbAddNewMember
            // 
            this.gbAddNewMember.Controls.Add(this.btnCreateMember);
            this.gbAddNewMember.Controls.Add(this.txtCellphone);
            this.gbAddNewMember.Controls.Add(this.lblCellphone);
            this.gbAddNewMember.Controls.Add(this.txtEmail);
            this.gbAddNewMember.Controls.Add(this.lblEmail);
            this.gbAddNewMember.Controls.Add(this.txtLastName);
            this.gbAddNewMember.Controls.Add(this.lblLastName);
            this.gbAddNewMember.Controls.Add(this.txtFirstName);
            this.gbAddNewMember.Controls.Add(this.lblFirstName);
            this.gbAddNewMember.Location = new System.Drawing.Point(26, 308);
            this.gbAddNewMember.Name = "gbAddNewMember";
            this.gbAddNewMember.Size = new System.Drawing.Size(274, 264);
            this.gbAddNewMember.TabIndex = 20;
            this.gbAddNewMember.TabStop = false;
            this.gbAddNewMember.Text = "Add New Member";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(133, 34);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(135, 35);
            this.txtFirstName.TabIndex = 10;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(14, 37);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(113, 30);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(133, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(135, 35);
            this.txtLastName.TabIndex = 12;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(14, 78);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 30);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(135, 35);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 119);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 30);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(133, 157);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(135, 35);
            this.txtCellphone.TabIndex = 16;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(14, 160);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(106, 30);
            this.lblCellphone.TabIndex = 15;
            this.lblCellphone.Text = "Cellphone";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.Location = new System.Drawing.Point(49, 202);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(190, 49);
            this.btnCreateMember.TabIndex = 21;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            // 
            // lsbTeamMembers
            // 
            this.lsbTeamMembers.FormattingEnabled = true;
            this.lsbTeamMembers.ItemHeight = 30;
            this.lsbTeamMembers.Location = new System.Drawing.Point(324, 88);
            this.lsbTeamMembers.Name = "lsbTeamMembers";
            this.lsbTeamMembers.Size = new System.Drawing.Size(238, 484);
            this.lsbTeamMembers.TabIndex = 21;
            // 
            // btnDeleteSelectedMember
            // 
            this.btnDeleteSelectedMember.Location = new System.Drawing.Point(568, 88);
            this.btnDeleteSelectedMember.Name = "btnDeleteSelectedMember";
            this.btnDeleteSelectedMember.Size = new System.Drawing.Size(117, 484);
            this.btnDeleteSelectedMember.TabIndex = 22;
            this.btnDeleteSelectedMember.Text = "Delete Selected";
            this.btnDeleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(174, 598);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(258, 58);
            this.btnCreateTeam.TabIndex = 25;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 678);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnDeleteSelectedMember);
            this.Controls.Add(this.lsbTeamMembers);
            this.Controls.Add(this.gbAddNewMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.cmbSelectTeamMember);
            this.Controls.Add(this.lblSelectTeamMember);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.gbAddNewMember.ResumeLayout(false);
            this.gbAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ComboBox cmbSelectTeamMember;
        private System.Windows.Forms.Label lblSelectTeamMember;
        private System.Windows.Forms.GroupBox gbAddNewMember;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ListBox lsbTeamMembers;
        private System.Windows.Forms.Button btnDeleteSelectedMember;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}