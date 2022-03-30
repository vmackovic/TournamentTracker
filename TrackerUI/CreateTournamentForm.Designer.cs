
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.lblTounramentName = new System.Windows.Forms.Label();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.cmbSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.linklblCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.lsbTournamentPlayers = new System.Windows.Forms.ListBox();
            this.lblTournamentPlayers = new System.Windows.Forms.Label();
            this.btnDeleteSelectedPlayer = new System.Windows.Forms.Button();
            this.btnDeleteSelectedPrize = new System.Windows.Forms.Button();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.lsbPrizes = new System.Windows.Forms.ListBox();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(195, 30);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Create Tournament:";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(26, 91);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(274, 35);
            this.txtTournamentName.TabIndex = 10;
            // 
            // lblTounramentName
            // 
            this.lblTounramentName.AutoSize = true;
            this.lblTounramentName.Location = new System.Drawing.Point(21, 58);
            this.lblTounramentName.Name = "lblTounramentName";
            this.lblTounramentName.Size = new System.Drawing.Size(186, 30);
            this.lblTounramentName.TabIndex = 9;
            this.lblTounramentName.Text = "Tournament Name";
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Location = new System.Drawing.Point(26, 184);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(129, 35);
            this.txtEntryFee.TabIndex = 12;
            this.txtEntryFee.Text = "0";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Location = new System.Drawing.Point(21, 151);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(92, 30);
            this.lblEntryFee.TabIndex = 11;
            this.lblEntryFee.Text = "EntryFee";
            // 
            // cmbSelectTeam
            // 
            this.cmbSelectTeam.FormattingEnabled = true;
            this.cmbSelectTeam.Location = new System.Drawing.Point(26, 271);
            this.cmbSelectTeam.Name = "cmbSelectTeam";
            this.cmbSelectTeam.Size = new System.Drawing.Size(274, 38);
            this.cmbSelectTeam.TabIndex = 14;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Location = new System.Drawing.Point(21, 238);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(123, 30);
            this.lblSelectTeam.TabIndex = 13;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // linklblCreateNewTeam
            // 
            this.linklblCreateNewTeam.AutoSize = true;
            this.linklblCreateNewTeam.Location = new System.Drawing.Point(179, 238);
            this.linklblCreateNewTeam.Name = "linklblCreateNewTeam";
            this.linklblCreateNewTeam.Size = new System.Drawing.Size(121, 30);
            this.linklblCreateNewTeam.TabIndex = 15;
            this.linklblCreateNewTeam.TabStop = true;
            this.linklblCreateNewTeam.Text = "Create New";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(95, 315);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(147, 49);
            this.btnAddTeam.TabIndex = 16;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.Location = new System.Drawing.Point(95, 396);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(147, 49);
            this.btnCreatePrize.TabIndex = 17;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            // 
            // lsbTournamentPlayers
            // 
            this.lsbTournamentPlayers.FormattingEnabled = true;
            this.lsbTournamentPlayers.ItemHeight = 30;
            this.lsbTournamentPlayers.Location = new System.Drawing.Point(343, 91);
            this.lsbTournamentPlayers.Name = "lsbTournamentPlayers";
            this.lsbTournamentPlayers.Size = new System.Drawing.Size(238, 154);
            this.lsbTournamentPlayers.TabIndex = 18;
            // 
            // lblTournamentPlayers
            // 
            this.lblTournamentPlayers.AutoSize = true;
            this.lblTournamentPlayers.Location = new System.Drawing.Point(338, 58);
            this.lblTournamentPlayers.Name = "lblTournamentPlayers";
            this.lblTournamentPlayers.Size = new System.Drawing.Size(147, 30);
            this.lblTournamentPlayers.TabIndex = 19;
            this.lblTournamentPlayers.Text = "Team / Players";
            // 
            // btnDeleteSelectedPlayer
            // 
            this.btnDeleteSelectedPlayer.Location = new System.Drawing.Point(587, 91);
            this.btnDeleteSelectedPlayer.Name = "btnDeleteSelectedPlayer";
            this.btnDeleteSelectedPlayer.Size = new System.Drawing.Size(117, 154);
            this.btnDeleteSelectedPlayer.TabIndex = 20;
            this.btnDeleteSelectedPlayer.Text = "Delete Selected";
            this.btnDeleteSelectedPlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelectedPrize
            // 
            this.btnDeleteSelectedPrize.Location = new System.Drawing.Point(587, 291);
            this.btnDeleteSelectedPrize.Name = "btnDeleteSelectedPrize";
            this.btnDeleteSelectedPrize.Size = new System.Drawing.Size(117, 154);
            this.btnDeleteSelectedPrize.TabIndex = 23;
            this.btnDeleteSelectedPrize.Text = "Delete Selected";
            this.btnDeleteSelectedPrize.UseVisualStyleBackColor = true;
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Location = new System.Drawing.Point(338, 258);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(147, 30);
            this.lblPrizes.TabIndex = 22;
            this.lblPrizes.Text = "Team / Players";
            // 
            // lsbPrizes
            // 
            this.lsbPrizes.FormattingEnabled = true;
            this.lsbPrizes.ItemHeight = 30;
            this.lsbPrizes.Location = new System.Drawing.Point(343, 291);
            this.lsbPrizes.Name = "lsbPrizes";
            this.lsbPrizes.Size = new System.Drawing.Size(238, 154);
            this.lsbPrizes.TabIndex = 21;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Location = new System.Drawing.Point(198, 482);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(258, 58);
            this.btnCreateTournament.TabIndex = 24;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 552);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnDeleteSelectedPrize);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.lsbPrizes);
            this.Controls.Add(this.btnDeleteSelectedPlayer);
            this.Controls.Add(this.lblTournamentPlayers);
            this.Controls.Add(this.lsbTournamentPlayers);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.linklblCreateNewTeam);
            this.Controls.Add(this.cmbSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lblTounramentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.Label lblTounramentName;
        private System.Windows.Forms.TextBox txtEntryFee;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.ComboBox cmbSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.LinkLabel linklblCreateNewTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.ListBox lsbTournamentPlayers;
        private System.Windows.Forms.Label lblTournamentPlayers;
        private System.Windows.Forms.Button btnDeleteSelectedPlayer;
        private System.Windows.Forms.Button btnDeleteSelectedPrize;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.ListBox lsbPrizes;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}