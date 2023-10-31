namespace mod3_chapter1_task1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            listBox2 = new ListBox();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "Нижня межа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 19);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Верхня межа";
            // 
            // button1
            // 
            button1.Location = new Point(37, 96);
            button1.Name = "button1";
            button1.Size = new Size(228, 23);
            button1.TabIndex = 4;
            button1.Text = "Почати генерацію";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(17, 179);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 214);
            listBox1.TabIndex = 5;
            listBox1.TabStop = false;
            listBox1.UseTabStops = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 151);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 6;
            label3.Text = "Набір простих чисел";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(165, 179);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 214);
            listBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 151);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 8;
            label4.Text = "Набір чисел Фібоначчі";
            // 
            // button2
            // 
            button2.Location = new Point(17, 416);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 9;
            button2.Text = "Зупинити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(165, 416);
            button3.Name = "button3";
            button3.Size = new Size(123, 23);
            button3.TabIndex = 10;
            button3.Text = "Зупинити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(17, 445);
            button4.Name = "button4";
            button4.Size = new Size(123, 23);
            button4.TabIndex = 11;
            button4.Text = "Відновити";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(165, 445);
            button5.Name = "button5";
            button5.Size = new Size(123, 23);
            button5.TabIndex = 12;
            button5.Text = "Відновити";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(91, 515);
            button6.Name = "button6";
            button6.Size = new Size(123, 23);
            button6.TabIndex = 13;
            button6.Text = "Рестарт";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(310, 571);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private ListBox listBox1;
        private Label label3;
        private ListBox listBox2;
        private Label label4;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}