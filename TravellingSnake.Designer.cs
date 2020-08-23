using System.Reflection.Emit;

namespace TravelingSnake
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.gameWorld = new System.Windows.Forms.PictureBox();
            this.lblNameScore = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.playingTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimePassed = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblNmeCombinedTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // gameWorld
            // 
            this.gameWorld.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gameWorld.Location = new System.Drawing.Point(12, 60);
            this.gameWorld.Name = "gameWorld";
            this.gameWorld.Size = new System.Drawing.Size(581, 435);
            this.gameWorld.TabIndex = 0;
            this.gameWorld.TabStop = false;
            this.gameWorld.Paint += new System.Windows.Forms.PaintEventHandler(this.gameWorld_Paint);
            // 
            // lblNameScore
            // 
            this.lblNameScore.AutoSize = true;
            this.lblNameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNameScore.Location = new System.Drawing.Point(446, 13);
            this.lblNameScore.Name = "lblNameScore";
            this.lblNameScore.Size = new System.Drawing.Size(87, 25);
            this.lblNameScore.TabIndex = 1;
            this.lblNameScore.Text = " Score:";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblScoreValue.Location = new System.Drawing.Point(541, 13);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(0, 25);
            this.lblScoreValue.TabIndex = 2;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(189, 229);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(193, 29);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "GameOverString";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimePassed
            // 
            this.lblTimePassed.AutoSize = true;
            this.lblTimePassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePassed.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTimePassed.Location = new System.Drawing.Point(13, 15);
            this.lblTimePassed.Name = "lblTimePassed";
            this.lblTimePassed.Size = new System.Drawing.Size(162, 25);
            this.lblTimePassed.TabIndex = 4;
            this.lblTimePassed.Text = "Time Passed: ";
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMinutes.CausesValidation = false;
            this.txtMinutes.Enabled = false;
            this.txtMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMinutes.Location = new System.Drawing.Point(200, 12);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.ReadOnly = true;
            this.txtMinutes.Size = new System.Drawing.Size(29, 31);
            this.txtMinutes.TabIndex = 5;
            this.txtMinutes.Text = "00";
            // 
            // txtSeconds
            // 
            this.txtSeconds.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSeconds.CausesValidation = false;
            this.txtSeconds.Enabled = false;
            this.txtSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeconds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSeconds.Location = new System.Drawing.Point(235, 12);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.ReadOnly = true;
            this.txtSeconds.Size = new System.Drawing.Size(29, 31);
            this.txtSeconds.TabIndex = 6;
            this.txtSeconds.Text = "00";
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtHours.CausesValidation = false;
            this.txtHours.Enabled = false;
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtHours.Location = new System.Drawing.Point(165, 12);
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(29, 31);
            this.txtHours.TabIndex = 7;
            this.txtHours.Text = "00";
            // 
            // lblNmeCombinedTime
            // 
            this.lblNmeCombinedTime.AutoSize = true;
            this.lblNmeCombinedTime.Location = new System.Drawing.Point(168, 43);
            this.lblNmeCombinedTime.Name = "lblNmeCombinedTime";
            this.lblNmeCombinedTime.Size = new System.Drawing.Size(96, 13);
            this.lblNmeCombinedTime.TabIndex = 8;
            this.lblNmeCombinedTime.Text = "Hr    :   Min   :  Sec";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(605, 507);
            this.Controls.Add(this.lblNmeCombinedTime);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.lblTimePassed);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.lblNameScore);
            this.Controls.Add(this.gameWorld);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Travelling Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameWorld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameWorld;
        private System.Windows.Forms.Label lblNameScore;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Timer playingTimeTimer;
        private System.Windows.Forms.Label lblTimePassed;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblNmeCombinedTime;
    }
}

