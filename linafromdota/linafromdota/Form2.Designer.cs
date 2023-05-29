namespace linafromdota
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            dateTimePicker1 = new DateTimePicker();
            button5 = new Button();
            menuStrip1 = new MenuStrip();
            авторToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(236, 344);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(337, 94);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(228, 272);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 1;
            button1.Text = "Заказать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(316, 272);
            button2.Name = "button2";
            button2.Size = new Size(75, 31);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 169);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 3;
            label1.Text = "Дата";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 86);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Виды обуви";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Сапоги", "Сапоожки", "Полусапоги", "Полусаполжки", "Ботинки", "Полуботинки", "Туфли", "Сандалии", "Туфли комнатные", "Сандалеты", "Чувяки", "Мокасины", "Опанки" });
            listBox2.Location = new Point(413, 104);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 199);
            listBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(333, 316);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 7;
            label3.Text = "Список заказов:";
            // 
            // button3
            // 
            button3.Location = new Point(579, 404);
            button3.Name = "button3";
            button3.Size = new Size(75, 34);
            button3.TabIndex = 9;
            button3.Text = "Вниз";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(579, 344);
            button4.Name = "button4";
            button4.Size = new Size(75, 32);
            button4.TabIndex = 8;
            button4.Text = "Вверх";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(204, 189);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button5
            // 
            button5.Location = new Point(708, 37);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 11;
            button5.Text = "Назад";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { авторToolStripMenuItem, выйтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // авторToolStripMenuItem
            // 
            авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            авторToolStripMenuItem.Size = new Size(52, 20);
            авторToolStripMenuItem.Text = "Автор";
            авторToolStripMenuItem.Click += авторToolStripMenuItem_Click;
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(54, 20);
            выйтиToolStripMenuItem.Text = "Выход";
            выйтиToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
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
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Заказ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private Button button3;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private Button button5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem авторToolStripMenuItem;
    }
}