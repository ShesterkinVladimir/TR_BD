using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_BD2
{
    public partial class Form_admin : Form
    {
        public Form_admin()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells
            dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells
            dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells
            dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells

        }

        private void Form_admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tPDataSet14.order_service". При необходимости она может быть перемещена или удалена.
            this.order_serviceTableAdapter.Fill(this.tPDataSet14.order_service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tPDataSet13.order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.tPDataSet13.order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tPDataSet12.spare_part_service". При необходимости она может быть перемещена или удалена.
            this.spare_part_serviceTableAdapter.Fill(this.tPDataSet12.spare_part_service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tPDataSet11.service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.tPDataSet11.service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tPDataSet10.spares". При необходимости она может быть перемещена или удалена.
            this.sparesTableAdapter.Fill(this.tPDataSet10.spares);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tPDataSet9.worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.tPDataSet9.worker);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tPDataSet8.client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.tPDataSet8.client);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }


    }
}