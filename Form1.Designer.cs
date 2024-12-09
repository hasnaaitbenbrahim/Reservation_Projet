namespace Projet
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            textBox_Password = new TextBox();
            textBox_Username = new TextBox();
            LoginButton = new Button();
            Username = new Label();
            Password = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBox_Password);
            panel1.Controls.Add(textBox_Username);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(Password);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(104, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 480);
            panel1.TabIndex = 0;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(178, 279);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(284, 31);
            textBox_Password.TabIndex = 6;
            // 
            // textBox_Username
            // 
            textBox_Username.Location = new Point(178, 180);
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(284, 31);
            textBox_Username.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(0, 192, 192);
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LoginButton.ForeColor = SystemColors.HighlightText;
            LoginButton.Location = new Point(55, 397);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(407, 53);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Username.ForeColor = SystemColors.Desktop;
            Username.Location = new Point(28, 177);
            Username.Name = "Username";
            Username.Size = new Size(128, 32);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Password.ForeColor = SystemColors.Desktop;
            Password.Location = new Point(28, 276);
            Password.Name = "Password";
            Password.Size = new Size(122, 32);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(164, 47);
            label1.Name = "label1";
            label1.Size = new Size(177, 67);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(799, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 480);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1397, 658);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button LoginButton;
        private Label Username;
        private Label Password;
        private Label label1;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private PictureBox pictureBox1;
    }
}
