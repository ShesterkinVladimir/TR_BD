namespace TP_BD2
{
    partial class Form_accountant
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
            this.components = new System.ComponentModel.Container();
            this.viewaccountantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPDataSet1 = new TP_BD2.TPDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.tPDataSet = new TP_BD2.TPDataSet();
            this.tPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_accountantTableAdapter = new TP_BD2.TPDataSet1TableAdapters.view_accountantTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.viewaccountantBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tPDataSet5 = new TP_BD2.TPDataSet5();
            this.view_accountantTableAdapter1 = new TP_BD2.TPDataSet5TableAdapters.view_accountantTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewaccountantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDataSetBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewaccountantBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // viewaccountantBindingSource
            // 
            this.viewaccountantBindingSource.DataMember = "view_accountant";
            this.viewaccountantBindingSource.DataSource = this.tPDataSet1;
            // 
            // tPDataSet1
            // 
            this.tPDataSet1.DataSetName = "TPDataSet1";
            this.tPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 700);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tPDataSet
            // 
            this.tPDataSet.DataSetName = "TPDataSet";
            this.tPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPDataSetBindingSource
            // 
            this.tPDataSetBindingSource.DataSource = this.tPDataSet;
            this.tPDataSetBindingSource.Position = 0;
            // 
            // view_accountantTableAdapter
            // 
            this.view_accountantTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1472, 667);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1456, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1443, 607);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1456, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Доп. таблицы";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(908, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(495, 41);
            this.button2.TabIndex = 29;
            this.button2.Text = "Прибыль в текущем месяце с каждой заявки";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(397, 573);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 41);
            this.button4.TabIndex = 28;
            this.button4.Text = "Отсортировать";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBox7.Location = new System.Drawing.Point(7, 542);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(375, 24);
            this.textBox7.TabIndex = 27;
            this.textBox7.Text = "Количество предоставленых услуг";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(7, 572);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(375, 38);
            this.textBox5.TabIndex = 26;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1443, 526);
            this.dataGridView2.TabIndex = 0;
            // 
            // viewaccountantBindingSource1
            // 
            this.viewaccountantBindingSource1.DataMember = "view_accountant";
            this.viewaccountantBindingSource1.DataSource = this.tPDataSet5;
            // 
            // tPDataSet5
            // 
            this.tPDataSet5.DataSetName = "TPDataSet5";
            this.tPDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_accountantTableAdapter1
            // 
            this.view_accountantTableAdapter1.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(586, 573);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(316, 41);
            this.button3.TabIndex = 30;
            this.button3.Text = "Отсортировать по месяцам ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_accountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 757);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form_accountant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_accountant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_accountant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewaccountantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDataSetBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewaccountantBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tPDataSetBindingSource;
        private TPDataSet tPDataSet;
        private TPDataSet1 tPDataSet1;
        private System.Windows.Forms.BindingSource viewaccountantBindingSource;
        private TPDataSet1TableAdapters.view_accountantTableAdapter view_accountantTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TPDataSet5 tPDataSet5;
        private System.Windows.Forms.BindingSource viewaccountantBindingSource1;
        private TPDataSet5TableAdapters.view_accountantTableAdapter view_accountantTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}