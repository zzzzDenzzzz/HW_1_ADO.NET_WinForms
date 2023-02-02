using System.Data.SqlClient;
using System.Data;

namespace HW_1_ADO.NET_WinForms
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DENIS-PC\\SQLEXPRESS;Initial Catalog=VegetablesAndFruits;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection? _connection = null;

        private void button1_Click(object sender, EventArgs e)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            if (_connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Connect DB!");
            }
            else
            {
                MessageBox.Show("Oops!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_connection == null)
            {
                MessageBox.Show("Oops!");
                return;
            }
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
                if (_connection.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Disconnect DB!");
                    _connection = null;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_connection?.State == ConnectionState.Open)
            {
                var selectCommand = new SqlCommand(
                    @"SELECT Id, [Type], Color, Calories FROM VegetablesAndFruits",
                    _connection);
                using var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text += (reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3] + Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Oops!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_connection?.State == ConnectionState.Open)
            {
                var selectCommand = new SqlCommand(
                    @"SELECT Id, Color FROM VegetablesAndFruits",
                    _connection);
                using var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text += (reader[0] + " " + reader[1] + Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Oops!");
            }
        }
    }
}