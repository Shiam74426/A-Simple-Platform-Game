namespace platform_game
{
    partial class scoreSave
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
            this.txtScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(214, 163);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(281, 70);
            this.txtScore.TabIndex = 1;
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Score is : 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 70);
            this.label2.TabIndex = 3;
            this.label2.Text = "High Score : 0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // scoreSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(603, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScore);
            this.Name = "scoreSave";
            this.Text = "scoreSave";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer gameTimer;
    }
}