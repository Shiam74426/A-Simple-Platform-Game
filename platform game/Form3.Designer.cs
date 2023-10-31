namespace platform_game
{
    partial class Form3
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
            this.signIn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.passWord_log = new System.Windows.Forms.TextBox();
            this.userName_log = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signIn
            // 
            this.signIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.signIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.Location = new System.Drawing.Point(312, 262);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(98, 34);
            this.signIn.TabIndex = 18;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = false;
            this.signIn.Click += new System.EventHandler(this.signIn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(61, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Password";
            // 
            // passWord_log
            // 
            this.passWord_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.passWord_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord_log.Location = new System.Drawing.Point(178, 185);
            this.passWord_log.Name = "passWord_log";
            this.passWord_log.Size = new System.Drawing.Size(232, 23);
            this.passWord_log.TabIndex = 16;
            // 
            // userName_log
            // 
            this.userName_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userName_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_log.Location = new System.Drawing.Point(178, 112);
            this.userName_log.Name = "userName_log";
            this.userName_log.Size = new System.Drawing.Size(232, 23);
            this.userName_log.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(61, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(59, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Log In";
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Red;
            this.X.Location = new System.Drawing.Point(588, 25);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(31, 23);
            this.X.TabIndex = 19;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.X);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passWord_log);
            this.Controls.Add(this.userName_log);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passWord_log;
        private System.Windows.Forms.TextBox userName_log;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button X;
    }
}