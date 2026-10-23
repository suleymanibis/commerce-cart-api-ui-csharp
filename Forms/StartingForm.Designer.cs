namespace E_Commerce_Cart_API_UI
{
    partial class StartingForm
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
            firstNameTB = new TextBox();
            lastNameTB = new TextBox();
            registerEmailTB = new TextBox();
            registerPasswordTB = new TextBox();
            loginEmailTB = new TextBox();
            loginPasswordTB = new TextBox();
            registerButton = new Button();
            loginButton = new Button();
            SuspendLayout();
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(12, 27);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(210, 23);
            firstNameTB.TabIndex = 0;
            // 
            // lastNameTB
            // 
            lastNameTB.Location = new Point(12, 56);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(210, 23);
            lastNameTB.TabIndex = 1;
            // 
            // registerEmailTB
            // 
            registerEmailTB.Location = new Point(12, 85);
            registerEmailTB.Name = "registerEmailTB";
            registerEmailTB.Size = new Size(210, 23);
            registerEmailTB.TabIndex = 2;
            // 
            // registerPasswordTB
            // 
            registerPasswordTB.Location = new Point(12, 114);
            registerPasswordTB.Name = "registerPasswordTB";
            registerPasswordTB.Size = new Size(210, 23);
            registerPasswordTB.TabIndex = 3;
            // 
            // loginEmailTB
            // 
            loginEmailTB.Location = new Point(252, 27);
            loginEmailTB.Name = "loginEmailTB";
            loginEmailTB.Size = new Size(210, 23);
            loginEmailTB.TabIndex = 4;
            // 
            // loginPasswordTB
            // 
            loginPasswordTB.Location = new Point(252, 56);
            loginPasswordTB.Name = "loginPasswordTB";
            loginPasswordTB.Size = new Size(210, 23);
            loginPasswordTB.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(12, 143);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(210, 40);
            registerButton.TabIndex = 6;
            registerButton.Text = "REGISTER";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(252, 85);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(210, 40);
            loginButton.TabIndex = 7;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // StartingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 241);
            Controls.Add(loginButton);
            Controls.Add(registerButton);
            Controls.Add(loginPasswordTB);
            Controls.Add(loginEmailTB);
            Controls.Add(registerPasswordTB);
            Controls.Add(registerEmailTB);
            Controls.Add(lastNameTB);
            Controls.Add(firstNameTB);
            Name = "StartingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private TextBox registerEmailTB;
        private TextBox registerPasswordTB;
        private TextBox loginEmailTB;
        private TextBox loginPasswordTB;
        private Button registerButton;
        private Button loginButton;
    }
}