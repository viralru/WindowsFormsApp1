﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sign : Form
    {
        public static string Comment;
        public static Boolean SignType;
        public static string documentid;
        public static string DeclineReason;
        public static int StatusSign;
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
            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Update Documents SET Signs = @IsSigned  WHERE id=@UID", db.GetConnection());
            command.Parameters.Add("@IsSigned", SqlDbType.VarChar).Value = ClientSession.iduser;
            command.Parameters.Add("@UID", SqlDbType.VarChar).Value = ClientSession.idletter;

           
            adapter.SelectCommand = command;
            adapter.Fill(table);
        
            DataTable table1 = new DataTable();
            if (Comment == "")
            {
                DeclineReason = "Подписано";
            }
            else
            {
                DeclineReason = Comment;
            }
            SqlCommand command1 = new SqlCommand("Update Letters SET IsSigned = @IsSigned, id_status = @Status WHERE id=@UID", db.GetConnection());
            
            command1.Parameters.Add("@UID", SqlDbType.VarChar).Value = ClientSession.idletter;
            //command1.Parameters.Add("@DeclineReason", SqlDbType.VarChar).Value = DeclineReason;
            command1.Parameters.Add("@IsSigned", SqlDbType.Bit).Value = true;
            command1.Parameters.Add("@Status", SqlDbType.Int).Value = 2;


            adapter.SelectCommand = command1;
            adapter.Fill(table1);
            Form1 form1 = new Form1();
            form1.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Letter letter = new Letter();
            letter.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignType = true;
            StatusSign = 2;
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SignType = false;
            if(richTextBox1.Text=="")
            {
                MessageBox.Show("Заполните комментарий");
            }
            else
            {
                Comment = richTextBox1.Text;
                button2.Enabled = true;
            }
    }
    }
}
