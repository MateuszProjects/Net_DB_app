using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'new_DBDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.new_DBDataSet.user);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // insert data
            SqlConnection sqlConnection = new SqlConnection("Data Source=MARCO\\SQLEXPRESS;Initial Catalog=new_DB;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            string query = "insert into [new_DB].[dbo].[user] values(" + textBox1.Text+",'"+textBox2.Text+"', '"+textBox3.Text+"')";
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText= query;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
