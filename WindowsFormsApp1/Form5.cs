using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proektDataSet1.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.proektDataSet1.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proektDataSet1.Vacations". При необходимости она может быть перемещена или удалена.
            this.vacationsTableAdapter.Fill(this.proektDataSet1.Vacations);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(new ComboBox() { Location = new Point(545, 100), Width = 150, Height = 21 });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
