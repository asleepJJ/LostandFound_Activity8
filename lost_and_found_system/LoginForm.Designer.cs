namespace lost_and_found_system
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtPassword = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(598, 511);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 390);
            label1.Name = "label1";
            label1.Size = new Size(328, 23);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Our Lost and Found Website!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(136, 428);
            label2.Name = "label2";
            label2.Size = new Size(415, 23);
            label2.TabIndex = 2;
            label2.Text = "We’re excited to help you find and recover lost items.\r\n";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(678, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 480);
            panel1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(168, 405);
            label6.Name = "label6";
            label6.Size = new Size(154, 25);
            label6.TabIndex = 7;
            label6.Text = "Forgot Password?";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(258, 333);
            button2.Name = "button2";
            button2.Size = new Size(114, 49);
            button2.TabIndex = 6;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(120, 333);
            button1.Name = "button1";
            button1.Size = new Size(107, 49);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(46, 263);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(385, 52);
            txtPassword.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 220);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 3;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 110);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 2;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(46, 150);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(385, 52);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(187, 34);
            label3.Name = "label3";
            label3.Size = new Size(135, 50);
            label3.TabIndex = 0;
            label3.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, -32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(217, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1237, 578);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private TextBox txtPassword;
        private Label label5;
        private Label label4;
        private TextBox txtUsername;
        private Label label6;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox2;
    }
}