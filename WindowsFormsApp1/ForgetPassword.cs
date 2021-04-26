using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Net;



namespace WindowsFormsApp1
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Email = textBox1.Text;
           
            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * from Workers where Email = @UEmail", db.GetConnection());
            command.Parameters.Add("@UEmail", SqlDbType.VarChar).Value = Email;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string UserEmail = table.Rows[0][11].ToString();
            string pass = table.Rows[0][7].ToString();

            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("viralru01@gmail.com", "Tom");
            // кому отправляем
            MailAddress to = new MailAddress(UserEmail);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = "Ваш пароль:" + pass;
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
            
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = true;
            
            // логин и пароль
            smtp.Credentials = new NetworkCredential("viralru01@gmail.com", "Feyanebey666");
            smtp.EnableSsl = true;
            smtp.Send(m);
            MessageBox.Show("Вам отправлено письмо с паролем");
            Hide();

        }
    }
}
