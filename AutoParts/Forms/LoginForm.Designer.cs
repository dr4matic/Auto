namespace AutoParts
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PushButton = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PushToRegistrtion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PushButton
            // 
            this.PushButton.Location = new System.Drawing.Point(344, 228);
            this.PushButton.Name = "PushButton";
            this.PushButton.Size = new System.Drawing.Size(100, 23);
            this.PushButton.TabIndex = 0;
            this.PushButton.Text = "Login";
            this.PushButton.UseVisualStyleBackColor = true;
            this.PushButton.Click += new System.EventHandler(this.PushButton_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(344, 157);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 23);
            this.LoginBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(344, 186);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 23);
            this.PasswordBox.TabIndex = 2;
            // 
            // PushToRegistrtion
            // 
            this.PushToRegistrtion.Location = new System.Drawing.Point(344, 257);
            this.PushToRegistrtion.Name = "PushToRegistrtion";
            this.PushToRegistrtion.Size = new System.Drawing.Size(100, 23);
            this.PushToRegistrtion.TabIndex = 3;
            this.PushToRegistrtion.Text = "Registration";
            this.PushToRegistrtion.UseVisualStyleBackColor = true;
            this.PushToRegistrtion.Click += new System.EventHandler(this.PushToRegistrtion_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PushToRegistrtion);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.PushButton);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PushButton;
        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Button PushToRegistrtion;
    }
}