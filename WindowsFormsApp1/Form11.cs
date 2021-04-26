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
            String FirstNameBox = textBox2.Text;
            String LastNameBox = textBox1.Text;
            String MiddleNameBox = textBox3.Text;
            String Position = textBox4.Text;
            String PasswordBox = textBox6.Text;
            String PasswordBoxRepeat = textBox5.Text;
            String Department = textBox7.Text;
            String LoginBox = textBox9.Text;
            String Email = textBox8.Text;

            int NewID = 0;
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand searchID = new SqlCommand("SELECT * FROM workers", db.GetConnection());
            adapter.SelectCommand = searchID;
            adapter.Fill(table);
            NewID = table.Rows.Count + 1;
            SqlCommand command = new SqlCommand("INSERT INTO Workers(ID, FirstName, LastName, MiddleName, Login, Password, Position, Department, IsActive, Email, id_AccessGroup) VALUES(@UID, @UFN, @ULN, @UMD, @UL, @UP, @UPos, @UDepart, @UActive, @UEmail,@UAcc)", db.GetConnection());
            command.Parameters.Add("@UID", SqlDbType.Int).Value = NewID;
            command.Parameters.Add("@UFN", SqlDbType.VarChar).Value = FirstNameBox;
            command.Parameters.Add("@ULN", SqlDbType.VarChar).Value = LastNameBox;
            command.Parameters.Add("@UMD", SqlDbType.VarChar).Value = MiddleNameBox;
            command.Parameters.Add("@UL", SqlDbType.VarChar).Value = LoginBox;
            command.Parameters.Add("@UP", SqlDbType.VarChar).Value = PasswordBox;
            command.Parameters.Add("@UPos", SqlDbType.VarChar).Value = Position;
            command.Parameters.Add("@UDepart", SqlDbType.VarChar).Value = Department;
            command.Parameters.Add("@UEmail", SqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@UActive", SqlDbType.VarChar).Value = "True";
            command.Parameters.Add("@UAcc", SqlDbType.VarChar).Value = "2";




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

