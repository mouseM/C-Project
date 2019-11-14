using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class PluginDetailForm : Form
    {
        private string bundleName = "插件信息";
        private string bundleState = null;

        public PluginDetailForm()
        {
            InitializeComponent();
        }

        public PluginDetailForm(string bundleName, string bundleState)
        {
            this.bundleName = bundleName;
            this.bundleState = bundleState;
            
            InitializeComponent();
            stateDetialLabel.Text = bundleState;

        }


        public string BundleName { get => bundleName; set => bundleName = value; }
        public string BundleState { get => bundleState; set => bundleState = value; }
        
    }
}
