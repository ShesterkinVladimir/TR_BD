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
    public partial class Form_repairer : Form
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
        public Form_repairer()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells

            conn.Open();
            dataGridView1.DataSource = Command("select * from view_repairer");
           


        }

        private void Form_repairer_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Command("select id_client,FIO from client");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Command("select id_worker,FIO from worker");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Command("select id_service,name_services from service");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Command("select * from [dbo].[order] order by order_date desc");
        }

        private string chektext(string str)
        {
            if (str == "")
                return null;
            else
                return ("'" + str + "'");
        } 

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null && textBox2.Text != "")
            {
                if (textBox3.Text != null && textBox3.Text != "")
                {
                    
                       
                            string id_c = textBox2.Text;
                            string id_r = textBox3.Text;
                    string date = chektext(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                   


                            Command("exec add_order " + id_c + ", " + id_r + ", " + date );
                            dataGridView1.DataSource = Command("select * from view_repairer");
                    textBox2.Text = null;
                    textBox3.Text = null;
                    


                }
                else
                    MessageBox.Show("Введите ID работника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Введите ID клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != null && textBox10.Text != "")
            {
                if (textBox8.Text != null && textBox8.Text != "")
                {


                    string id_ord = textBox10.Text;
                    string id_ser = textBox8.Text;
                   



                    Command("exec add_order_service " + id_ser + ", " + id_ord);
                    dataGridView1.DataSource = Command("select * from view_repairer");
                    textBox10.Text = null;
                    textBox8.Text = null;



                }
                else
                    MessageBox.Show("Введите ID услуги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Введите ID заявки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Command("select specification,manufacturer,quantity from spares");
        }
    }
    }

