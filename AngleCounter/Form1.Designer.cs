namespace AngleCounter
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
            this.label1 = new System.Windows.Forms.Label();
            this.deg_textBox = new System.Windows.Forms.TextBox();
            this.min_textBox = new System.Windows.Forms.TextBox();
            this.sec_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Result_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DegToConvert_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Count2_button = new System.Windows.Forms.Button();
            this.ResultDD_textBox = new System.Windows.Forms.TextBox();
            this.ResultMM_textbox = new System.Windows.Forms.TextBox();
            this.ResultSS_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перевод DD.MM.SS в градусы (в секундах разделитель - запятая)";
            // 
            // deg_textBox
            // 
            this.deg_textBox.Location = new System.Drawing.Point(16, 53);
            this.deg_textBox.Name = "deg_textBox";
            this.deg_textBox.Size = new System.Drawing.Size(29, 20);
            this.deg_textBox.TabIndex = 1;
            this.deg_textBox.Text = "0";
            // 
            // min_textBox
            // 
            this.min_textBox.Location = new System.Drawing.Point(52, 53);
            this.min_textBox.Name = "min_textBox";
            this.min_textBox.Size = new System.Drawing.Size(31, 20);
            this.min_textBox.TabIndex = 2;
            this.min_textBox.Text = "0";
            // 
            // sec_textBox
            // 
            this.sec_textBox.Location = new System.Drawing.Point(90, 53);
            this.sec_textBox.Name = "sec_textBox";
            this.sec_textBox.Size = new System.Drawing.Size(67, 20);
            this.sec_textBox.TabIndex = 3;
            this.sec_textBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Result:";
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Location = new System.Drawing.Point(219, 60);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(0, 13);
            this.Result_label.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DegToConvert_textBox
            // 
            this.DegToConvert_textBox.Location = new System.Drawing.Point(12, 158);
            this.DegToConvert_textBox.Name = "DegToConvert_textBox";
            this.DegToConvert_textBox.Size = new System.Drawing.Size(99, 20);
            this.DegToConvert_textBox.TabIndex = 10;
            this.DegToConvert_textBox.Text = "12,3456789";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Перевод долей градуса в угол формата DD.MM.SS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Result:";
            // 
            // Count2_button
            // 
            this.Count2_button.Location = new System.Drawing.Point(334, 155);
            this.Count2_button.Name = "Count2_button";
            this.Count2_button.Size = new System.Drawing.Size(75, 23);
            this.Count2_button.TabIndex = 14;
            this.Count2_button.Text = "Count";
            this.Count2_button.UseVisualStyleBackColor = true;
            this.Count2_button.Click += new System.EventHandler(this.Count2_button_Click);
            // 
            // ResultDD_textBox
            // 
            this.ResultDD_textBox.Location = new System.Drawing.Point(170, 158);
            this.ResultDD_textBox.Name = "ResultDD_textBox";
            this.ResultDD_textBox.Size = new System.Drawing.Size(29, 20);
            this.ResultDD_textBox.TabIndex = 15;
            this.ResultDD_textBox.Text = "0";
            // 
            // ResultMM_textbox
            // 
            this.ResultMM_textbox.Location = new System.Drawing.Point(205, 158);
            this.ResultMM_textbox.Name = "ResultMM_textbox";
            this.ResultMM_textbox.Size = new System.Drawing.Size(31, 20);
            this.ResultMM_textbox.TabIndex = 16;
            this.ResultMM_textbox.Text = "0";
            // 
            // ResultSS_textBox
            // 
            this.ResultSS_textBox.Location = new System.Drawing.Point(242, 158);
            this.ResultSS_textBox.Name = "ResultSS_textBox";
            this.ResultSS_textBox.Size = new System.Drawing.Size(67, 20);
            this.ResultSS_textBox.TabIndex = 17;
            this.ResultSS_textBox.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "DD";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "MM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "SS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 288);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ResultSS_textBox);
            this.Controls.Add(this.ResultMM_textbox);
            this.Controls.Add(this.ResultDD_textBox);
            this.Controls.Add(this.Count2_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DegToConvert_textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sec_textBox);
            this.Controls.Add(this.min_textBox);
            this.Controls.Add(this.deg_textBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AngleCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deg_textBox;
        private System.Windows.Forms.TextBox min_textBox;
        private System.Windows.Forms.TextBox sec_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DegToConvert_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Count2_button;
        private System.Windows.Forms.TextBox ResultDD_textBox;
        private System.Windows.Forms.TextBox ResultMM_textbox;
        private System.Windows.Forms.TextBox ResultSS_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

