﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }


        BundleDetialsForm bundleDetialsForm;
        private void stateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bundleDetialsForm = new BundleDetialsForm();
            bundleDetialsForm.Text = "New Name";
            bundleDetialsForm.Show();
            
        }

        private void stateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }
    }
}
