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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();

        }

        private  void button1_Click(object sender, EventArgs e)
        {
            String FirstNameBox = textBox1.Text;
            String LastNameBox = textBox2.Text;
            String MiddleNameBox = textBox3.Text;
            String LoginBox = textBox4.Text;
            String PasswordBox = textBox5.Text;
            int NewID = 0;
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand searchID = new SqlCommand("SELECT * FROM workers", db.GetConnection());
            adapter.SelectCommand = searchID;
            adapter.Fill(table);
            NewID = table.Rows.Count + 1;
            SqlCommand command = new SqlCommand("INSERT INTO Workers(ID, FirstName, LastName, MiddleName, Login, Password) VALUES(@UID, @UFN, @ULN, @UMD, @UL,@UP)", db.GetConnection());
            command.Parameters.Add("@UID", SqlDbType.Int).Value = NewID;
            command.Parameters.Add("@UFN", SqlDbType.VarChar).Value = FirstNameBox;
            command.Parameters.Add("@ULN", SqlDbType.VarChar).Value = LastNameBox;
            command.Parameters.Add("@UMD", SqlDbType.VarChar).Value = MiddleNameBox;
            command.Parameters.Add("@UL", SqlDbType.VarChar).Value = LoginBox;
            command.Parameters.Add("@UP", SqlDbType.VarChar).Value = PasswordBox;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            // подумать о генерации ключа

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            Hide();
        }
    }
    }

