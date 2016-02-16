namespace loginScreens
{
    partial class LogIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterButton = new System.Windows.Forms.Button();
            this.usernameIn = new System.Windows.Forms.TextBox();
            this.passwordIn = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.wrongLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(266, 190);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 0;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // usernameIn
            // 
            this.usernameIn.Location = new System.Drawing.Point(266, 100);
            this.usernameIn.Name = "usernameIn";
            this.usernameIn.Size = new System.Drawing.Size(100, 20);
            this.usernameIn.TabIndex = 1;
            // 
            // passwordIn
            // 
            this.passwordIn.Location = new System.Drawing.Point(266, 155);
            this.passwordIn.Name = "passwordIn";
            this.passwordIn.Size = new System.Drawing.Size(100, 20);
            this.passwordIn.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(93, 106);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(56, 13);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "username:";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(93, 162);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(55, 13);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "password:";
            // 
            // wrongLoginLabel
            // 
            this.wrongLoginLabel.AutoSize = true;
            this.wrongLoginLabel.Location = new System.Drawing.Point(247, 216);
            this.wrongLoginLabel.Name = "wrongLoginLabel";
            this.wrongLoginLabel.Size = new System.Drawing.Size(131, 13);
            this.wrongLoginLabel.TabIndex = 5;
            this.wrongLoginLabel.Text = "Incorrect login information.";
            this.wrongLoginLabel.Visible = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.wrongLoginLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passwordIn);
            this.Controls.Add(this.usernameIn);
            this.Controls.Add(this.enterButton);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(500, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox usernameIn;
        private System.Windows.Forms.TextBox passwordIn;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label wrongLoginLabel;
    }
}
