namespace InClassDemoFive
{
    partial class formMain
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
            this.lblRedWings = new System.Windows.Forms.Label();
            this.tbRedWingScore = new System.Windows.Forms.TextBox();
            this.lblIslanders = new System.Windows.Forms.Label();
            this.tbIslandersScore = new System.Windows.Forms.TextBox();
            this.btnWhoWins = new System.Windows.Forms.Button();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRedWings
            // 
            this.lblRedWings.AutoSize = true;
            this.lblRedWings.Location = new System.Drawing.Point(12, 44);
            this.lblRedWings.Name = "lblRedWings";
            this.lblRedWings.Size = new System.Drawing.Size(63, 13);
            this.lblRedWings.TabIndex = 0;
            this.lblRedWings.Text = "Red Wings:";
            // 
            // tbRedWingScore
            // 
            this.tbRedWingScore.Location = new System.Drawing.Point(78, 41);
            this.tbRedWingScore.Name = "tbRedWingScore";
            this.tbRedWingScore.Size = new System.Drawing.Size(65, 20);
            this.tbRedWingScore.TabIndex = 1;
            // 
            // lblIslanders
            // 
            this.lblIslanders.AutoSize = true;
            this.lblIslanders.Location = new System.Drawing.Point(12, 70);
            this.lblIslanders.Name = "lblIslanders";
            this.lblIslanders.Size = new System.Drawing.Size(49, 13);
            this.lblIslanders.TabIndex = 2;
            this.lblIslanders.Text = "Islanders";
            // 
            // tbIslandersScore
            // 
            this.tbIslandersScore.Location = new System.Drawing.Point(78, 67);
            this.tbIslandersScore.Name = "tbIslandersScore";
            this.tbIslandersScore.Size = new System.Drawing.Size(65, 20);
            this.tbIslandersScore.TabIndex = 3;
            // 
            // btnWhoWins
            // 
            this.btnWhoWins.Location = new System.Drawing.Point(12, 227);
            this.btnWhoWins.Name = "btnWhoWins";
            this.btnWhoWins.Size = new System.Drawing.Size(75, 23);
            this.btnWhoWins.TabIndex = 4;
            this.btnWhoWins.Text = "Who wins?";
            this.btnWhoWins.UseVisualStyleBackColor = true;
            this.btnWhoWins.Click += new System.EventHandler(this.btnWhoWins_Click);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Location = new System.Drawing.Point(197, 227);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(75, 23);
            this.btnExitProgram.TabIndex = 5;
            this.btnExitProgram.Text = "Exit Program";
            this.btnExitProgram.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.btnWhoWins);
            this.Controls.Add(this.tbIslandersScore);
            this.Controls.Add(this.lblIslanders);
            this.Controls.Add(this.tbRedWingScore);
            this.Controls.Add(this.lblRedWings);
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Class Week 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRedWings;
        private System.Windows.Forms.TextBox tbRedWingScore;
        private System.Windows.Forms.Label lblIslanders;
        private System.Windows.Forms.TextBox tbIslandersScore;
        private System.Windows.Forms.Button btnWhoWins;
        private System.Windows.Forms.Button btnExitProgram;
    }
}

