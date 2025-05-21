namespace lost_and_found_system
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(136, 428);
            label2.Name = "label2";
            label2.Size = new Size(415, 23);
            label2.TabIndex = 8;
            label2.Text = "We’re excited to help you find and recover lost items.\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 390);
            label1.Name = "label1";
            label1.Size = new Size(328, 23);
            label1.TabIndex = 7;
            label1.Text = "Welcome to Our Lost and Found Website!";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(53, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(598, 511);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(711, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 480);
            panel1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 338);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(385, 46);
            textBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 307);
            label6.Name = "label6";
            label6.Size = new Size(168, 28);
            label6.TabIndex = 9;
            label6.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 246);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 46);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(189, 411);
            button1.Name = "button1";
            button1.Size = new Size(107, 49);
            button1.TabIndex = 5;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 202);
            label5.Name = "label5";
            label5.Size = new Size(137, 28);
            label5.TabIndex = 3;
            label5.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 97);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(46, 139);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(385, 46);
            txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(87, 24);
            label3.Name = "label3";
            label3.Size = new Size(314, 50);
            label3.TabIndex = 0;
            label3.Text = "Forgot Password";
            label3.Click += label3_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1237, 578);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Name = "ForgotPassword";
            Text = "Forgot Password";
            Load += ForgotPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Button button1;
        private Label label5;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
    }
}