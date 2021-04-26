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
    public partial class Form7 : Form
    {
       
        public Form7()
        {

            InitializeComponent();
            //String letterid = ClientSession.letter;
            //string idletter = letterid.Replace("LinkLabel", "");
            //textBox1.Text = idletter;
            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * from Letters where id = @UID", db.GetConnection());
            command.Parameters.Add("@UID", SqlDbType.VarChar).Value = 1;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string theme = table.Rows[0][8].ToString();
            string themenospaces = theme.Replace(" ", "");
            string comment = table.Rows[0][9].ToString();
            string commentnospaces = comment.Replace(" ", "");
            label1.Text = themenospaces;
            label2.Text = commentnospaces;

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
