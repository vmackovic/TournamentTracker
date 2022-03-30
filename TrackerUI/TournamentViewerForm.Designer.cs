
namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.cmbRound = new System.Windows.Forms.ComboBox();
            this.ckbUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.lsbMatchup = new System.Windows.Forms.ListBox();
            this.lblTeamOneName = new System.Windows.Forms.Label();
            this.lblTeamOneScore = new System.Windows.Forms.Label();
            this.txtTeamOneScore = new System.Windows.Forms.TextBox();
            this.txtTeamTwoScore = new System.Windows.Forms.TextBox();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.lblTeamTwoName = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(129, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tournament:";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Location = new System.Drawing.Point(147, 9);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(88, 30);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "<none>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(12, 55);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(73, 30);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round";
            // 
            // cmbRound
            // 
            this.cmbRound.FormattingEnabled = true;
            this.cmbRound.Location = new System.Drawing.Point(91, 52);
            this.cmbRound.Name = "cmbRound";
            this.cmbRound.Size = new System.Drawing.Size(168, 38);
            this.cmbRound.TabIndex = 3;
            // 
            // ckbUnplayedOnly
            // 
            this.ckbUnplayedOnly.AutoSize = true;
            this.ckbUnplayedOnly.Location = new System.Drawing.Point(91, 96);
            this.ckbUnplayedOnly.Name = "ckbUnplayedOnly";
            this.ckbUnplayedOnly.Size = new System.Drawing.Size(168, 34);
            this.ckbUnplayedOnly.TabIndex = 4;
            this.ckbUnplayedOnly.Text = "Unplayed Only";
            this.ckbUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // lsbMatchup
            // 
            this.lsbMatchup.FormattingEnabled = true;
            this.lsbMatchup.ItemHeight = 30;
            this.lsbMatchup.Location = new System.Drawing.Point(21, 154);
            this.lsbMatchup.Name = "lsbMatchup";
            this.lsbMatchup.Size = new System.Drawing.Size(238, 244);
            this.lsbMatchup.TabIndex = 5;
            // 
            // lblTeamOneName
            // 
            this.lblTeamOneName.AutoSize = true;
            this.lblTeamOneName.Location = new System.Drawing.Point(274, 154);
            this.lblTeamOneName.Name = "lblTeamOneName";
            this.lblTeamOneName.Size = new System.Drawing.Size(129, 30);
            this.lblTeamOneName.TabIndex = 6;
            this.lblTeamOneName.Text = "<team one>";
            // 
            // lblTeamOneScore
            // 
            this.lblTeamOneScore.AutoSize = true;
            this.lblTeamOneScore.Location = new System.Drawing.Point(274, 190);
            this.lblTeamOneScore.Name = "lblTeamOneScore";
            this.lblTeamOneScore.Size = new System.Drawing.Size(64, 30);
            this.lblTeamOneScore.TabIndex = 7;
            this.lblTeamOneScore.Text = "Score";
            // 
            // txtTeamOneScore
            // 
            this.txtTeamOneScore.Location = new System.Drawing.Point(351, 187);
            this.txtTeamOneScore.Name = "txtTeamOneScore";
            this.txtTeamOneScore.Size = new System.Drawing.Size(100, 35);
            this.txtTeamOneScore.TabIndex = 8;
            // 
            // txtTeamTwoScore
            // 
            this.txtTeamTwoScore.Location = new System.Drawing.Point(351, 323);
            this.txtTeamTwoScore.Name = "txtTeamTwoScore";
            this.txtTeamTwoScore.Size = new System.Drawing.Size(100, 35);
            this.txtTeamTwoScore.TabIndex = 11;
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.Location = new System.Drawing.Point(274, 326);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(64, 30);
            this.lblTeamTwoScore.TabIndex = 10;
            this.lblTeamTwoScore.Text = "Score";
            // 
            // lblTeamTwoName
            // 
            this.lblTeamTwoName.AutoSize = true;
            this.lblTeamTwoName.Location = new System.Drawing.Point(274, 290);
            this.lblTeamTwoName.Name = "lblTeamTwoName";
            this.lblTeamTwoName.Size = new System.Drawing.Size(128, 30);
            this.lblTeamTwoName.TabIndex = 9;
            this.lblTeamTwoName.Text = "<team two>";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(346, 246);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(37, 30);
            this.lblVS.TabIndex = 12;
            this.lblVS.Text = "VS";
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(464, 237);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(99, 49);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 428);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.txtTeamTwoScore);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.lblTeamTwoName);
            this.Controls.Add(this.txtTeamOneScore);
            this.Controls.Add(this.lblTeamOneScore);
            this.Controls.Add(this.lblTeamOneName);
            this.Controls.Add(this.lsbMatchup);
            this.Controls.Add(this.ckbUnplayedOnly);
            this.Controls.Add(this.cmbRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox cmbRound;
        private System.Windows.Forms.CheckBox ckbUnplayedOnly;
        private System.Windows.Forms.ListBox lsbMatchup;
        private System.Windows.Forms.Label lblTeamOneName;
        private System.Windows.Forms.Label lblTeamOneScore;
        private System.Windows.Forms.TextBox txtTeamOneScore;
        private System.Windows.Forms.TextBox txtTeamTwoScore;
        private System.Windows.Forms.Label lblTeamTwoScore;
        private System.Windows.Forms.Label lblTeamTwoName;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Button btnScore;
    }
}

