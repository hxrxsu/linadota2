namespace linafromdota
{
    partial class Партии
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Партии));
            button5 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            listBox2 = new ListBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(707, 10);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 22;
            button5.Text = "Назад";
            button5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(220, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 21;
            // 
            // button3
            // 
            button3.Location = new Point(579, 382);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 20;
            button3.Text = "Вниз";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(579, 311);
            button4.Name = "button4";
            button4.Size = new Size(75, 35);
            button4.TabIndex = 19;
            button4.Text = "Вверх";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(332, 289);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 18;
            label3.Text = "Список заказов:";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Босоножки Aether", "Сапоги Primo", "Тяги Quieto", "Тапочки One Piece" });
            listBox2.Location = new Point(432, 188);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 64);
            listBox2.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(456, 170);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 16;
            label2.Text = "Партии";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 142);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 15;
            label1.Text = "Дата";
            // 
            // button2
            // 
            button2.Location = new Point(328, 240);
            button2.Name = "button2";
            button2.Size = new Size(75, 36);
            button2.TabIndex = 14;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(240, 240);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 13;
            button1.Text = "Заказать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(235, 317);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(337, 94);
            listBox1.TabIndex = 12;
            // 
            // Партии
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Партии";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private DateTimePicker dateTimePicker1;
        private Button button3;
        private Button button4;
        private Label label3;
        private ListBox listBox2;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private ListBox listBox1;
    }
}