
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
            this.d2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.U = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(148, 35);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(100, 22);
            this.d2.TabIndex = 1;
            this.d2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Переменная d2";
            // 
            // bb
            // 
            this.bb.Location = new System.Drawing.Point(148, 124);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(100, 22);
            this.bb.TabIndex = 5;
            this.bb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Переменная b";
            // 
            // U
            // 
            this.U.Location = new System.Drawing.Point(136, 319);
            this.U.Name = "U";
            this.U.ReadOnly = true;
            this.U.Size = new System.Drawing.Size(138, 22);
            this.U.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Переменная F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.U);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox d2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox U;
        private System.Windows.Forms.Label label4;
    }
}

