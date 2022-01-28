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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J49P638\SQLEXPRESS;Initial Catalog=Session_1; Integrated Security=True;");
            try
            {
                string comand = string.Format("SELECT * FROM Realtor WHERE Login = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "';");
                SqlCommand check = new SqlCommand(comand, con);
                con.Open();

                if (check.ExecuteScalar() != null)
                {
                    Form3.ActiveForm.Hide();
                    Form5 MyForm5 = new Form5();
                    MyForm5.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пороль");
                }
            }
            finally
            {
                con.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form2 MyForm2 = new Form2();
            MyForm2.ShowDialog();
            Close();
        }
    }
}
