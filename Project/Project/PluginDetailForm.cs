using OSGi.NET.Core;
using OSGi.NET.Core.Root;
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
        private IBundle bundle;
        private IFramework framework;

        public PluginDetailForm()
        {
            InitializeComponent();
        }

        public PluginDetailForm(IFramework framework, string bundleName, string bundleState)
        {
            this.bundleName = bundleName;
            this.bundleState = bundleState;
            bundle = framework.GetBundleContext().GetBundle(bundleName);
            this.framework = framework;
            InitializeComponent();
            stateDetialLabel.Text = bundleState;
            
        }


        public string BundleName { get => bundleName; set => bundleName = value; }
        public string BundleState { get => bundleState; set => bundleState = value; }

        private void activeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //string radioButtonSenderText = ((RadioButton)sender).Text;
            //IBundle bundle = framework.GetBundleContext().GetBundle(bundleName);
            //if (radioButtonSenderText.Equals("激活"))
            //{
            //    bundle.Start();
            //}
            //if (radioButtonSenderText.Equals("停止"))
            //{
            //    bundle.Stop();
            //}
            //if (radioButtonSenderText.Equals("卸载"))
            //{

            //}
            //if (radioButtonSenderText.Equals("安装"))
            //{

            //}
            bundle.Start();
                
        }

        private void stopRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bundle.Stop();
        }

        private void installRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void uninstallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            bundle.UnInstall();
        }
    }
}
