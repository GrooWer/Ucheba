using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля для регистрации!!!");
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J49P638\SQLEXPRESS;Initial Catalog=Session_1; Integrated Security=True;");
                    con.Open();
                    string str = "insert into Client(Surname,First_Name,Last_Name,Phone_Number,Email,Login,Password) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Клиент зарегистрирован!!!");
                }
            }
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля для регистрации!!!");
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J49P638\SQLEXPRESS;Initial Catalog=Session_1; Integrated Security=True;");
                    con.Open();
                    string str = "insert into Realtor(Surname,First_Name,Last_Name,Login,Password) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Риелтор зарегистрирован!!!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Show();
            label4.Show();
            label5.Show();
            textBox4.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Hide();
            label4.Hide();
            label5.Hide();
            textBox4.Hide();
        }
    }
}
