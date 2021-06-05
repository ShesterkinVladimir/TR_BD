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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection conn = new SqlConnection(@"Data source =DESKTOP-42QTCGA ; Initial Catalog = TP; Integrated Security = True");
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static string PasswordAll(string id)
        {
            string p;
            bool validValue;
            SqlConnection conn = new SqlConnection("Data source =DESKTOP-42QTCGA ; Initial Catalog = TP; Integrated Security = True");
            conn.Open();

            using (conn.CreateCommand())
            {
                SqlCommand pass = new SqlCommand("select * from TP.dbo.password where TP.dbo.password.id_pass = " + id, conn);
                using (SqlDataReader dataReader = pass.ExecuteReader())
                {
                    validValue = dataReader.Read();
                    p = dataReader["pass"].ToString();
                }
            }

            conn.Close();

            return p;
        }


        private void input_Click(object sender, EventArgs e)
        {
            string p1, p2, p3,p4;

            p1 = PasswordAll("3");
            p2 = PasswordAll("2");
            p3 = PasswordAll("1");
            p4 = PasswordAll("4");



            if (radioButton1.Checked && (Password.Text == p1))
            {
                this.Hide();
                Form_repairer formR = new Form_repairer();
                formR.ShowDialog();
                Close();
            }
            if (radioButton2.Checked && (Password.Text == p2))
            {
                this.Hide();
                Form_procurement formP= new Form_procurement();
                formP.ShowDialog();
                Close();
            }
            if (radioButton3.Checked && (Password.Text == p3))
            {
                this.Hide();
                Form_accountant formA = new Form_accountant();
                formA.ShowDialog();
                Close();
            }
            if (radioButton4.Checked && (Password.Text == p4))
            {
                this.Hide();
                Form_admin formAdmin = new Form_admin();
                formAdmin.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
            

        }
    }
}
