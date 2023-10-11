namespace Sushkov
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button8 = new Button();
            button5 = new Button();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button7 = new Button();
            button6 = new Button();
            label11 = new Label();
            comboBox7 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(982, 453);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 679);
            button1.Name = "button1";
            button1.Size = new Size(120, 30);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(138, 679);
            button2.Name = "button2";
            button2.Size = new Size(120, 30);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(264, 679);
            button3.Name = "button3";
            button3.Size = new Size(120, 30);
            button3.TabIndex = 3;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 473);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 202);
            panel1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(360, 82);
            button4.Name = "button4";
            button4.Size = new Size(120, 30);
            button4.TabIndex = 10;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(166, 162);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(188, 28);
            comboBox3.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(166, 122);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(188, 28);
            comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Понедельник", "Вторник", "Среда", "Четвверг", "Пятница", "Суббота", "Воскресенье" });
            comboBox1.Location = new Point(166, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 28);
            comboBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 29);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 29);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 165);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 4;
            label5.Text = "Маршрут";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 125);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 3;
            label4.Text = "Водитель";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 85);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 2;
            label3.Text = "Конец смены:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 45);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 1;
            label2.Text = "Начало смены:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "День недели:";
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(comboBox4);
            panel2.Controls.Add(comboBox5);
            panel2.Controls.Add(comboBox6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(501, 471);
            panel2.Name = "panel2";
            panel2.Size = new Size(483, 202);
            panel2.TabIndex = 11;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.Location = new Point(927, 679);
            button8.Name = "button8";
            button8.Size = new Size(67, 31);
            button8.TabIndex = 16;
            button8.Text = "Назад";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.Location = new Point(360, 82);
            button5.Name = "button5";
            button5.Size = new Size(120, 30);
            button5.TabIndex = 10;
            button5.Text = "Изменить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(166, 162);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(188, 28);
            comboBox4.TabIndex = 9;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(166, 122);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(188, 28);
            comboBox5.TabIndex = 8;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Понедельник", "Вторник", "Среда", "Четвверг", "Пятница", "Суббота", "Воскресенье" });
            comboBox6.Location = new Point(166, 2);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(188, 28);
            comboBox6.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(188, 29);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(166, 42);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(188, 29);
            textBox4.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 165);
            label6.Name = "label6";
            label6.Size = new Size(85, 21);
            label6.TabIndex = 4;
            label6.Text = "Маршрут";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 125);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 3;
            label7.Text = "Водитель";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 85);
            label8.Name = "label8";
            label8.Size = new Size(121, 21);
            label8.TabIndex = 2;
            label8.Text = "Конец смены:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 45);
            label9.Name = "label9";
            label9.Size = new Size(128, 21);
            label9.TabIndex = 1;
            label9.Text = "Начало смены:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 5);
            label10.Name = "label10";
            label10.Size = new Size(114, 21);
            label10.TabIndex = 0;
            label10.Text = "День недели:";
            // 
            // button7
            // 
            button7.Location = new Point(793, 677);
            button7.Name = "button7";
            button7.Size = new Size(120, 30);
            button7.TabIndex = 15;
            button7.Text = "Отмена";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(667, 677);
            button6.Name = "button6";
            button6.Size = new Size(120, 30);
            button6.TabIndex = 14;
            button6.Text = "Искать";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(389, 682);
            label11.Name = "label11";
            label11.Size = new Size(114, 21);
            label11.TabIndex = 12;
            label11.Text = "День недели:";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Понедельник", "Вторник", "Среда", "Четвверг", "Пятница", "Суббота", "Воскресенье" });
            comboBox7.Location = new Point(509, 679);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(149, 28);
            comboBox7.TabIndex = 11;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(button8);
            Controls.Add(comboBox7);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "ScheduleForm";
            Text = "Расписание";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button4;
        private Panel panel2;
        private Button button5;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button7;
        private Button button6;
        private Label label11;
        private ComboBox comboBox7;
        private Button button8;
    }
}