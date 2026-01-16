using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace GIT_project
{
    public partial class Form1 : Form
    {
        string connectionString =
    "Server=(localdb)\\MSSQLLocalDB;Database=SQLdb;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        //btn add task
        private void button1_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = @"INSERT INTO Tasks (Title, Description, Deadline)
                   VALUES (@Title, @Description, @Deadline)";

            using SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Title", textBox1.Text);
            cmd.Parameters.AddWithValue("@Description",
                string.IsNullOrWhiteSpace(textBox2.Text)
                    ? (object)DBNull.Value
                    : textBox2.Text);

            cmd.Parameters.AddWithValue("@Deadline", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();

            LoadTasks();
            MessageBox.Show("Завдання додано");
            
        }

        private void LoadTasks()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Tasks";

            using SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }


        //done
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string sql = "UPDATE Tasks SET IsCompleted = 1 WHERE Id = @Id";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }

            LoadTasks();

        }

        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string sql = "DELETE FROM Tasks WHERE Id = @Id";
                using SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }

            LoadTasks();

        }
    }
}
