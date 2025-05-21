namespace lost_and_found_system
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            txtId = new TextBox();
            txtPhone = new TextBox();
            txtConfirmPassword = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtPassword = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtFullName = new TextBox();
            label3 = new Label();
            button5 = new Button();
            textSearch = new TextBox();
            btnSearch = new Button();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-22, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGoldenrodYellow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(590, 398);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(36, 478);
            button1.Name = "button1";
            button1.Size = new Size(103, 50);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.MidnightBlue;
            button2.Location = new Point(144, 479);
            button2.Name = "button2";
            button2.Size = new Size(98, 49);
            button2.TabIndex = 4;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.MidnightBlue;
            button3.Location = new Point(248, 480);
            button3.Name = "button3";
            button3.Size = new Size(94, 49);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.MidnightBlue;
            button4.Location = new Point(348, 479);
            button4.Name = "button4";
            button4.Size = new Size(102, 50);
            button4.TabIndex = 6;
            button4.Text = "Load";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(692, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 554);
            panel1.TabIndex = 16;
            // 
            // txtId
            // 
            txtId.Location = new Point(332, 131);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(78, 38);
            txtId.TabIndex = 17;
            txtId.Visible = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(46, 416);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(385, 38);
            txtPhone.TabIndex = 15;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(46, 330);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(385, 38);
            txtConfirmPassword.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(46, 299);
            label8.Name = "label8";
            label8.Size = new Size(168, 28);
            label8.TabIndex = 13;
            label8.Text = "Confirm Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 378);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 12;
            label7.Text = "Phone Number";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(46, 249);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(385, 38);
            txtPassword.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 218);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 9;
            label6.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(46, 168);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(385, 38);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 137);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 56);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(46, 87);
            txtFullName.Multiline = true;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(385, 38);
            txtFullName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(90, 6);
            label3.Name = "label3";
            label3.Size = new Size(320, 50);
            label3.TabIndex = 0;
            label3.Text = "User Information";
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.MidnightBlue;
            button5.Location = new Point(253, 12);
            button5.Name = "button5";
            button5.Size = new Size(132, 35);
            button5.TabIndex = 17;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textSearch
            // 
            textSearch.Location = new Point(253, 72);
            textSearch.Name = "textSearch";
            textSearch.Size = new Size(180, 27);
            textSearch.TabIndex = 18;
            textSearch.TextChanged += textSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(439, 71);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // button10
            // 
            button10.Location = new Point(539, 72);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 20;
            button10.Text = "Export";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click_1;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1237, 578);
            Controls.Add(button10);
            Controls.Add(btnSearch);
            Controls.Add(textSearch);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Name = "AddUser";
            Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private TextBox txtPhone;
        private TextBox txtConfirmPassword;
        private Label label8;
        private Label label7;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private Label label4;
        private TextBox txtFullName;
        private Label label3;
        private TextBox txtId;
        private Button button5;
        private TextBox textSearch;
        private Button btnSearch;
        private Button button10;
    }
}