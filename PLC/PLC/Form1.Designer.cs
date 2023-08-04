namespace PLC
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label14 = new Label();
            label17 = new Label();
            label18 = new Label();
            label20 = new Label();
            label19 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 140);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Caustic Percent";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Orange;
            button1.Location = new Point(95, 31);
            button1.Name = "button1";
            button1.Size = new Size(171, 46);
            button1.TabIndex = 2;
            button1.Text = "Connecting...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 96);
            label2.Name = "label2";
            label2.Size = new Size(223, 27);
            label2.TabIndex = 4;
            label2.Text = "Total Data Inserted: N/A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 183);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 5;
            label3.Text = "Feed Temperature";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 222);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 7;
            label4.Text = "Return Temperature";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(67, 262);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Step Select";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(67, 301);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 11;
            label6.Text = "Tank Filler Select";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(67, 339);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 13;
            label7.Text = "Auto Manual";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(67, 424);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 15;
            label8.Text = "Step-1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(67, 464);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 17;
            label9.Text = "Step-2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(67, 506);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 19;
            label10.Text = "Step-3";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(67, 712);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 31;
            label11.Text = "Caustic Water";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(67, 670);
            label12.Name = "label12";
            label12.Size = new Size(77, 20);
            label12.TabIndex = 29;
            label12.Text = "Hot Water";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(67, 630);
            label13.Name = "label13";
            label13.Size = new Size(102, 20);
            label13.TabIndex = 27;
            label13.Text = "Normal Water";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(67, 587);
            label15.Name = "label15";
            label15.Size = new Size(53, 20);
            label15.TabIndex = 23;
            label15.Text = "Step-5";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(67, 548);
            label16.Name = "label16";
            label16.Size = new Size(53, 20);
            label16.TabIndex = 21;
            label16.Text = "Step-4";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(67, 384);
            label14.Name = "label14";
            label14.Size = new Size(76, 20);
            label14.TabIndex = 33;
            label14.Text = "Auto Start";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(245, 140);
            label17.Name = "label17";
            label17.Size = new Size(36, 20);
            label17.TabIndex = 34;
            label17.Text = "N/A";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(245, 182);
            label18.Name = "label18";
            label18.Size = new Size(36, 20);
            label18.TabIndex = 35;
            label18.Text = "N/A";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(245, 261);
            label20.Name = "label20";
            label20.Size = new Size(36, 20);
            label20.TabIndex = 37;
            label20.Text = "N/A";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(245, 221);
            label19.Name = "label19";
            label19.Size = new Size(36, 20);
            label19.TabIndex = 36;
            label19.Text = "N/A";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(245, 423);
            label24.Name = "label24";
            label24.Size = new Size(36, 20);
            label24.TabIndex = 41;
            label24.Text = "N/A";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(245, 383);
            label23.Name = "label23";
            label23.Size = new Size(36, 20);
            label23.TabIndex = 40;
            label23.Text = "N/A";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(245, 338);
            label22.Name = "label22";
            label22.Size = new Size(36, 20);
            label22.TabIndex = 39;
            label22.Text = "N/A";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(245, 297);
            label21.Name = "label21";
            label21.Size = new Size(36, 20);
            label21.TabIndex = 38;
            label21.Text = "N/A";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(245, 463);
            label25.Name = "label25";
            label25.Size = new Size(36, 20);
            label25.TabIndex = 42;
            label25.Text = "N/A";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(245, 505);
            label26.Name = "label26";
            label26.Size = new Size(36, 20);
            label26.TabIndex = 43;
            label26.Text = "N/A";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(245, 547);
            label27.Name = "label27";
            label27.Size = new Size(36, 20);
            label27.TabIndex = 44;
            label27.Text = "N/A";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(245, 589);
            label28.Name = "label28";
            label28.Size = new Size(36, 20);
            label28.TabIndex = 45;
            label28.Text = "N/A";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(245, 629);
            label29.Name = "label29";
            label29.Size = new Size(36, 20);
            label29.TabIndex = 46;
            label29.Text = "N/A";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(245, 669);
            label30.Name = "label30";
            label30.Size = new Size(36, 20);
            label30.TabIndex = 47;
            label30.Text = "N/A";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(245, 707);
            label31.Name = "label31";
            label31.Size = new Size(36, 20);
            label31.TabIndex = 48;
            label31.Text = "N/A";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 760);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coke Admin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label14;
        private Label label17;
        private Label label18;
        private Label label20;
        private Label label19;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
    }
}