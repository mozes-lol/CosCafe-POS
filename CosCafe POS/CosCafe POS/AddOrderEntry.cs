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
using System.Diagnostics;

namespace CosCafe_POS
{
    public partial class AddOrderEntry : Form
    {
        public AddOrderEntry()
        {
            InitializeComponent();
        }

        private void AddOrderEntry_Load(object sender, EventArgs e)
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
                        string[] menuEntry = streamReader.ReadLine().Split(',');
                        // reads order name only (avoids reading the cost)
                        for(int studCount = 0; studCount < 1; studCount++)
                        {
                            // adds those order names to the combo box
                            comboBox_chooseOrder.Items.Add(menuEntry[0]);
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

        private void AddOrderEntry_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
