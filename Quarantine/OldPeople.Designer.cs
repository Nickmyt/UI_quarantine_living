
namespace Quarantine
{
    partial class OldPeople
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
            this.X = new System.Windows.Forms.Button();
            this.sms = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusPA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusMA = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Crimson;
            this.X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.X.Location = new System.Drawing.Point(683, -1);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(39, 27);
            this.X.TabIndex = 14;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // sms
            // 
            this.sms.AutoSize = true;
            this.sms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.sms.Location = new System.Drawing.Point(341, 42);
            this.sms.Name = "sms";
            this.sms.Size = new System.Drawing.Size(86, 18);
            this.sms.TabIndex = 17;
            this.sms.Text = "MONITOR";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.Location = new System.Drawing.Point(434, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Επομενο";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button2.Location = new System.Drawing.Point(216, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 41);
            this.button2.TabIndex = 23;
            this.button2.Text = "Πίσω";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button3.Location = new System.Drawing.Point(329, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 41);
            this.button3.TabIndex = 24;
            this.button3.Text = "SOS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label5.Location = new System.Drawing.Point(0, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "- Σε περιπτωση ανάγκης:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label6.Location = new System.Drawing.Point(125, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Πατηστε SOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label7.Location = new System.Drawing.Point(0, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "- Πατηστε Επόμενο για αλλαγη καμερας";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label8.Location = new System.Drawing.Point(0, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "- Πατηστε Πίσω για αλλαγη καμερας";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(581, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Κατάσταση Παππού";
            // 
            // StatusPA
            // 
            this.StatusPA.AutoSize = true;
            this.StatusPA.BackColor = System.Drawing.Color.Lime;
            this.StatusPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StatusPA.ForeColor = System.Drawing.Color.Black;
            this.StatusPA.Location = new System.Drawing.Point(599, 126);
            this.StatusPA.Name = "StatusPA";
            this.StatusPA.Size = new System.Drawing.Size(75, 29);
            this.StatusPA.TabIndex = 30;
            this.StatusPA.Text = "Καλή";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label3.Location = new System.Drawing.Point(581, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Κατάσταση Γιαγίας";
            // 
            // statusMA
            // 
            this.statusMA.AutoSize = true;
            this.statusMA.BackColor = System.Drawing.Color.Lime;
            this.statusMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.statusMA.ForeColor = System.Drawing.Color.Black;
            this.statusMA.Location = new System.Drawing.Point(599, 236);
            this.statusMA.Name = "statusMA";
            this.statusMA.Size = new System.Drawing.Size(75, 29);
            this.statusMA.TabIndex = 32;
            this.statusMA.Text = "Καλή";
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Quarantine.Properties.Resources.grandpa;
            this.pictureBox1.Location = new System.Drawing.Point(225, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button4.Location = new System.Drawing.Point(3, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 22);
            this.button4.TabIndex = 33;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // OldPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(722, 434);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.statusMA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StatusPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sms);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.X);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OldPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OldPeople";
            this.Load += new System.EventHandler(this.OldPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button X;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sms;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusPA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusMA;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button4;
    }
}