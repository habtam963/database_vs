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
using MySql.Data.MySqlClient;



namespace database_10._08
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

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=localhost;Port= 3307;Database=diakok;Uid=root;Pwd='';";

            string Query = "SELECT * FROM diak";
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(Query, conn);

                //MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
