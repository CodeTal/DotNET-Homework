﻿namespace Homework7
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_leng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_per1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_per2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_th1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_th2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(775, 30);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(94, 40);
            this.drawBtn.TabIndex = 0;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(108, 425);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(82, 25);
            this.textBox_n.TabIndex = 2;
            // 
            // textBox_leng
            // 
            this.textBox_leng.Location = new System.Drawing.Point(366, 425);
            this.textBox_leng.Name = "textBox_leng";
            this.textBox_leng.Size = new System.Drawing.Size(82, 25);
            this.textBox_leng.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(275, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "leng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_per1
            // 
            this.textBox_per1.Location = new System.Drawing.Point(108, 495);
            this.textBox_per1.Name = "textBox_per1";
            this.textBox_per1.Size = new System.Drawing.Size(82, 25);
            this.textBox_per1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "per1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_per2
            // 
            this.textBox_per2.Location = new System.Drawing.Point(366, 495);
            this.textBox_per2.Name = "textBox_per2";
            this.textBox_per2.Size = new System.Drawing.Size(82, 25);
            this.textBox_per2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(275, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "per2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_th1
            // 
            this.textBox_th1.Location = new System.Drawing.Point(108, 556);
            this.textBox_th1.Name = "textBox_th1";
            this.textBox_th1.Size = new System.Drawing.Size(82, 25);
            this.textBox_th1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "th1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_th2
            // 
            this.textBox_th2.Location = new System.Drawing.Point(366, 556);
            this.textBox_th2.Name = "textBox_th2";
            this.textBox_th2.Size = new System.Drawing.Size(82, 25);
            this.textBox_th2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(275, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "th2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_color
            // 
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Items.AddRange(new object[] {"Red", "Blue", "Yellow", "Black"});
            this.comboBox_color.Location = new System.Drawing.Point(709, 425);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(70, 23);
            this.comboBox_color.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(602, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "penColor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 612);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_color);
            this.Controls.Add(this.textBox_th2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_th1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_per2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_per1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_leng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.TextBox textBox_th2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_th1;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox textBox_per2;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox textBox_per1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox_leng;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textextBox_ntBox1;
        private System.Windows.Forms.TextBox textBox_n;

        private System.Windows.Forms.Button drawBtn;

        #endregion
    }
}