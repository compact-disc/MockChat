﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockChatWindows
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void AboutLoad(object sender, EventArgs e)
        {

        }

        private void AboutClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
