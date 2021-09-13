
namespace WindowsFormsApp1
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
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.SecondNumber = new System.Windows.Forms.TextBox();
            this.Result_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(58, 130);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(100, 20);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.TextChanged += new System.EventHandler(this.FirstNumber_TextChanged);
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(260, 130);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(100, 20);
            this.SecondNumber.TabIndex = 1;
            this.SecondNumber.TextChanged += new System.EventHandler(this.SecondNumber_TextChanged);
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Location = new System.Drawing.Point(6, 16);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(0, 13);
            this.Result_label.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Result_label);
            this.groupBox1.Location = new System.Drawing.Point(58, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First";
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.Location = new System.Drawing.Point(296, 114);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(35, 13);
            this.Second.TabIndex = 5;
            this.Second.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 479);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.TextBox SecondNumber;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Second;
    }
}

