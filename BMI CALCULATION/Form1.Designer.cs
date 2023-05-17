namespace BMI_CALCULATION
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
            label1 = new Label();
            label2 = new Label();
            kiloTextBox = new TextBox();
            heightTextBox = new TextBox();
            statusTextBox = new TextBox();
            calc = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 77);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "KILO : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 123);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 2;
            label2.Text = "HEIGHT :";
            // 
            // kiloTextBox
            // 
            kiloTextBox.Location = new Point(174, 74);
            kiloTextBox.Name = "kiloTextBox";
            kiloTextBox.Size = new Size(125, 27);
            kiloTextBox.TabIndex = 3;
            kiloTextBox.TextChanged += kiloTextBox_TextChanged;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(174, 116);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(125, 27);
            heightTextBox.TabIndex = 4;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(174, 253);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(125, 27);
            statusTextBox.TabIndex = 5;
            // 
            // calc
            // 
            calc.Location = new Point(191, 170);
            calc.Name = "calc";
            calc.Size = new Size(108, 50);
            calc.TabIndex = 6;
            calc.Text = "CALCULATE";
            calc.UseVisualStyleBackColor = true;
            calc.Click += calc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 302);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 450);
            Controls.Add(label3);
            Controls.Add(calc);
            Controls.Add(statusTextBox);
            Controls.Add(heightTextBox);
            Controls.Add(kiloTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BMI CALCULATION";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox kiloTextBox;
        private TextBox heightTextBox;
        private TextBox statusTextBox;
        private Button calc;
        private Label label3;
    }
}