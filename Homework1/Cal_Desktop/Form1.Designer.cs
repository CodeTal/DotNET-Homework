namespace Homework1
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
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.equalLabel = new System.Windows.Forms.Label();
            this.ansLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opBox = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(190, 242);
            this.num1.Margin = new System.Windows.Forms.Padding(4);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(90, 30);
            this.num1.TabIndex = 0;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(352, 242);
            this.num2.Margin = new System.Windows.Forms.Padding(4);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(86, 30);
            this.num2.TabIndex = 1;
            // 
            // equalLabel
            // 
            this.equalLabel.Location = new System.Drawing.Point(455, 242);
            this.equalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(56, 31);
            this.equalLabel.TabIndex = 2;
            this.equalLabel.Text = "=";
            this.equalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ansLabel
            // 
            this.ansLabel.Location = new System.Drawing.Point(529, 241);
            this.ansLabel.Name = "ansLabel";
            this.ansLabel.Size = new System.Drawing.Size(110, 31);
            this.ansLabel.TabIndex = 3;
            this.ansLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opBox
            // 
            this.opBox.FormattingEnabled = true;
            this.opBox.Items.AddRange(new object[] {"+", "-", "*", "/"});
            this.opBox.Location = new System.Drawing.Point(287, 242);
            this.opBox.Name = "opBox";
            this.opBox.Size = new System.Drawing.Size(58, 28);
            this.opBox.TabIndex = 6;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(384, 370);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(311, 73);
            this.button.TabIndex = 7;
            this.button.Text = "计算";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.button);
            this.Controls.Add(this.opBox);
            this.Controls.Add(this.ansLabel);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button;

        private System.Windows.Forms.ComboBox opBox;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Label ansLabel;

        private System.Windows.Forms.Label equalLabel;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;

        #endregion
    }
}