using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

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
            // loads Menu.csv
            using (var streamReader = new StreamReader(@"\Menu.csv"))
            {
                // reads Menu.csv
                try
                {
                    // as long as the next line is not null...
                    while (streamReader.Peek() != -1)
                    {
                        // takes a line a splits it into two parts: The ORDER NAME and the COST
                        string[] order = streamReader.ReadLine().Split(',');
                        // reads order name only (avoids reading the cost)
                        for (int studCount = 0; studCount < 1; studCount++)
                        {
                            // adds those order names to the combo box
                            comboBox_chooseOrder.Items.Add(order[0]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // in case if it doesn't work
                    Debug.Print("You monkey! Look what have you done: " + ex);
                }
            }
        }

        private void button_addOrderDetails_Click(object sender, EventArgs e)
        {
            Form addOrderEntry = new AddOrderEntry();
            Form main = new Main();
            addOrderEntry.Show();
        }

        private void comboBox_chooseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            // As soon as the user makes a choice on the order ComboBox, the program will go back to Menu.csv, find the selected
            // order on the list, look at its corresponding cost, and print that cost on textBox_cost.
            string selectedOrder = comboBox_chooseOrder.SelectedItem.ToString();
            using (var streamReader = new StreamReader(@"\Menu.csv"))
            {
                try
                {
                    bool hasFoundMatchingOrder = false;
                    while (hasFoundMatchingOrder == false)
                    {
                        // takes a line a splits it into two parts: The ORDER NAME and the COST
                        string[] order = streamReader.ReadLine().Split(',');
                        if (selectedOrder == order[0])
                        {
                            numericUpDown_cost.Text = order[1];
                            hasFoundMatchingOrder = true;
                            numericUpDown_Quantity.Text = "1";
                        }
                    }

                }
                catch (Exception ex)
                {
                    // in case if it doesn't work
                    Debug.Print("You monkey! Look what have you done: " + ex);
                }
            }
        }
    }
}
