namespace at_arışı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Ivory;
            label1.Location = new Point(-7, 0);
            label1.Name = "label1";
            label1.Size = new Size(1300, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Ivory;
            label2.Location = new Point(-7, 132);
            label2.Name = "label2";
            label2.Size = new Size(1300, 25);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Ivory;
            label3.Location = new Point(-7, 250);
            label3.Name = "label3";
            label3.Size = new Size(1300, 25);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.BackColor = Color.Ivory;
            label4.Location = new Point(-7, 368);
            label4.Name = "label4";
            label4.Size = new Size(1300, 25);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.BackColor = Color.Ivory;
            label5.Location = new Point(1290, 0);
            label5.Name = "label5";
            label5.Size = new Size(23, 393);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MediumTurquoise;
            label6.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(12, 425);
            label6.Name = "label6";
            label6.Size = new Size(107, 50);
            label6.TabIndex = 5;
            label6.Text = "başla";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 160);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 278);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(99, 87);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label7
            // 
            label7.BackColor = Color.Black;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(332, 405);
            label7.Name = "label7";
            label7.Size = new Size(717, 94);
            label7.TabIndex = 9;
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.Black;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.Tan;
            label8.Location = new Point(1065, 403);
            label8.Name = "label8";
            label8.Size = new Size(137, 94);
            label8.TabIndex = 10;
            label8.Text = "0";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.MediumTurquoise;
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(152, 425);
            label9.Name = "label9";
            label9.Size = new Size(174, 50);
            label9.TabIndex = 11;
            label9.Text = "yeni yarış";
            label9.Click += label9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1305, 496);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
