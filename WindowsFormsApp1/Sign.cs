using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sign : Form
    {
        public static string documentid;
        public Sign()
        {
            InitializeComponent();
            
            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * from Documents where id = @UID", db.GetConnection());
            command.Parameters.Add("@UID", SqlDbType.VarChar).Value = ClientSession.idletter;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            documentid = table.Rows[0][0].ToString();
            string Name = table.Rows[0][1].ToString();
            string CreationDate = table.Rows[0][3].ToString();
            string CreationTime = table.Rows[0][4].ToString();
            string Link = table.Rows[0][5].ToString();
            label1.Text = Name;
            label8.Text = CreationDate;
            string fileText = System.IO.File.ReadAllText("C:/Users/Viral/OneDrive/Рабочий стол/Тестовая папка для писем/document" + documentid + ".txt");
            richTextBox2.Text = fileText;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
