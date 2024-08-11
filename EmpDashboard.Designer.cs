namespace Employee_Management_Application_using_C_.NET
{
    partial class EmpDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpDashboard));
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            checkBox2 = new CheckBox();
            linkLabel2 = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            lgpass_tb = new TextBox();
            loguname_tb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 128);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(lgpass_tb);
            groupBox1.Controls.Add(loguname_tb);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(186, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(772, 485);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 192, 128);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(linkLabel2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(21, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(772, 485);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(273, 381);
            button2.Name = "button2";
            button2.Size = new Size(214, 46);
            button2.TabIndex = 6;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(452, 331);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(132, 24);
            checkBox2.TabIndex = 15;
            checkBox2.Text = "Show Password";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(188, 321);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(117, 20);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forget Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 278);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(396, 27);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(396, 27);
            textBox2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(188, 233);
            label4.Name = "label4";
            label4.Size = new Size(137, 35);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(188, 130);
            label5.Name = "label5";
            label5.Size = new Size(147, 35);
            label5.TabIndex = 10;
            label5.Text = "UserName";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(273, 381);
            button1.Name = "button1";
            button1.Size = new Size(214, 46);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(452, 331);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(188, 321);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(117, 20);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forget Password";
            // 
            // lgpass_tb
            // 
            lgpass_tb.Location = new Point(188, 278);
            lgpass_tb.Name = "lgpass_tb";
            lgpass_tb.PasswordChar = '*';
            lgpass_tb.Size = new Size(396, 27);
            lgpass_tb.TabIndex = 13;
            // 
            // loguname_tb
            // 
            loguname_tb.Location = new Point(188, 168);
            loguname_tb.Name = "loguname_tb";
            loguname_tb.Size = new Size(396, 27);
            loguname_tb.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(188, 233);
            label3.Name = "label3";
            label3.Size = new Size(137, 35);
            label3.TabIndex = 11;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 130);
            label2.Name = "label2";
            label2.Size = new Size(147, 35);
            label2.TabIndex = 10;
            label2.Text = "UserName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(431, 41);
            label1.Name = "label1";
            label1.Size = new Size(328, 36);
            label1.TabIndex = 1;
            label1.Text = "Over All Work Status";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(985, 366);
            button3.Name = "button3";
            button3.Size = new Size(131, 55);
            button3.TabIndex = 38;
            button3.Text = "Employee";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // EmpDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 738);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmpDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmpDashboard";
            Load += EmpDashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PrintPreviewDialog printPreviewDialog1;
        private GroupBox groupBox1;
        private Label label1;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private TextBox lgpass_tb;
        private TextBox loguname_tb;
        private Label label3;
        private Label label2;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
        private CheckBox checkBox2;
        private LinkLabel linkLabel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Button button3;
    }
}