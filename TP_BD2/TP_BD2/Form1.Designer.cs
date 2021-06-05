namespace TP_BD2
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(150, 47);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(266, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = " Инженер - ремонтник\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(150, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(279, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Менеджер по закупкам\r\n";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(150, 117);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(145, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Бухгалтер\r\n";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(150, 152);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(199, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Администратор";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пароль:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Location = new System.Drawing.Point(150, 207);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(328, 31);
            this.Password.TabIndex = 5;
            this.Password.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input
            // 
            this.input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.input.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.input.BackColor = System.Drawing.Color.ForestGreen;
            this.input.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.input.Location = new System.Drawing.Point(369, 258);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(109, 48);
            this.input.TabIndex = 6;
            this.input.Text = "Войти";
            this.input.UseVisualStyleBackColor = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(564, 349);
            this.Controls.Add(this.input);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно авторизации";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button input;
    }
}

