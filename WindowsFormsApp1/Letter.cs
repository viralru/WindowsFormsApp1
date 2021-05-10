using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Letter : Form
    {
       
        public Letter()
        {
            InitializeComponent();
        
        }
        

      
        private void Letter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String letterid = ClientSession.letter;
            String idletter = letterid.Replace("LinkClick", "");
          

            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * from Letters where id = @UID", db.GetConnection());
            command.Parameters.Add("@UID", SqlDbType.VarChar).Value = idletter;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string theme = table.Rows[0][8].ToString();
            string themenospaces = theme.Replace(" ", "");
            string comment = table.Rows[0][9].ToString();
            string commentnospaces = comment.Replace(" ", "");
            label1.Text = themenospaces;
            label2.Text = commentnospaces;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }



}
