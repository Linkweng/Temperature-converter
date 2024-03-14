namespace TemperatureConverter_
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(76, 209, 55);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.Submit;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(137, 273);
            button1.Name = "button1";
            button1.Size = new Size(97, 41);
            button1.TabIndex = 0;
            button1.Text = "    SUBMIT";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(43, 78);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 40);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(47, 54, 64);
            label1.Location = new Point(43, 50);
            label1.Name = "label1";
            label1.Size = new Size(122, 19);
            label1.TabIndex = 2;
            label1.Text = "Enter Temperature";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 151, 230);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(43, 209);
            button2.Name = "button2";
            button2.Size = new Size(78, 41);
            button2.TabIndex = 3;
            button2.Text = "Celcius";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(232, 65, 24);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(147, 209);
            button3.Name = "button3";
            button3.Size = new Size(78, 41);
            button3.TabIndex = 4;
            button3.Text = "Farenheit";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(225, 177, 44);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(254, 209);
            button4.Name = "button4";
            button4.Size = new Size(78, 41);
            button4.TabIndex = 5;
            button4.Text = "Kelvin";
            button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 32F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(104, 365);
            label2.Name = "label2";
            label2.Size = new Size(166, 59);
            label2.TabIndex = 6;
            label2.Text = "RESULT";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(118, 140);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "DISPLAY";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(140, 46);
            textBox2.TabIndex = 7;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.FromArgb(47, 54, 64);
            label3.Location = new Point(66, 9);
            label3.Name = "label3";
            label3.Size = new Size(252, 28);
            label3.TabIndex = 8;
            label3.Text = "TEMPERATURE CONVERTER";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 221, 225);
            ClientSize = new Size(390, 450);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            ForeColor = Color.FromArgb(220, 221, 225);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
    }
}
