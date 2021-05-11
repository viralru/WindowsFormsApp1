using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public static string DocumentText;

        public Form5()
        {
            InitializeComponent();
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select id,FirstName,LastName from Workers", db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int Rowscount = table.Rows.Count;
            if (Rowscount != 0)
            {
                for (int i = 0; i < Rowscount; i++)
                {
                    string id = table.Rows[i][0].ToString();
                    string FirstName = table.Rows[i][1].ToString();
                    string LastName = table.Rows[i][2].ToString();
                    string Text = FirstName + " " + LastName;
                    comboBox1.Items.Add(Text);
                    
                    
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proektDataSet1.Workers". При необходимости она может быть перемещена или удалена.
            //this.workersTableAdapter.Fill(this.proektDataSet1.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proektDataSet1.Vacations". При необходимости она может быть перемещена или удалена.
            //this.vacationsTableAdapter.Fill(this.proektDataSet1.Vacations);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(new ComboBox() { Location = new Point(545, 100), Width = 145, Height = 21 });
            this.Controls.Add(new Button() { Location = new Point(700, 100), Width = 24, Height = 24, BackgroundImage = global::WindowsFormsApp1.Properties.Resources.adduser1}); //, BackgroundImageLayout
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Theme = richTextBox1.Text;
            String Comment = richTextBox2.Text;

            int NewID = 0;
            DB db = new DB();
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand searchID = new SqlCommand("SELECT * FROM Letters", db.GetConnection());
            //SqlCommand searchID1 = new SqlCommand("SELECT * FROM LettersOfWorkers", db.GetConnection());
            adapter.SelectCommand = searchID;
            adapter.Fill(table);
            NewID = table.Rows.Count + 1;
            int id_recip = comboBox1.SelectedIndex + 1;
            SqlCommand command = new SqlCommand("INSERT INTO Letters(id, id_Sender, id_recipient,SendDate,SendTime,id_status,Theme,Comment,IsInDrafts,IsInTrash,IsSigned) VALUES(@UID, @USender, @URecipient,@UDate,@UTime,@UStatus,@UTheme,@UComment,@IsInDrafts,@IsInTrash,@IsSigned)", db.GetConnection());
            command.Parameters.Add("@UID", SqlDbType.Int).Value = NewID;
            command.Parameters.Add("@USender", SqlDbType.Int).Value = Convert.ToInt32(ClientSession.iduser);
            command.Parameters.Add("@URecipient", SqlDbType.Int).Value = Convert.ToInt32(id_recip);
            command.Parameters.Add("@UTheme", SqlDbType.VarChar).Value = richTextBox1.Text;
            command.Parameters.Add("@UStatus", SqlDbType.Int).Value = "1";
            command.Parameters.Add("@UComment", SqlDbType.VarChar).Value = richTextBox2.Text;
            command.Parameters.Add("@UDate", SqlDbType.Date).Value = DateTime.Now.ToString("dd MMMM yyyy");
            command.Parameters.Add("@UTime", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");
            command.Parameters.Add("@UWritten", SqlDbType.Bit).Value = false;
            command.Parameters.Add("@IsInDrafts", SqlDbType.Bit).Value = true;
            command.Parameters.Add("@IsInTrash", SqlDbType.Bit).Value = false;
            command.Parameters.Add("@IsSigned", SqlDbType.Bit).Value = false;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string Link = "C:/Users/Viral/OneDrive/Рабочий стол/Тестовая папка для писем/document" + NewID + ".txt";
            File.WriteAllText(Link, DocumentText);

            SqlCommand command1 = new SqlCommand("INSERT INTO Documents(id, Name,CreationDate,CreationTime,Link) VALUES(@LID,@LName,@LCreationDate,@LCreationTime,@LLink)", db.GetConnection());
            command1.Parameters.Add("@LID", SqlDbType.Int).Value = NewID;
            command1.Parameters.Add("@LName", SqlDbType.VarChar).Value = richTextBox1.Text;
            command1.Parameters.Add("@LCreationDate", SqlDbType.Date).Value = "2021-05-11";
            command1.Parameters.Add("@LCreationTime", SqlDbType.Time).Value = "02:45:36";
            command1.Parameters.Add("@LLink", SqlDbType.VarChar).Value = Link;
            //command1.Parameters.Add("@LDID", SqlDbType.Int).Value = NewID;
            adapter.SelectCommand = command1;
            adapter.Fill(table1);
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String Theme = richTextBox1.Text;
            String Comment = richTextBox2.Text;
            
            int NewID = 0;
            DB db = new DB();
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand searchID = new SqlCommand("SELECT * FROM Letters", db.GetConnection());
            //SqlCommand searchID1 = new SqlCommand("SELECT * FROM LettersOfWorkers", db.GetConnection());
            adapter.SelectCommand = searchID;
            adapter.Fill(table);
            NewID = table.Rows.Count + 1;
            int id_recip = comboBox1.SelectedIndex + 1;
            SqlCommand command = new SqlCommand("INSERT INTO Letters(id, id_Sender, id_recipient,SendDate,SendTime,id_status,Theme,Comment,IsInDrafts,IsInTrash,IsSigned) VALUES(@UID, @USender, @URecipient,@UDate,@UTime,@UStatus,@UTheme,@UComment,@IsInDrafts,@IsInTrash,@IsSigned)", db.GetConnection());
            command.Parameters.Add("@UID", SqlDbType.Int).Value = NewID;
            command.Parameters.Add("@USender", SqlDbType.Int).Value = Convert.ToInt32(ClientSession.iduser);
            command.Parameters.Add("@URecipient", SqlDbType.Int).Value = Convert.ToInt32(id_recip);
            command.Parameters.Add("@UTheme", SqlDbType.VarChar).Value = richTextBox1.Text;
            command.Parameters.Add("@UStatus", SqlDbType.Int).Value = "1";
            command.Parameters.Add("@UComment", SqlDbType.VarChar).Value = richTextBox2.Text;
            command.Parameters.Add("@UDate", SqlDbType.Date).Value = DateTime.Now.ToString("dd MMMM yyyy");
            command.Parameters.Add("@UTime", SqlDbType.Time).Value = DateTime.Now.ToString("HH:mm:ss");
            command.Parameters.Add("@UWritten", SqlDbType.Bit).Value = false;
            command.Parameters.Add("@IsInDrafts", SqlDbType.Bit).Value = false;
            command.Parameters.Add("@IsInTrash", SqlDbType.Bit).Value = false;
            command.Parameters.Add("@IsSigned", SqlDbType.Bit).Value = false;


            adapter.SelectCommand = command;
            adapter.Fill(table);
            string Link = "C:/Users/Viral/OneDrive/Рабочий стол/Тестовая папка для писем/document" + NewID + ".txt";
            File.WriteAllText(Link, DocumentText);
           
            SqlCommand command1 = new SqlCommand("INSERT INTO Documents(id, Name,CreationDate,CreationTime,Link) VALUES(@LID,@LName,@LCreationDate,@LCreationTime,@LLink)", db.GetConnection());
            command1.Parameters.Add("@LID", SqlDbType.Int).Value = NewID;
            command1.Parameters.Add("@LName", SqlDbType.VarChar).Value = richTextBox1.Text;
            command1.Parameters.Add("@LCreationDate", SqlDbType.Date).Value = "2021-05-11";
            command1.Parameters.Add("@LCreationTime", SqlDbType.Time).Value = "02:45:36";
            command1.Parameters.Add("@LLink", SqlDbType.VarChar).Value = Link;
            //command1.Parameters.Add("@LDID", SqlDbType.Int).Value = NewID;
            adapter.SelectCommand = command1;
            adapter.Fill(table1);
            Form1 form1 = new Form1();
            form1.Show();
            Hide();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "txt";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            label3.Text = filename;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            DocumentText = fileText;
            label3.Text = filename;
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
