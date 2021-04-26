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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SqlCommand newcommand = new SqlCommand("Select * from Workers where id = @UIDU", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            newcommand.Parameters.Add("@UIDU", SqlDbType.VarChar).Value = ClientSession.iduser;
            DataTable table2 = new DataTable();
            adapter.SelectCommand = newcommand;
            adapter.Fill(table2);
            string Pass = table2.Rows[0][7].ToString();
            string Passnospace = Pass.Replace(" ", "");
            if(Passnospace == textBox1.Text)
            {   // поменять на реплейс
                SqlCommand command = new SqlCommand("INSERT INTO Workers(Password) Values(@UNewPass) where id = @UIDU ", db.GetConnection());
                command.Parameters.Add("@UIDU", SqlDbType.VarChar).Value = ClientSession.iduser;
                command.Parameters.Add("@UNewPass", SqlDbType.VarChar).Value = textBox2.Text;
                Hide();
            }
            else
            {
                MessageBox.Show("Введен неверный логин или пароль");
            }
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
