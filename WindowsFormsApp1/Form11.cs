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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proektDataSet1);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proektDataSet1.Workers". При необходимости она может быть перемещена или удалена.
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            workersBindingSource.AddNew();
            workersBindingSource.EndEdit();
            workersTableAdapter.Update(proektDataSet1);

        }

       
    }
}
