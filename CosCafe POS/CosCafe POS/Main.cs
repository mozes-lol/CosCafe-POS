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
        float totalCost;

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

        private void button_enterOrderEntry_Click(object sender, EventArgs e)
        {
            listBox_orderName.Items.Add(comboBox_chooseOrder.SelectedItem);
            listBox_quantity.Items.Add(numericUpDown_Quantity.Value);
            // If the user choose an order with a quantity of 2 or more, we multiply the cost by that quantity.
            float multipliedCost = (float)numericUpDown_Quantity.Value * (float)numericUpDown_cost.Value;
            listBox_orderCost.Items.Add(multipliedCost);
            totalCost += multipliedCost;
            label_totalCostNumber.Text = totalCost.ToString();
        }

        private void listBox_orderName_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listBox_orderName.SelectedIndex;
                // removing an item in the COL
                listBox_orderName.Items.RemoveAt(listBox_orderName.SelectedIndex);
                listBox_quantity.Items.RemoveAt(selectedIndex);
                // Since we're removing the cost of the order, we deduct it to the total cost.
                listBox_orderCost.SelectedIndex = selectedIndex;
                float deduct = (float)listBox_orderCost.SelectedItem;
                totalCost -= deduct;
                listBox_orderCost.Items.RemoveAt(selectedIndex);
                label_totalCostNumber.Text = totalCost.ToString();
            }
            catch (Exception ex)
            {
                // in case if it doesn't work
                Debug.Print("You monkey! Look what have you done: " + ex);
            }
        }

        private void clearOrderList()
        {
            // removes everything in the COL
            listBox_orderCost.Items.Clear();
            listBox_quantity.Items.Clear();
            listBox_orderName.Items.Clear();
            totalCost = 0;
            label_totalCostNumber.Text = totalCost.ToString();
        }

        private void button_deleteOrderList_Click(object sender, EventArgs e)
        {
            clearOrderList();
        }

        private void button_confirmCustomerOrderList_Click(object sender, EventArgs e)
        {
            // The ROS will display the following:
            // - Order Name
            // - Quantity
            // - Cost (Multiplied by Quantity)
            // (P.S: Calculations and counting of data can all be handled on Excel. So don't worry about data organization.)
            StreamWriter streamWriter = new StreamWriter(@"\RecordOfSales.csv", true);
            for (int line = 0; line < listBox_orderName.Items.Count; line++)
            {
                streamWriter.WriteLine
                    (
                        listBox_orderName.Items[line].ToString() + "," +
                        listBox_quantity.Items[line].ToString() + "," +
                        listBox_orderCost.Items[line].ToString() + "," +
                        DateTime.Now.ToString()
                    );
            }
            streamWriter.Close();
            clearOrderList();
        }
    }
}
