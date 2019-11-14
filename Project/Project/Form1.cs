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
using Project.Tools;

namespace Project
{
    public partial class Form1 : Form
    {

        IList<IBundle> bundles;
        List<string> bundleNames = new List<string>();
        Dictionary<string, IBundle> bundleNameMap = new Dictionary<string, IBundle>();

        private void initBundleMap(IList<IBundle> bundles)
        {
            foreach (IBundle bundle in bundles)
            {
                bundleNames.Add(bundle.GetSymbolicName());
                bundleNameMap.Add(bundle.GetSymbolicName(), bundle);
            }
        }

        public void initFramework()
        {
            var frameworkFactory = new FrameworkFactory();
            var framework = frameworkFactory.CreateFramework();

            framework.Init();
            framework.Start();

            bundles = framework.GetBundleContext().GetBundles();

        }

        public Form1()
        {
            InitializeComponent();

            initFramework();
            initBundleMap(bundles);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        PluginDetailForm pluginDetailForm;
        private void 状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            ToolStripItem parentToolStrip = toolStripMenuItem.OwnerItem;
            string text = parentToolStrip.Text;

            string bundleName = Tools.Tools.toolStripMenuItemText2BundleName(text);
            IBundle bundle = Tools.Tools.getBundleByName(bundleName, bundles);
            int bundleState = bundle.GetState();
            string bundleStateString = Tools.Tools.transState(bundleState);

            pluginDetailForm = new PluginDetailForm(bundleName, bundleStateString);

            pluginDetailForm.Text = text;
            pluginDetailForm.Show();
        }

        private void 状态信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pluginDetailForm = new PluginDetailForm();
            pluginDetailForm.Show();
        }

        private void 状态信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pluginDetailForm = new PluginDetailForm();
            pluginDetailForm.Show();
        }

        private void 状态信息ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pluginDetailForm = new PluginDetailForm();
            pluginDetailForm.Show();
        }
    }
}
