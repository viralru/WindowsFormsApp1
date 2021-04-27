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
    public partial class Form10 : Form
    {
        public Form10()
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
                    lastNameComboBox.Items.Add(Text);


                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
  
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            String Login = ClientSession.UserName;
            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * from Workers where Login = @UL", db.GetConnection());
            command.Parameters.Add("@UL", SqlDbType.VarChar).Value = Login;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            lastNameTextBox.Text = table.Rows[0][1].ToString();
            firstNameTextBox.Text = table.Rows[0][2].ToString();
            middleNameTextBox.Text = table.Rows[0][3].ToString();
            departmentTextBox.Text = table.Rows[0][4].ToString();
            positionTextBox.Text = table.Rows[0][5].ToString();
            loginTextBox.Text = table.Rows[0][6].ToString();
            passwordTextBox.Text = table.Rows[0][7].ToString();




        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.workersTableAdapter1.FillBy(this.proektDataSet2.Workers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lastNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
