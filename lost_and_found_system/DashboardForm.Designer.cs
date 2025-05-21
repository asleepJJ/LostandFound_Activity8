namespace lost_and_found_system
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button8 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-17, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(121, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 128);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(425, 23);
            label1.Name = "label1";
            label1.Size = new Size(363, 50);
            label1.TabIndex = 0;
            label1.Text = "Lost and Found Log";
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.LightYellow;
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Location = new Point(84, 135);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(140, 416);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // button8
            // 
            button8.Location = new Point(3, 3);
            button8.Name = "button8";
            button8.Size = new Size(108, 43);
            button8.TabIndex = 7;
            button8.Text = "Add User";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 52);
            button4.Name = "button4";
            button4.Size = new Size(108, 45);
            button4.TabIndex = 3;
            button4.Text = "Users";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(3, 103);
            button5.Name = "button5";
            button5.Size = new Size(107, 45);
            button5.TabIndex = 4;
            button5.Text = "Categories";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 154);
            button6.Name = "button6";
            button6.Size = new Size(107, 45);
            button6.TabIndex = 5;
            button6.Text = "Locations";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(3, 205);
            button2.Name = "button2";
            button2.Size = new Size(107, 45);
            button2.TabIndex = 1;
            button2.Text = "Lost Items";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(3, 256);
            button3.Name = "button3";
            button3.Size = new Size(108, 45);
            button3.TabIndex = 2;
            button3.Text = "Found Items";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 307);
            button1.Name = "button1";
            button1.Size = new Size(108, 45);
            button1.TabIndex = 0;
            button1.Text = "Claims";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(3, 358);
            button7.Name = "button7";
            button7.Size = new Size(107, 45);
            button7.TabIndex = 6;
            button7.Text = "Logs";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.LightGoldenrodYellow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(860, 416);
            dataGridView1.TabIndex = 4;
            // 
            // button9
            // 
            button9.Location = new Point(973, 11);
            button9.Name = "button9";
            button9.Size = new Size(120, 29);
            button9.TabIndex = 1;
            button9.Text = "HOMEPAGE";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1237, 578);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            ForeColor = SystemColors.ControlText;
            Name = "DashboardForm";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}