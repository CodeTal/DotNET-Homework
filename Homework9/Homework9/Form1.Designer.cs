namespace Homework9
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.crawledTextBox = new System.Windows.Forms.TextBox();
            this.failedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(343, 94);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(259, 25);
            this.urlTextBox.TabIndex = 0;
            // 
            // crawledTextBox
            // 
            this.crawledTextBox.Location = new System.Drawing.Point(21, 232);
            this.crawledTextBox.Multiline = true;
            this.crawledTextBox.Name = "crawledTextBox";
            this.crawledTextBox.ReadOnly = true;
            this.crawledTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.crawledTextBox.Size = new System.Drawing.Size(372, 145);
            this.crawledTextBox.TabIndex = 1;
            // 
            // failedTextBox
            // 
            this.failedTextBox.Location = new System.Drawing.Point(554, 232);
            this.failedTextBox.Multiline = true;
            this.failedTextBox.Name = "failedTextBox";
            this.failedTextBox.ReadOnly = true;
            this.failedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.failedTextBox.Size = new System.Drawing.Size(372, 145);
            this.failedTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(267, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "url:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(160, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "已爬取url";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(709, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "错误url";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(441, 433);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(81, 24);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "开始爬取";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 610);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.failedTextBox);
            this.Controls.Add(this.crawledTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox failedTextBox;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox crawledTextBox;
        
        private System.Windows.Forms.Button startButton;

        #endregion
    }
}