namespace ManagerAZC
{
    partial class LogIn
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
            label1 = new Label();
            label2 = new Label();
            user = new TextBox();
            pass = new TextBox();
            login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // user
            // 
            user.Location = new Point(80, 12);
            user.Name = "user";
            user.Size = new Size(182, 23);
            user.TabIndex = 3;
            // 
            // pass
            // 
            pass.Location = new Point(80, 41);
            pass.Name = "pass";
            pass.Size = new Size(182, 23);
            pass.TabIndex = 4;
            // 
            // button1
            // 
            login.Location = new Point(12, 70);
            login.Name = "login";
            login.Size = new Size(250, 23);
            login.TabIndex = 5;
            login.Text = "Log In";
            login.UseVisualStyleBackColor = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 105);
            Controls.Add(login);
            Controls.Add(pass);
            Controls.Add(user);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "LogIn AZC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private Label label1;
        private Label label2;
        private TextBox user;
        private TextBox pass;
    }
}
