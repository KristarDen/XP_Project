
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
            this.Result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.Label();
            this.GetResult = new System.Windows.Forms.Button();
            this.ArabRadioBut = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RomRadioBut = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(58, 130);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(100, 20);
            this.FirstNumber.TabIndex = 0;
            // 
            // SecondNumber
            // 
            this.SecondNumber.Location = new System.Drawing.Point(260, 130);
            this.SecondNumber.Name = "SecondNumber";
            this.SecondNumber.Size = new System.Drawing.Size(100, 20);
            this.SecondNumber.TabIndex = 1;
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
            this.groupBox1.Controls.Add(this.Result);
            this.groupBox1.Controls.Add(this.Result_label);
            this.groupBox1.Location = new System.Drawing.Point(58, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(47, 0);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 3;
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
            // GetResult
            // 
            this.GetResult.Location = new System.Drawing.Point(171, 178);
            this.GetResult.Name = "GetResult";
            this.GetResult.Size = new System.Drawing.Size(75, 23);
            this.GetResult.TabIndex = 6;
            this.GetResult.Text = "Get result";
            this.GetResult.UseVisualStyleBackColor = true;
            this.GetResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // ArabRadioBut
            // 
            this.ArabRadioBut.AutoSize = true;
            this.ArabRadioBut.Location = new System.Drawing.Point(111, 28);
            this.ArabRadioBut.Name = "ArabRadioBut";
            this.ArabRadioBut.Size = new System.Drawing.Size(55, 17);
            this.ArabRadioBut.TabIndex = 7;
            this.ArabRadioBut.TabStop = true;
            this.ArabRadioBut.Text = "Arabic";
            this.ArabRadioBut.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RomRadioBut);
            this.groupBox2.Controls.Add(this.ArabRadioBut);
            this.groupBox2.Location = new System.Drawing.Point(70, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 65);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choice answer result";
            // 
            // RomRadioBut
            // 
            this.RomRadioBut.AutoSize = true;
            this.RomRadioBut.Location = new System.Drawing.Point(9, 28);
            this.RomRadioBut.Name = "RomRadioBut";
            this.RomRadioBut.Size = new System.Drawing.Size(67, 17);
            this.RomRadioBut.TabIndex = 0;
            this.RomRadioBut.TabStop = true;
            this.RomRadioBut.Text = "Romanic";
            this.RomRadioBut.UseVisualStyleBackColor = true;
            this.RomRadioBut.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GetResult);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SecondNumber);
            this.Controls.Add(this.FirstNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button GetResult;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.RadioButton ArabRadioBut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RomRadioBut;
    }
}

