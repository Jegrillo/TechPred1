
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Makeit = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.TextBox();
            this.equation1 = new System.Windows.Forms.RadioButton();
            this.equation2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Makeit
            // 
            this.Makeit.Location = new System.Drawing.Point(322, 292);
            this.Makeit.Name = "Makeit";
            this.Makeit.Size = new System.Drawing.Size(157, 67);
            this.Makeit.TabIndex = 3;
            this.Makeit.Text = "Выполнить";
            this.Makeit.UseVisualStyleBackColor = true;
            this.Makeit.Click += new System.EventHandler(this.Makeit_Click);
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(36, 42);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(121, 22);
            this.N.TabIndex = 5;
            // 
            // equation1
            // 
            this.equation1.AutoSize = true;
            this.equation1.Location = new System.Drawing.Point(42, 33);
            this.equation1.Name = "equation1";
            this.equation1.Size = new System.Drawing.Size(113, 21);
            this.equation1.TabIndex = 6;
            this.equation1.TabStop = true;
            this.equation1.Text = "Уравнение 1";
            this.equation1.UseVisualStyleBackColor = true;
            // 
            // equation2
            // 
            this.equation2.AutoSize = true;
            this.equation2.Location = new System.Drawing.Point(42, 81);
            this.equation2.Name = "equation2";
            this.equation2.Size = new System.Drawing.Size(113, 21);
            this.equation2.TabIndex = 7;
            this.equation2.TabStop = true;
            this.equation2.Text = "Уравнение 2";
            this.equation2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.equation1);
            this.groupBox1.Controls.Add(this.equation2);
            this.groupBox1.Location = new System.Drawing.Point(562, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор уравнения";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 45);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(18, 17);
            this.label.TabIndex = 9;
            this.label.Text = "N";
            // 
            // R
            // 
            this.R.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.R.Location = new System.Drawing.Point(36, 88);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(121, 24);
            this.R.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "R";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(36, 140);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(121, 22);
            this.X.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "X";
            // 
            // B
            // 
            this.B.FormattingEnabled = true;
            this.B.ItemHeight = 16;
            this.B.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10",
            "15",
            "20",
            "25",
            "50"});
            this.B.Location = new System.Drawing.Point(294, 48);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(185, 116);
            this.B.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "B";
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(99, 17);
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Size = new System.Drawing.Size(157, 22);
            this.Answer.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Результат";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Answer);
            this.groupBox2.Location = new System.Drawing.Point(262, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 50);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "A";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(36, 231);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(121, 22);
            this.A.TabIndex = 22;
            this.A.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(36, 187);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(121, 22);
            this.Y.TabIndex = 23;
            this.Y.TextChanged += new System.EventHandler(this.Y_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R);
            this.Controls.Add(this.label);
            this.Controls.Add(this.N);
            this.Controls.Add(this.Makeit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Makeit;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.RadioButton equation1;
        private System.Windows.Forms.RadioButton equation2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox R;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label label7;
    }
}

