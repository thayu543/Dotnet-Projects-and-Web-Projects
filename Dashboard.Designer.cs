namespace Employee_Management_Application_using_C_.NET
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog2 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 119);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1113, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 33;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Blue;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(416, 41);
            label5.Name = "label5";
            label5.Size = new Size(367, 35);
            label5.TabIndex = 32;
            label5.Text = "Employee management App";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(295, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 422);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(298, 27);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 305);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 27);
            textBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 358);
            label3.Name = "label3";
            label3.Size = new Size(226, 35);
            label3.TabIndex = 17;
            label3.Text = "Employee Salary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 246);
            label2.Name = "label2";
            label2.Size = new Size(220, 35);
            label2.TabIndex = 16;
            label2.Text = "Employee Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 596);
            label7.Name = "label7";
            label7.Size = new Size(205, 35);
            label7.TabIndex = 28;
            label7.Text = "Employee Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 482);
            label6.Name = "label6";
            label6.Size = new Size(298, 35);
            label6.TabIndex = 26;
            label6.Text = "Employee Department";
            label6.Click += label6_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Development", "Hr", "Managing Director" });
            comboBox1.Location = new Point(10, 534);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 31);
            comboBox1.TabIndex = 29;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Senior Level", "Junior Level" });
            comboBox2.Location = new Point(18, 648);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(298, 31);
            comboBox2.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(396, 228);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(753, 343);
            dataGridView1.TabIndex = 32;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(600, 596);
            button2.Name = "button2";
            button2.Size = new Size(94, 55);
            button2.TabIndex = 34;
            button2.Text = "FETCH";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(900, 596);
            button3.Name = "button3";
            button3.Size = new Size(94, 55);
            button3.TabIndex = 35;
            button3.Text = "PRINT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(866, 171);
            button4.Name = "button4";
            button4.Size = new Size(98, 55);
            button4.TabIndex = 36;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Blue;
            button5.Location = new Point(727, 596);
            button5.Name = "button5";
            button5.Size = new Size(106, 55);
            button5.TabIndex = 37;
            button5.Text = "UPDATE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 131);
            label1.Name = "label1";
            label1.Size = new Size(231, 35);
            label1.TabIndex = 38;
            label1.Text = "Search Employee";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(396, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(298, 27);
            textBox3.TabIndex = 39;
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Green;
            button6.Location = new Point(731, 171);
            button6.Name = "button6";
            button6.Size = new Size(102, 55);
            button6.TabIndex = 40;
            button6.Text = "SEARCH";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Blue;
            button7.Location = new Point(459, 596);
            button7.Name = "button7";
            button7.Size = new Size(94, 55);
            button7.TabIndex = 41;
            button7.Text = "ADD";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(16, 190);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(298, 27);
            textBox4.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 131);
            label4.Name = "label4";
            label4.Size = new Size(181, 35);
            label4.TabIndex = 42;
            label4.Text = "Employee ID";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printPreviewDialog2
            // 
            printPreviewDialog2.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog2.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog2.ClientSize = new Size(400, 300);
            printPreviewDialog2.Enabled = true;
            printPreviewDialog2.Icon = (Icon)resources.GetObject("printPreviewDialog2.Icon");
            printPreviewDialog2.Name = "printPreviewDialog2";
            printPreviewDialog2.Visible = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 785);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private TextBox textBox3;
        private Button button6;
        private Button button7;
        private TextBox textBox4;
        private Label label4;
        private PictureBox pictureBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintPreviewDialog printPreviewDialog2;
    }
}