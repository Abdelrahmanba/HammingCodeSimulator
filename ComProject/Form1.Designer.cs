namespace ComProject
{
    partial class Form1
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
            this.input = new System.Windows.Forms.TextBox();
            this.hammed = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.e1 = new System.Windows.Forms.RadioButton();
            this.e2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.e0 = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.corrected = new System.Windows.Forms.TextBox();
            this.recieved = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorL = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(173, 161);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(201, 20);
            this.input.TabIndex = 1;
            this.input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // hammed
            // 
            this.hammed.Location = new System.Drawing.Point(173, 192);
            this.hammed.Name = "hammed";
            this.hammed.ReadOnly = true;
            this.hammed.Size = new System.Drawing.Size(201, 20);
            this.hammed.TabIndex = 2;
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.Location = new System.Drawing.Point(456, 159);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(139, 75);
            this.send.TabIndex = 3;
            this.send.Text = "Send  ↓";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hamming Code Sender/ Reciever";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(144)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(136, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "With One Bit Error Correction";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1.Location = new System.Drawing.Point(249, 235);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(57, 24);
            this.e1.TabIndex = 6;
            this.e1.TabStop = true;
            this.e1.Text = "1 Bit";
            this.e1.UseVisualStyleBackColor = true;
            this.e1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2.Location = new System.Drawing.Point(323, 235);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(63, 24);
            this.e2.TabIndex = 7;
            this.e2.TabStop = true;
            this.e2.Text = "2 Bits";
            this.e2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(436, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "By: AbdelRahman Baba";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(15, 271);
            this.label4.MaximumSize = new System.Drawing.Size(0, 2);
            this.label4.MinimumSize = new System.Drawing.Size(600, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(600, 2);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Value To Be Sent:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Value after Hamming:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 12;
            // 
            // e0
            // 
            this.e0.AutoSize = true;
            this.e0.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e0.Location = new System.Drawing.Point(173, 235);
            this.e0.Name = "e0";
            this.e0.Size = new System.Drawing.Size(63, 24);
            this.e0.TabIndex = 13;
            this.e0.TabStop = true;
            this.e0.Text = "None";
            this.e0.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(17, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Error:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // corrected
            // 
            this.corrected.Location = new System.Drawing.Point(173, 369);
            this.corrected.Name = "corrected";
            this.corrected.ReadOnly = true;
            this.corrected.Size = new System.Drawing.Size(201, 20);
            this.corrected.TabIndex = 15;
            // 
            // recieved
            // 
            this.recieved.Location = new System.Drawing.Point(173, 332);
            this.recieved.Name = "recieved";
            this.recieved.ReadOnly = true;
            this.recieved.Size = new System.Drawing.Size(201, 20);
            this.recieved.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Error:";
            // 
            // errorL
            // 
            this.errorL.AutoSize = true;
            this.errorL.Location = new System.Drawing.Point(263, 292);
            this.errorL.Name = "errorL";
            this.errorL.Size = new System.Drawing.Size(10, 13);
            this.errorL.TabIndex = 18;
            this.errorL.Text = "-";
            this.errorL.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Recieved Data:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Corrected Data:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.errorL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.recieved);
            this.Controls.Add(this.corrected);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.e0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.hammed);
            this.Controls.Add(this.input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox hammed;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton e1;
        private System.Windows.Forms.RadioButton e2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton e0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox corrected;
        private System.Windows.Forms.TextBox recieved;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label errorL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

