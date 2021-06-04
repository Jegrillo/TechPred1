
namespace lab3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.solution = new System.Windows.Forms.ToolStripMenuItem();
            this.const_a = new System.Windows.Forms.ToolStripComboBox();
            this.const_b = new System.Windows.Forms.ToolStripComboBox();
            this.perem_x = new System.Windows.Forms.ToolStripTextBox();
            this.perem_y = new System.Windows.Forms.ToolStripTextBox();
            this.perem_z = new System.Windows.Forms.ToolStripTextBox();
            this.reshenie = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Context_const_a = new System.Windows.Forms.ToolStripComboBox();
            this.Context_const_b = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Context_perem_x = new System.Windows.Forms.ToolStripTextBox();
            this.Context_perem_y = new System.Windows.Forms.ToolStripTextBox();
            this.Context_perem_z = new System.Windows.Forms.ToolStripTextBox();
            this.Context_reshenie = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemDate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.sqt_xy = new System.Windows.Forms.ToolStripMenuItem();
            this.uravnenie_xy = new System.Windows.Forms.ToolStripMenuItem();
            this.vivod_xy = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.timerDateTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.solution});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Color";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComboBox2,
            this.toolStripTextBox4,
            this.toolStripTextBox5,
            this.toolStripTextBox6,
            this.toolStripSeparator2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem2.Text = "Color";
            // 
            // ComboBox2
            // 
            this.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox2.Items.AddRange(new object[] {
            "Белый",
            "Красный",
            "Черный",
            "Синий",
            "Желтый "});
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(121, 28);
            this.ComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox4.Text = "0";
            this.toolStripTextBox4.ToolTipText = "Красный";
            this.toolStripTextBox4.TextChanged += new System.EventHandler(this.toolStripTextBox4_TextChanged);
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox5.Text = "0";
            this.toolStripTextBox5.ToolTipText = "Зеленый";
            this.toolStripTextBox5.TextChanged += new System.EventHandler(this.toolStripTextBox5_TextChanged);
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox6.Text = "0";
            this.toolStripTextBox6.ToolTipText = "Синий";
            this.toolStripTextBox6.TextChanged += new System.EventHandler(this.toolStripTextBox6_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(195, 26);
            this.toolStripMenuItem3.Text = "Exit";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // solution
            // 
            this.solution.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.const_a,
            this.const_b,
            this.perem_x,
            this.perem_y,
            this.perem_z,
            this.reshenie});
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(100, 24);
            this.solution.Text = "Уравнение";
            // 
            // const_a
            // 
            this.const_a.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10",
            "15",
            "20",
            "25",
            "50",
            "100"});
            this.const_a.Name = "const_a";
            this.const_a.Size = new System.Drawing.Size(121, 28);
            this.const_a.Text = "Константа а";
            this.const_a.TextChanged += new System.EventHandler(this.const_a_TextChanged);
            // 
            // const_b
            // 
            this.const_b.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10",
            "15",
            "20",
            "25",
            "50",
            "100"});
            this.const_b.Name = "const_b";
            this.const_b.Size = new System.Drawing.Size(121, 28);
            this.const_b.Text = "Константа b";
            this.const_b.TextChanged += new System.EventHandler(this.const_b_TextChanged);
            // 
            // perem_x
            // 
            this.perem_x.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.perem_x.Name = "perem_x";
            this.perem_x.Size = new System.Drawing.Size(100, 27);
            this.perem_x.ToolTipText = "Переменная x";
            this.perem_x.TextChanged += new System.EventHandler(this.perem_x_TextChanged);
            // 
            // perem_y
            // 
            this.perem_y.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.perem_y.Name = "perem_y";
            this.perem_y.Size = new System.Drawing.Size(100, 27);
            this.perem_y.ToolTipText = "Переменная y";
            this.perem_y.TextChanged += new System.EventHandler(this.perem_y_TextChanged);
            // 
            // perem_z
            // 
            this.perem_z.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.perem_z.Name = "perem_z";
            this.perem_z.Size = new System.Drawing.Size(100, 27);
            this.perem_z.ToolTipText = "Переменная z";
            this.perem_z.TextChanged += new System.EventHandler(this.perem_z_TextChanged);
            // 
            // reshenie
            // 
            this.reshenie.Name = "reshenie";
            this.reshenie.Size = new System.Drawing.Size(224, 26);
            this.reshenie.Text = "Вычислить";
            this.reshenie.Click += new System.EventHandler(this.reshenie_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu2,
            this.toolStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 52);
            // 
            // menu2
            // 
            this.menu2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripTextBox3,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(155, 24);
            this.menu2.Text = "Color";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Белый",
            "Красный",
            "Черный",
            "Синий",
            "Желтый "});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged_1);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Красный";
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Зеленый";
            this.toolStripTextBox2.TextChanged += new System.EventHandler(this.toolStripTextBox2_TextChanged);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Синий";
            this.toolStripTextBox3.TextChanged += new System.EventHandler(this.toolStripTextBox3_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 26);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Context_const_a,
            this.Context_const_b,
            this.toolStripSeparator3,
            this.Context_perem_x,
            this.Context_perem_y,
            this.Context_perem_z,
            this.Context_reshenie});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(155, 24);
            this.toolStripMenuItem4.Text = "Уравнение";
            // 
            // Context_const_a
            // 
            this.Context_const_a.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10",
            "15",
            "20",
            "25",
            "50",
            "100"});
            this.Context_const_a.Name = "Context_const_a";
            this.Context_const_a.Size = new System.Drawing.Size(121, 28);
            this.Context_const_a.Text = "Константа а";
            this.Context_const_a.TextChanged += new System.EventHandler(this.Context_const_a_TextChanged);
            // 
            // Context_const_b
            // 
            this.Context_const_b.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10",
            "15",
            "20",
            "25",
            "50",
            "100"});
            this.Context_const_b.Name = "Context_const_b";
            this.Context_const_b.Size = new System.Drawing.Size(121, 28);
            this.Context_const_b.Text = "Константа b";
            this.Context_const_b.TextChanged += new System.EventHandler(this.Context_const_b_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // Context_perem_x
            // 
            this.Context_perem_x.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Context_perem_x.Name = "Context_perem_x";
            this.Context_perem_x.Size = new System.Drawing.Size(100, 27);
            this.Context_perem_x.ToolTipText = "Переменная x";
            this.Context_perem_x.TextChanged += new System.EventHandler(this.Context_perem_x_TextChanged);
            // 
            // Context_perem_y
            // 
            this.Context_perem_y.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Context_perem_y.Name = "Context_perem_y";
            this.Context_perem_y.Size = new System.Drawing.Size(100, 27);
            this.Context_perem_y.ToolTipText = "Переменная y";
            this.Context_perem_y.TextChanged += new System.EventHandler(this.Context_perem_y_TextChanged);
            // 
            // Context_perem_z
            // 
            this.Context_perem_z.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Context_perem_z.Name = "Context_perem_z";
            this.Context_perem_z.Size = new System.Drawing.Size(100, 27);
            this.Context_perem_z.TextChanged += new System.EventHandler(this.Context_perem_z_TextChanged);
            // 
            // Context_reshenie
            // 
            this.Context_reshenie.Name = "Context_reshenie";
            this.Context_reshenie.Size = new System.Drawing.Size(195, 26);
            this.Context_reshenie.Text = "Вычислить";
            this.Context_reshenie.Click += new System.EventHandler(this.Context_reshenie_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelState,
            this.toolStripStatusLabelClock,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.vivod_xy,
            this.toolStripDropDownButton3});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 420);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(800, 30);
            this.MainStatusStrip.TabIndex = 2;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelState
            // 
            this.toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            this.toolStripStatusLabelState.Size = new System.Drawing.Size(494, 24);
            this.toolStripStatusLabelState.Spring = true;
            this.toolStripStatusLabelState.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolStripStatusLabelClock
            // 
            this.toolStripStatusLabelClock.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelClock.Name = "toolStripStatusLabelClock";
            this.toolStripStatusLabelClock.Size = new System.Drawing.Size(41, 24);
            this.toolStripStatusLabelClock.Text = "       ";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDate,
            this.toolStripMenuItemTime});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItemDate
            // 
            this.toolStripMenuItemDate.Checked = true;
            this.toolStripMenuItemDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemDate.Name = "toolStripMenuItemDate";
            this.toolStripMenuItemDate.Size = new System.Drawing.Size(198, 26);
            this.toolStripMenuItemDate.Text = "Текущая дата";
            this.toolStripMenuItemDate.Click += new System.EventHandler(this.toolStripMenuItemDate_Click);
            // 
            // toolStripMenuItemTime
            // 
            this.toolStripMenuItemTime.Name = "toolStripMenuItemTime";
            this.toolStripMenuItemTime.Size = new System.Drawing.Size(198, 26);
            this.toolStripMenuItemTime.Text = "Текущее время";
            this.toolStripMenuItemTime.Click += new System.EventHandler(this.toolStripMenuItemTime_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sqt_xy,
            this.uravnenie_xy});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // sqt_xy
            // 
            this.sqt_xy.Checked = true;
            this.sqt_xy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sqt_xy.Name = "sqt_xy";
            this.sqt_xy.Size = new System.Drawing.Size(224, 26);
            this.sqt_xy.Text = "Выражение 1";
            this.sqt_xy.Click += new System.EventHandler(this.sqt_xy_Click);
            // 
            // uravnenie_xy
            // 
            this.uravnenie_xy.Name = "uravnenie_xy";
            this.uravnenie_xy.Size = new System.Drawing.Size(224, 26);
            this.uravnenie_xy.Text = "Выражение 2";
            // 
            // vivod_xy
            // 
            this.vivod_xy.Name = "vivod_xy";
            this.vivod_xy.Size = new System.Drawing.Size(109, 24);
            this.vivod_xy.Text = "                         ";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(34, 28);
            this.toolStripDropDownButton3.Text = "toolStripDropDownButton3";
            // 
            // timerDateTimeUpdate
            // 
            this.timerDateTimeUpdate.Enabled = true;
            this.timerDateTimeUpdate.Interval = 1000;
            this.timerDateTimeUpdate.Tick += new System.EventHandler(this.timerDateTimeUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripComboBox ComboBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelClock;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTime;
        private System.Windows.Forms.Timer timerDateTimeUpdate;
        private System.Windows.Forms.ToolStripMenuItem solution;
        private System.Windows.Forms.ToolStripComboBox const_a;
        private System.Windows.Forms.ToolStripComboBox const_b;
        private System.Windows.Forms.ToolStripTextBox perem_x;
        private System.Windows.Forms.ToolStripTextBox perem_y;
        private System.Windows.Forms.ToolStripTextBox perem_z;
        private System.Windows.Forms.ToolStripMenuItem reshenie;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem sqt_xy;
        private System.Windows.Forms.ToolStripMenuItem uravnenie_xy;
        private System.Windows.Forms.ToolStripStatusLabel vivod_xy;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripComboBox Context_const_a;
        private System.Windows.Forms.ToolStripComboBox Context_const_b;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox Context_perem_x;
        private System.Windows.Forms.ToolStripTextBox Context_perem_y;
        private System.Windows.Forms.ToolStripTextBox Context_perem_z;
        private System.Windows.Forms.ToolStripMenuItem Context_reshenie;
    }
}

