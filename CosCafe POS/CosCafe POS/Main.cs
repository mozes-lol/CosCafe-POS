using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosCafe_POS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void listBox_orderName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button_addOrderDetails_Click(object sender, EventArgs e)
        {
            Form addOrderEntry = new AddOrderEntry();
            Form main = new Main();
            addOrderEntry.Show();
        }
    }
}
