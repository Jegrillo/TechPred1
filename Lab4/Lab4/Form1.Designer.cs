
namespace Lab4
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
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.File_change = new System.Windows.Forms.Button();
            this.Text_change = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.panelChooseColor = new System.Windows.Forms.Panel();
            this.Solution = new System.Windows.Forms.Button();
            this.Elements = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(12, 43);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(166, 32);
            this.btnChooseColor.TabIndex = 0;
            this.btnChooseColor.Text = "Выбор цвета";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // File_change
            // 
            this.File_change.Location = new System.Drawing.Point(12, 168);
            this.File_change.Name = "File_change";
            this.File_change.Size = new System.Drawing.Size(166, 35);
            this.File_change.TabIndex = 1;
            this.File_change.Text = "Выбор файла";
            this.File_change.UseVisualStyleBackColor = true;
            this.File_change.Click += new System.EventHandler(this.File_change_Click);
            // 
            // Text_change
            // 
            this.Text_change.Location = new System.Drawing.Point(12, 99);
            this.Text_change.Name = "Text_change";
            this.Text_change.Size = new System.Drawing.Size(166, 39);
            this.Text_change.TabIndex = 2;
            this.Text_change.Text = "Выбор шрифта";
            this.Text_change.UseVisualStyleBackColor = true;
            this.Text_change.Click += new System.EventHandler(this.Text_change_Click);
            // 
            // panelChooseColor
            // 
            this.panelChooseColor.Location = new System.Drawing.Point(284, 43);
            this.panelChooseColor.Name = "panelChooseColor";
            this.panelChooseColor.Size = new System.Drawing.Size(365, 32);
            this.panelChooseColor.TabIndex = 7;
            // 
            // Solution
            // 
            this.Solution.Location = new System.Drawing.Point(324, 384);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(156, 54);
            this.Solution.TabIndex = 8;
            this.Solution.Text = "Рассчитать";
            this.Solution.UseVisualStyleBackColor = true;
            this.Solution.Click += new System.EventHandler(this.Solution_Click);
            // 
            // Elements
            // 
            this.Elements.Location = new System.Drawing.Point(324, 307);
            this.Elements.Name = "Elements";
            this.Elements.Size = new System.Drawing.Size(156, 22);
            this.Elements.TabIndex = 9;
            this.Elements.TextChanged += new System.EventHandler(this.Elements_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Количество элементов";
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(324, 349);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(156, 22);
            this.Answer.TabIndex = 11;
            this.Answer.TextChanged += new System.EventHandler(this.Answer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Решение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Elements);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.panelChooseColor);
            this.Controls.Add(this.Text_change);
            this.Controls.Add(this.File_change);
            this.Controls.Add(this.btnChooseColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button File_change;
        private System.Windows.Forms.Button Text_change;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel panelChooseColor;
        private System.Windows.Forms.Button Solution;
        private System.Windows.Forms.TextBox Elements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label label2;
    }
}

