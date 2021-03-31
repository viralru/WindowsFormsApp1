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
    public partial class Form9 : Form
    {
       
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Login = textBox1.Text;
            String Pass = textBox2.Text;
            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * from Workers where Login = @UL AND Password = @UP", db.GetConnection());
            command.Parameters.Add("@UL",SqlDbType.VarChar).Value = Login;
            command.Parameters.Add("@UP", SqlDbType.VarChar).Value = Pass;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Form1 form1 = new Form1();
                form1.Show();
                Hide();
            }
            else

                MessageBox.Show("Введен неверный пароль");

        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
    
         

        }

        private  void Form9_Load(object sender, EventArgs e)
        {


        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.Show();
            Hide();
        }
    } 
}
