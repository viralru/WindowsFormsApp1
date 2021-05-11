﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            String userid = ClientSession.iduser;
            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * from Letters where id_Sender=@UID AND IsinTrash = @isInTrash  AND IsInDrafts = @isInDrafts", db.GetConnection());
            command.Parameters.Add("@UID", SqlDbType.VarChar).Value = userid;
            //command.Parameters.Add("@isSigned", SqlDbType.Bit).Value = false;
            command.Parameters.Add("@isInTrash", SqlDbType.Bit).Value = 0;
            command.Parameters.Add("@isInDrafts", SqlDbType.Bit).Value = 1;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int Rowscount = table.Rows.Count;
            tableLayoutPanel1.RowCount = Rowscount;

            if (Rowscount != 0)
                for (int i = 0; i < Rowscount; i++)
                {
                    string theme = table.Rows[i][8].ToString();
                    string themenospaces = theme.Replace(" ", "");
                    string comment = table.Rows[i][9].ToString();
                    string commentnospaces = comment.Replace(" ", "");
                    string id_Sender = table.Rows[i][1].ToString();
                    string id_status = table.Rows[i][10].ToString();
                    string statusSigned = table.Rows[i][7].ToString();
                    string id = table.Rows[i][0].ToString();




                    SqlCommand newcommand = new SqlCommand("Select * from Workers where id = @UIDU", db.GetConnection());
                    newcommand.Parameters.Add("@UIDU", SqlDbType.VarChar).Value = id_Sender;
                    DataTable table2 = new DataTable();
                    adapter.SelectCommand = newcommand;
                    adapter.Fill(table2);

                    string ShortUserName = table2.Rows[0][2].ToString();

                    tableLayoutPanel1.Controls.Add(new Label { Text = themenospaces + "\r\n" + "\r\n" + ShortUserName + "\r\n" + commentnospaces, Name = "LinkClick" + id, Tag = i, Size = new Size(353, 78), BorderStyle = BorderStyle.FixedSingle }); ;
                    tableLayoutPanel1.Controls.Add(new Button { Name = "buttonclick" + id, BackgroundImage = WindowsFormsApp1.Properties.Resources.z00SzkeG89Q, Size = new Size(16, 20) });

                    if (statusSigned == "2")
                    {
                        bool Signed = true;
                        tableLayoutPanel1.Controls.Add(new CheckBox { Checked = Signed });
                    }
                    else
                    {
                        bool Signed = false;
                        tableLayoutPanel1.Controls.Add(new CheckBox { Checked = Signed });
                    }



                }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
        private void OpenMy(object sender, EventArgs e)
        {
            Letter form7 = new Letter();
            form7.Show();
            Hide();
            Label btn = sender as Label;
            string s = btn.Name;
            ClientSession.letter = s;


        }
        private void DeleteMy(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = btn.Name;
            ClientSession.letter = s;
            String letterid = ClientSession.letter;
            ClientSession.idletter = letterid.Replace("buttonclick", "");
            textBox1.Text = ClientSession.idletter;
            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Update Letters SET IsInTrash = @IsinTrash  WHERE id=@UID", db.GetConnection());
            command.Parameters.Add("@IsinTrash", SqlDbType.VarChar).Value = 1;
            command.Parameters.Add("@UID", SqlDbType.VarChar).Value = ClientSession.idletter;
            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            Hide();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderCreationcs formcreationfolder = new FolderCreationcs();
            formcreationfolder.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            String userid = ClientSession.iduser;
            DB db = new DB();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select * from Letters where id_Sender=@UID AND IsinTrash = @isInTrash  AND IsInDrafts = @isInDrafts AND Theme LIKE @USearch", db.GetConnection());
            command.Parameters.Add("@UID", SqlDbType.VarChar).Value = userid;
            //command.Parameters.Add("@isSigned", SqlDbType.Bit).Value = false;
            command.Parameters.Add("@isInTrash", SqlDbType.Bit).Value = 0;
            command.Parameters.Add("@isInDrafts", SqlDbType.Bit).Value = 1;
            command.Parameters.Add("@USearch", SqlDbType.VarChar).Value = textBox1.Text + "%";
            adapter.SelectCommand = command;
            adapter.Fill(table);
            int Rowscount = table.Rows.Count;
            tableLayoutPanel1.RowCount = Rowscount;

            if (Rowscount != 0)
                for (int i = 0; i < Rowscount; i++)
                {
                    string theme = table.Rows[i][8].ToString();
                    string themenospaces = theme.Replace(" ", "");
                    string comment = table.Rows[i][9].ToString();
                    string commentnospaces = comment.Replace(" ", "");
                    string id_Sender = table.Rows[i][1].ToString();
                    string id_status = table.Rows[i][10].ToString();
                    string statusSigned = table.Rows[i][7].ToString();
                    string id = table.Rows[i][0].ToString();




                    SqlCommand newcommand = new SqlCommand("Select * from Workers where id = @UIDU", db.GetConnection());
                    newcommand.Parameters.Add("@UIDU", SqlDbType.VarChar).Value = id_Sender;
                    DataTable table2 = new DataTable();
                    adapter.SelectCommand = newcommand;
                    adapter.Fill(table2);

                    string ShortUserName = table2.Rows[0][2].ToString();

                    tableLayoutPanel1.Controls.Add(new Label { Text = themenospaces + "\r\n" + "\r\n" + ShortUserName + "\r\n" + commentnospaces, Name = "LinkClick" + id, Tag = i, Size = new Size(353, 78), BorderStyle = BorderStyle.FixedSingle }); ;
                    tableLayoutPanel1.Controls.Add(new Button { Name = "buttonclick" + id, BackgroundImage = WindowsFormsApp1.Properties.Resources.z00SzkeG89Q, Size = new Size(16, 20) });
                    (tableLayoutPanel1.Controls["LinkClick" + id] as Label).Click += OpenMy;
                    (tableLayoutPanel1.Controls["buttonclick" + id] as Button).Click += DeleteMy;

                    if (statusSigned == "2")
                    {
                        bool Signed = true;
                        tableLayoutPanel1.Controls.Add(new CheckBox { Checked = Signed });
                    }
                    else
                    {
                        bool Signed = false;
                        tableLayoutPanel1.Controls.Add(new CheckBox { Checked = Signed });
                    }



                }

        }
    }
    }

