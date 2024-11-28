namespace GeneradorPseudoAleatorio
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
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 190);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 14;
            label6.Text = "[a*X(n)] mod m";
            label6.Click += Label6_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(276, 187);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += TextBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 151);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 13;
            label7.Text = "a*X(n)";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(276, 148);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 11;
            textBox7.TextChanged += TextBox7_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(243, 110);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 16;
            label8.Text = "X(n)}";
            label8.Click += Label8_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(276, 107);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 15;
            textBox8.TextChanged += TextBox8_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(262, 66);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 17;
            label9.Text = "n";
            label9.Click += Label9_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(276, 66);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 18;
            textBox9.TextChanged += TextBox9_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(textBox9);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
    }
}
