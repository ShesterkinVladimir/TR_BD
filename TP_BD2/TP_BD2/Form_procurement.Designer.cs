namespace TP_BD2
{
    partial class Form_procurement
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.номерЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.услугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДеталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоДеталейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewprocurementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPDataSet4 = new TP_BD2.TPDataSet4();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.view_procurementTableAdapter = new TP_BD2.TPDataSet4TableAdapters.view_procurementTableAdapter();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewprocurementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDataSet4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 924);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tabControl1.Size = new System.Drawing.Size(1678, 905);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1662, 858);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерЗаказаDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.услугиDataGridViewTextBoxColumn,
            this.номерДеталиDataGridViewTextBoxColumn,
            this.количествоДеталейDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewprocurementBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1649, 845);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // номерЗаказаDataGridViewTextBoxColumn
            // 
            this.номерЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.номерЗаказаDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.номерЗаказаDataGridViewTextBoxColumn.Name = "номерЗаказаDataGridViewTextBoxColumn";
            this.номерЗаказаDataGridViewTextBoxColumn.Width = 200;
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.HeaderText = "Дата заказа";
            this.датаЗаказаDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            this.датаЗаказаDataGridViewTextBoxColumn.Width = 200;
            // 
            // услугиDataGridViewTextBoxColumn
            // 
            this.услугиDataGridViewTextBoxColumn.DataPropertyName = "Услуги";
            this.услугиDataGridViewTextBoxColumn.HeaderText = "Услуги";
            this.услугиDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.услугиDataGridViewTextBoxColumn.Name = "услугиDataGridViewTextBoxColumn";
            this.услугиDataGridViewTextBoxColumn.Width = 200;
            // 
            // номерДеталиDataGridViewTextBoxColumn
            // 
            this.номерДеталиDataGridViewTextBoxColumn.DataPropertyName = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn.HeaderText = "Номер детали";
            this.номерДеталиDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.номерДеталиDataGridViewTextBoxColumn.Name = "номерДеталиDataGridViewTextBoxColumn";
            this.номерДеталиDataGridViewTextBoxColumn.Width = 200;
            // 
            // количествоДеталейDataGridViewTextBoxColumn
            // 
            this.количествоДеталейDataGridViewTextBoxColumn.DataPropertyName = "Количество деталей";
            this.количествоДеталейDataGridViewTextBoxColumn.HeaderText = "Количество деталей";
            this.количествоДеталейDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.количествоДеталейDataGridViewTextBoxColumn.Name = "количествоДеталейDataGridViewTextBoxColumn";
            this.количествоДеталейDataGridViewTextBoxColumn.Width = 200;
            // 
            // viewprocurementBindingSource
            // 
            this.viewprocurementBindingSource.DataMember = "view_procurement";
            this.viewprocurementBindingSource.DataSource = this.tPDataSet4;
            // 
            // tPDataSet4
            // 
            this.tPDataSet4.DataSetName = "TPDataSet4";
            this.tPDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1662, 858);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изменение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.DarkOrange;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(1409, 811);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 41);
            this.button5.TabIndex = 39;
            this.button5.Text = "Изменить всё";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(1409, 755);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 41);
            this.button4.TabIndex = 25;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBox9.Location = new System.Drawing.Point(355, 717);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(342, 24);
            this.textBox9.TabIndex = 24;
            this.textBox9.Text = "Производитель";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBox8.Location = new System.Drawing.Point(703, 717);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(342, 24);
            this.textBox8.TabIndex = 23;
            this.textBox8.Text = "Цена";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBox7.Location = new System.Drawing.Point(1051, 717);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(342, 24);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "Количество";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(1051, 754);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(342, 38);
            this.textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(703, 754);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(342, 38);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(355, 754);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(342, 38);
            this.textBox3.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBox6.Location = new System.Drawing.Point(7, 717);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(342, 24);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "Описание";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(7, 754);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 38);
            this.textBox2.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(1504, 811);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(405, 817);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1649, 704);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(7, 814);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 38);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // view_procurementTableAdapter
            // 
            this.view_procurementTableAdapter.ClearBeforeFill = true;
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox11.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(589, 934);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(317, 31);
            this.textBox11.TabIndex = 9;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox10.Location = new System.Drawing.Point(220, 934);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(363, 28);
            this.textBox10.TabIndex = 37;
            this.textBox10.Text = "Самая используемая деталь:\r\n\r\n\r\n\r\n";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox12.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox12.Location = new System.Drawing.Point(912, 934);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(363, 28);
            this.textBox12.TabIndex = 39;
            this.textBox12.Text = "Менее используемая деталь:\r\n\r\n\r\n\r\n";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox13.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox13.Location = new System.Drawing.Point(1281, 934);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(317, 31);
            this.textBox13.TabIndex = 38;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // Form_procurement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 981);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form_procurement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_procurement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_procurement_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewprocurementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPDataSet4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TPDataSet4 tPDataSet4;
        private System.Windows.Forms.BindingSource viewprocurementBindingSource;
        private TPDataSet4TableAdapters.view_procurementTableAdapter view_procurementTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn услугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДеталиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоДеталейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
    }
}