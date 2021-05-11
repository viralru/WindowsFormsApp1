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
            ClientSession.idletter = letterid.Replace("LinkClick", "");
            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * from Letters where id = @UID", db.GetConnection());
            command.Parameters.Add("@UID", SqlDbType.VarChar).Value = ClientSession.idletter;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string theme = table.Rows[0][8].ToString();
            string themenospaces = theme.Replace(" ", "");
            string comment = table.Rows[0][9].ToString();
            string commentnospaces = comment.Replace(" ", "");
            string SendDate = table.Rows[0][3].ToString();
            string SendTime = table.Rows[0][4].ToString();
            string documentid = table.Rows[0][6].ToString();
            ClientSession.documentid = documentid;

            label1.Text = themenospaces;
            label2.Text = commentnospaces;
            label3.Text = SendDate;
            label4.Text = SendTime;
            

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command1 = new SqlCommand("Update Letters SET IsWritten = @IsWritten WHERE id=@UID", db.GetConnection());

            command1.Parameters.Add("@UID", SqlDbType.VarChar).Value = ClientSession.idletter;
            command1.Parameters.Add("@IsWritten", SqlDbType.Bit).Value = true;

            Sign sign = new Sign();
            sign.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }



}
