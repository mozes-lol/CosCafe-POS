﻿using System;
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
            //using (var streamReader = new StreamReader(@"Menu.csv"))
            {

            }
        }

        private void AddOrderEntry_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
