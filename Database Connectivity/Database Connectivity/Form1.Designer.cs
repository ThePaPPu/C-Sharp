namespace Database_Connectivity
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 68);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 0;
            label1.Text = "Database IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 124);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 1;
            label2.Text = "Database Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(50, 177);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 3;
            label4.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(220, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(220, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(220, 174);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 31);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(50, 233);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(220, 233);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 31);
            textBox5.TabIndex = 10;
            textBox5.UseSystemPasswordChar = true;
            textBox5.KeyDown += enter;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(232, 302);
            button1.Name = "button1";
            button1.Size = new Size(159, 42);
            button1.TabIndex = 11;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.DarkSlateGray;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.Salmon;
            button2.FlatAppearance.MouseOverBackColor = Color.Salmon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(232, 302);
            button2.Name = "button2";
            button2.Size = new Size(159, 42);
            button2.TabIndex = 12;
            button2.Text = "Disconnect";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Khaki;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderColor = Color.DarkSlateGray;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.Salmon;
            button3.FlatAppearance.MouseOverBackColor = Color.Salmon;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(50, 302);
            button3.Name = "button3";
            button3.Size = new Size(153, 42);
            button3.TabIndex = 13;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 419);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database Connectivity";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}