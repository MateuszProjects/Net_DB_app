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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathSql = "Data Source=MARCO\\SQLEXPRESS;Initial Catalog=new_DB;Persist Security Info=True;User ID=sa;Password=***********";
            SqlConnection sqlConnection = new SqlConnection(pathSql);

            sqlConnection.Open();
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                string q = "insert intu values()";
                SqlCommand sqlCommand = new SqlCommand(q, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Connection success");
            }

            sqlConnection.Close();
        }
    }
}
