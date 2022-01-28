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
    public partial class Form5 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"Data Source=DESKTOP-J49P638\SQLEXPRESS;Initial Catalog=Session_1;Integrated Security=True";
        string sql = "SELECT * FROM Realtor";


        public Form5()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
              
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // удаляем выделенные строки из dataGridView1
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("INSERT * FROM Realtor", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar, 50, "Surname"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@First_Name", SqlDbType.NVarChar, 50, "First_Name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Last_Name", SqlDbType.NVarChar, 50, "Last_Name"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Share_Of_Comission", SqlDbType.Int, 0, "Share_Of_Comission"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Login", SqlDbType.NVarChar, 50, "Login"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50, "Password"));

                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id_Realtor", SqlDbType.Int, 0, "Id_Realtor");
                parameter.Direction = ParameterDirection.Output;

                adapter.Update(ds);
            }

        }
    }
}
