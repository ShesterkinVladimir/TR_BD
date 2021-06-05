using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TP_BD2
{
    public partial class Form_accountant : Form
    {


        public SqlConnection conn = new SqlConnection("Data source =DESKTOP-42QTCGA ; Initial Catalog = TP; Integrated Security = True");

        public DataTable Command(string str)
        {
            try
            {
                using (SqlCommand sql = conn.CreateCommand())
                {
                    SqlDataAdapter sqlDA = new SqlDataAdapter(str, conn);
                    DataTable dtbl = new DataTable();
                    sqlDA.Fill(dtbl);
                    return dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
                conn.Close();
                return null;
            }
        }


        public Form_accountant()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            conn.Open();
            dataGridView1.DataSource = Command("select * from view_accountant");
            dataGridView2.DataSource = Command("select * from dbo.premiya() ");
        }

        private void Form_accountant_Load(object sender, EventArgs e)
        {
            

        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != null && textBox5.Text != "")
            {
                string q;
            q = textBox5.Text;
            dataGridView2.DataSource = Command("select * from dbo.premiya() where [Количество услуг] >=" +q);
                textBox5.Text = null;
            }
            else
                dataGridView2.DataSource = Command("select * from dbo.premiya()");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Command("select * from dbo.price_of()");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Command("SELECT id_worker,FIO,Position, [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12] "+
   "FROM dbo.premiya_dop() PIVOT(sum([Количество услуг]) FOR[q] IN([1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12])) AS test_pivot");
        }
    }
}
