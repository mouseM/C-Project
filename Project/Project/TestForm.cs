using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBPlugin;
using ModelPlugin;
using BundleServicesProvider;
using OSGi.NET.Core;

namespace Project
{
    public partial class TestForm : Form
    {
        private IDBServices dBServices;
        public TestForm()
        {
            //dBServices = BunderServicesProvider.DBServices as DBServices;
            BunderServicesProvider instance = BunderServicesProvider.getInstance();
            dBServices = instance.getDBServices();
            InitializeComponent();
        }

        public TestForm(IDBServices dBServices)
        {
            //this.dBServices = dBServices;
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string name = this.nameTextBox.Text;
            string age = this.ageTextBox.Text;
            Person person = new Person();
            person.name = name;
            person.Age = int.Parse(age);
            AppDomain currentDomain = AppDomain.CurrentDomain;

            dBServices.createOperation(person);
        }
    }
}
