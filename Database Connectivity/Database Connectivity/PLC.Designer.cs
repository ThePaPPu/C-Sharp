namespace Database_Connectivity
{
    partial class PLC
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
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
            button3.Location = new Point(35, 176);
            button3.Name = "button3";
            button3.Size = new Size(139, 44);
            button3.TabIndex = 24;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            button2.Location = new Point(191, 176);
            button2.Name = "button2";
            button2.Size = new Size(139, 44);
            button2.TabIndex = 23;
            button2.Text = "Disconnect";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button1.Location = new Point(191, 176);
            button1.Name = "button1";
            button1.Size = new Size(139, 44);
            button1.TabIndex = 22;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(148, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 31);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 89);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 14;
            label1.Text = "PLC IP";
            // 
            // PLC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 309);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PLC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PLC Connectivity";
            Load += PLC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}