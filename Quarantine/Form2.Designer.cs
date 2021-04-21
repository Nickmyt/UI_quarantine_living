
namespace Quarantine
{
    partial class Thermometer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thermometer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Enter = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 435);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(76, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Θερμομέτρηση";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.PaleGreen;
            this.button2.Location = new System.Drawing.Point(92, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Scan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Font = new System.Drawing.Font("Eras Medium ITC", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Location = new System.Drawing.Point(42, 192);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(164, 172);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(-3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(4, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Πατηστε Scan για να θερμομετρηθείτε";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(67, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.Location = new System.Drawing.Point(605, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ring";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Crimson;
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.X.Location = new System.Drawing.Point(684, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(39, 27);
            this.X.TabIndex = 5;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label5.Location = new System.Drawing.Point(599, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "0:00";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Location = new System.Drawing.Point(12, 8);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(31, 25);
            this.one.TabIndex = 7;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.two.Cursor = System.Windows.Forms.Cursors.Hand;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Location = new System.Drawing.Point(49, 8);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(31, 25);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.three.Cursor = System.Windows.Forms.Cursors.Hand;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Location = new System.Drawing.Point(87, 8);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(31, 25);
            this.three.TabIndex = 9;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.four.Cursor = System.Windows.Forms.Cursors.Hand;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Location = new System.Drawing.Point(12, 39);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(31, 25);
            this.four.TabIndex = 10;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.five.Cursor = System.Windows.Forms.Cursors.Hand;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Location = new System.Drawing.Point(50, 39);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(31, 25);
            this.five.TabIndex = 11;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.six.Cursor = System.Windows.Forms.Cursors.Hand;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Location = new System.Drawing.Point(87, 39);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(31, 25);
            this.six.TabIndex = 12;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.seven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Location = new System.Drawing.Point(12, 70);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(31, 25);
            this.seven.TabIndex = 13;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Location = new System.Drawing.Point(50, 70);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(31, 25);
            this.eight.TabIndex = 14;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Location = new System.Drawing.Point(87, 70);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(31, 25);
            this.nine.TabIndex = 15;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.zero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Location = new System.Drawing.Point(12, 101);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(31, 23);
            this.zero.TabIndex = 16;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.Enter);
            this.panel2.Controls.Add(this.four);
            this.panel2.Controls.Add(this.zero);
            this.panel2.Controls.Add(this.five);
            this.panel2.Controls.Add(this.three);
            this.panel2.Controls.Add(this.nine);
            this.panel2.Controls.Add(this.two);
            this.panel2.Controls.Add(this.six);
            this.panel2.Controls.Add(this.one);
            this.panel2.Controls.Add(this.eight);
            this.panel2.Controls.Add(this.seven);
            this.panel2.Location = new System.Drawing.Point(569, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 127);
            this.panel2.TabIndex = 17;
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Enter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter.Location = new System.Drawing.Point(49, 101);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(68, 23);
            this.Enter.TabIndex = 17;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(250, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 435);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Quarantine.Properties.Resources.bell;
            this.pictureBox1.Location = new System.Drawing.Point(605, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.help.Location = new System.Drawing.Point(359, 400);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(50, 22);
            this.help.TabIndex = 24;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = false;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // Thermometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(722, 434);
            this.Controls.Add(this.help);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.X);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Thermometer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thermometer";
            this.Load += new System.EventHandler(this.Thermometer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button help;
    }
}