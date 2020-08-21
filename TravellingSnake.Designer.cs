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
            this.gameWorld = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
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
            this.gameWorld.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(80, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = " Score:";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.Location = new System.Drawing.Point(214, 13);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(0, 25);
            this.lblScoreValue.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(605, 507);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.gameWorld);
            this.Name = "frmMain";
            this.Text = "Travelling Snake Game";
            ((System.ComponentModel.ISupportInitialize)(this.gameWorld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameWorld;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreValue;
    }
}

