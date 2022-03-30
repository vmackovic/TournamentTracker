
namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.txtPlaceNumber = new System.Windows.Forms.TextBox();
            this.lblPlaceNumber = new System.Windows.Forms.Label();
            this.txtPlaceName = new System.Windows.Forms.TextBox();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.txtPrizeAmount = new System.Windows.Forms.TextBox();
            this.lblPrizeAmount = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblPrizePercentage = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(124, 30);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "Create Prize";
            // 
            // txtPlaceNumber
            // 
            this.txtPlaceNumber.Location = new System.Drawing.Point(182, 58);
            this.txtPlaceNumber.Name = "txtPlaceNumber";
            this.txtPlaceNumber.Size = new System.Drawing.Size(135, 35);
            this.txtPlaceNumber.TabIndex = 14;
            // 
            // lblPlaceNumber
            // 
            this.lblPlaceNumber.AutoSize = true;
            this.lblPlaceNumber.Location = new System.Drawing.Point(12, 61);
            this.lblPlaceNumber.Name = "lblPlaceNumber";
            this.lblPlaceNumber.Size = new System.Drawing.Size(144, 30);
            this.lblPlaceNumber.TabIndex = 13;
            this.lblPlaceNumber.Text = "Place Number";
            // 
            // txtPlaceName
            // 
            this.txtPlaceName.Location = new System.Drawing.Point(182, 103);
            this.txtPlaceName.Name = "txtPlaceName";
            this.txtPlaceName.Size = new System.Drawing.Size(135, 35);
            this.txtPlaceName.TabIndex = 16;
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Location = new System.Drawing.Point(12, 106);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(124, 30);
            this.lblPlaceName.TabIndex = 15;
            this.lblPlaceName.Text = "Place Name";
            // 
            // txtPrizeAmount
            // 
            this.txtPrizeAmount.Location = new System.Drawing.Point(182, 148);
            this.txtPrizeAmount.Name = "txtPrizeAmount";
            this.txtPrizeAmount.Size = new System.Drawing.Size(135, 35);
            this.txtPrizeAmount.TabIndex = 18;
            // 
            // lblPrizeAmount
            // 
            this.lblPrizeAmount.AutoSize = true;
            this.lblPrizeAmount.Location = new System.Drawing.Point(12, 151);
            this.lblPrizeAmount.Name = "lblPrizeAmount";
            this.lblPrizeAmount.Size = new System.Drawing.Size(139, 30);
            this.lblPrizeAmount.TabIndex = 17;
            this.lblPrizeAmount.Text = "Prize Amount";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 249);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 35);
            this.textBox3.TabIndex = 20;
            // 
            // lblPrizePercentage
            // 
            this.lblPrizePercentage.AutoSize = true;
            this.lblPrizePercentage.Location = new System.Drawing.Point(12, 252);
            this.lblPrizePercentage.Name = "lblPrizePercentage";
            this.lblPrizePercentage.Size = new System.Drawing.Size(167, 30);
            this.lblPrizePercentage.TabIndex = 19;
            this.lblPrizePercentage.Text = "Prize Percentage";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(157, 201);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(32, 30);
            this.lblOr.TabIndex = 21;
            this.lblOr.Text = "or";
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.Location = new System.Drawing.Point(66, 307);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(205, 58);
            this.btnCreatePrize.TabIndex = 26;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 377);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblPrizePercentage);
            this.Controls.Add(this.txtPrizeAmount);
            this.Controls.Add(this.lblPrizeAmount);
            this.Controls.Add(this.txtPlaceName);
            this.Controls.Add(this.lblPlaceName);
            this.Controls.Add(this.txtPlaceNumber);
            this.Controls.Add(this.lblPlaceNumber);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtPlaceNumber;
        private System.Windows.Forms.Label lblPlaceNumber;
        private System.Windows.Forms.TextBox txtPlaceName;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.TextBox txtPrizeAmount;
        private System.Windows.Forms.Label lblPrizeAmount;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblPrizePercentage;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Button btnCreatePrize;
    }
}