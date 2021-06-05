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
    public partial class Form_procurement : Form
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


        public Form_procurement()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//DisplayedCells
          
            conn.Open();
            dataGridView2.DataSource = Command("select * from spares");
            textBox11.Text = Txt("select dbo.TOP_spare() as q");
            textBox13.Text = Txt("select dbo.stringCLR_() as q");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void Form_procurement_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tPDataSet4.view_procurement". При необходимости она может быть перемещена или удалена.
            this.view_procurementTableAdapter.Fill(this.tPDataSet4.view_procurement);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                //Получаем ключ строки (id)
                //и столбец который нужно изменить (header)
                if (dataGridView2.CurrentRow != null)
                {
                    string id;

                    int row = Convert.ToInt32(dataGridView2.CurrentRow.Index);
                    int cell = Convert.ToInt32(dataGridView2.CurrentCell.ColumnIndex);
                    id = dataGridView2.Rows[row].Cells[0].Value.ToString();

                    //ошибка, если изменять PK
                    string value = textBox1.Text;
                    if (cell != 0)
                    {
                        string header = dataGridView2.Columns[cell].HeaderText.ToString();

                        string headerPK = dataGridView2.Columns[0].HeaderText.ToString();

                        Type a = dataGridView2.Columns[cell].ValueType;//Получить тип столбца
                        string aa = a.Name;
                        switch (aa)
                        {
                            case "String":
                                value = "'" + value + "'";
                                break;
                            case "DateTime":
                                value = "'" + value + "'";
                                break;
                        }

                        string zapr = "update spares set " + header + " =" + value + " where " + headerPK + "=" + id;
                        Command(zapr);
                        dataGridView2.DataSource = Command("select * from spares");
                        textBox1.Text = null;
                        

                    }
                    else
                        MessageBox.Show("Нельзя изменить PK", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Выберете поле, которое нужно изменить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
                MessageBox.Show("Введите значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                string id;
            int row = Convert.ToInt32(dataGridView2.CurrentRow.Index);
            id = dataGridView2.Rows[row].Cells[0].Value.ToString();

            string zapr = "exec del_spares " + id;
            Command(zapr);
            dataGridView2.DataSource = Command("select * from spares");
            }
            else
                MessageBox.Show("Выберете поле, которое нужно изменить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private string chektext(string str)
        {
            if (str == "")
                return null;
            else
                return ("'" + str + "'");
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null && textBox2.Text != "") { 
                if (textBox3.Text != null && textBox3.Text != "") { 
                    if (textBox4.Text != null && textBox4.Text != "") { 
                        if (textBox5.Text != null && textBox5.Text != "") { 

                            string spec = chektext(textBox2.Text);
            string manuf = chektext(textBox3.Text);
            string price = textBox4.Text;
            string quantity = textBox5.Text;
            
             Command("exec add_spares " + spec + ", " + manuf + ", " + price + ", " + quantity );
            dataGridView2.DataSource = Command("select * from spares");
                            textBox2.Text = null;
                            textBox3.Text = null;
                            textBox4.Text = null;
                            textBox5.Text = null;
                        }
                        else
                            MessageBox.Show("Введите количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Введите цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Введите производителя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Введите описание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null && textBox2.Text != "")
            {
                if (textBox3.Text != null && textBox3.Text != "")
                {
                    if (textBox4.Text != null && textBox4.Text != "")
                    {
                        if (textBox5.Text != null && textBox5.Text != "")
                        {
                            if (dataGridView2.CurrentRow != null)
                            {
                                string id;

                            int row = Convert.ToInt32(dataGridView2.CurrentRow.Index);
                            id = dataGridView2.Rows[row].Cells[0].Value.ToString();
                            string spec = chektext(textBox2.Text);
                            string manuf = chektext(textBox3.Text);
                            string price = textBox4.Text;
                            string quantity = textBox5.Text;

                            Command("exec up_spares "+ id +", " + spec + ", " + manuf + ", " + price + ", " + quantity);
                            dataGridView2.DataSource = Command("select * from spares");
                                textBox2.Text = null;
                                textBox3.Text = null;
                                textBox4.Text = null;
                                textBox5.Text = null;

                            }
                            else
                                MessageBox.Show("Выберете поле, которое нужно изменить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);




                        }
                        else
                            MessageBox.Show("Введите количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Введите цену", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Введите производителя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Введите описание", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public string Txt(string str)
        {
            bool validValue;
            string smm;
            using (conn.CreateCommand())
            {
                SqlCommand com = new SqlCommand(str, conn);
                using (SqlDataReader dataReader = com.ExecuteReader())
                {
                    validValue = dataReader.Read();
                    smm = dataReader["q"].ToString();
                }
            }
            return smm;
        }


        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox11.Text = Txt("select dbo.TOP_spare() as q");
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
