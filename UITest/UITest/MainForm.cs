using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestLib;

namespace UITest
{
    public partial class MainForm : Form
    {
        private Person person;

        public MainForm()
        {
            InitializeComponent();
            Class1 class1 = new Class1();
            class1.testMethod();
            person = class1.person;
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
