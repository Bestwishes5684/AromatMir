﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AromatMir.Formssss
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Authorization_BTN_Click(object sender, EventArgs e)
        {
            ATH aTH = new ATH();    
            aTH.ShowDialog();   
        }
    }
}
