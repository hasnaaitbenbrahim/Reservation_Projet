namespace Projet
{
    partial class UserControl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            label1 = new Label();
            NewReservation = new Label();
            panel2 = new Panel();
            Salle = new Label();
            checkedListBox1 = new CheckedListBox();
            Cancel = new Button();
            Confirm = new Button();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            endtime = new Label();
            starttime = new Label();
            Date = new Label();
            UserName = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 35);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 17;
            // 
            // NewReservation
            // 
            NewReservation.AutoSize = true;
            NewReservation.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            NewReservation.Location = new Point(222, 15);
            NewReservation.Name = "NewReservation";
            NewReservation.Size = new Size(273, 45);
            NewReservation.TabIndex = 18;
            NewReservation.Text = "New Reservation";
            // 
            // panel2
            // 
            panel2.Controls.Add(Salle);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(Cancel);
            panel2.Controls.Add(Confirm);
            panel2.Controls.Add(dateTimePicker3);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(endtime);
            panel2.Controls.Add(starttime);
            panel2.Controls.Add(Date);
            panel2.Controls.Add(UserName);
            panel2.Controls.Add(NewReservation);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(521, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(720, 543);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // Salle
            // 
            Salle.AutoSize = true;
            Salle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Salle.Location = new Point(109, 178);
            Salle.Name = "Salle";
            Salle.Size = new Size(72, 36);
            Salle.TabIndex = 30;
            Salle.Text = "Salle";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 10F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Salle 1", "Salle 2", "Salle 3", "Salle 4", "Salle 5", "Salle 6", "Salle 7", "Salle 18" });
            checkedListBox1.Location = new Point(275, 178);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(316, 35);
            checkedListBox1.TabIndex = 29;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.Red;
            Cancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Cancel.ForeColor = SystemColors.ButtonHighlight;
            Cancel.Location = new Point(142, 477);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(209, 46);
            Cancel.TabIndex = 28;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            // 
            // Confirm
            // 
            Confirm.BackColor = Color.FromArgb(0, 192, 0);
            Confirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Confirm.ForeColor = SystemColors.ButtonHighlight;
            Confirm.Location = new Point(366, 477);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(209, 46);
            Confirm.TabIndex = 27;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Font = new Font("Segoe UI", 10F);
            dateTimePicker3.Location = new Point(274, 407);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(317, 34);
            dateTimePicker3.TabIndex = 26;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 10F);
            dateTimePicker2.Location = new Point(274, 343);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(317, 34);
            dateTimePicker2.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(275, 278);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(316, 34);
            dateTimePicker1.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(274, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 34);
            textBox1.TabIndex = 23;
            textBox1.Text = "insert User Name";
            // 
            // endtime
            // 
            endtime.AutoSize = true;
            endtime.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            endtime.Location = new Point(109, 402);
            endtime.Name = "endtime";
            endtime.Size = new Size(128, 36);
            endtime.TabIndex = 22;
            endtime.Text = "End Time";
            // 
            // starttime
            // 
            starttime.AutoSize = true;
            starttime.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            starttime.Location = new Point(109, 338);
            starttime.Name = "starttime";
            starttime.Size = new Size(141, 36);
            starttime.TabIndex = 21;
            starttime.Text = "Start Time";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            Date.Location = new Point(109, 273);
            Date.Name = "Date";
            Date.Size = new Size(72, 36);
            Date.TabIndex = 20;
            Date.Text = "Date";
            Date.Click += Date_Click;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            UserName.Location = new Point(109, 106);
            UserName.Name = "UserName";
            UserName.Size = new Size(149, 36);
            UserName.TabIndex = 19;
            UserName.Text = "User Name";
            UserName.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.HotTrack;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 714);
            panel1.TabIndex = 20;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(19, 489);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 43);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(19, 371);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 250);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(76, 633);
            button4.Name = "button4";
            button4.Size = new Size(141, 43);
            button4.TabIndex = 3;
            button4.Text = "LogOut";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(76, 489);
            button3.Name = "button3";
            button3.Size = new Size(190, 47);
            button3.TabIndex = 2;
            button3.Text = "History ";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(76, 371);
            button2.Name = "button2";
            button2.Size = new Size(190, 47);
            button2.TabIndex = 1;
            button2.Text = "Reservation ";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(76, 250);
            button1.Name = "button1";
            button1.Size = new Size(190, 47);
            button1.TabIndex = 0;
            button1.Text = "Home ";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 192);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(302, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1126, 88);
            panel3.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(177, 11);
            label2.Name = "label2";
            label2.Size = new Size(772, 67);
            label2.TabIndex = 1;
            label2.Text = "Meeting Room Booking System";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "UserControl2";
            Size = new Size(1419, 714);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label NewReservation;
        private Panel panel2;
        private Label endtime;
        private Label starttime;
        private Label Date;
        private Label UserName;
        private Button Cancel;
        private Button Confirm;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label Salle;
        private CheckedListBox checkedListBox1;
        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Label label2;
    }
}
