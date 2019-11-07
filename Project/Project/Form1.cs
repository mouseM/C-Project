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
    public partial class Form1 : Form
    {

        IList<IBundle> bundles;
        List<string> bundleNames = new List<string>();
        Dictionary<string, IBundle> bundleNameMap = new Dictionary<string, IBundle>();

        private void initBundleMap(IList<IBundle> bundles)
        {
            foreach(IBundle bundle in bundles)
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
            
            
        }

        private string transName(IBundle bundle)
        {
            string bundleName = bundle.GetSymbolicName();
            switch(bundleName)
            {
                case "LogPlugin":
                    return "日志插件";

                case "CachePlugin":
                    return "缓存插件";

                case "DBPlugin":
                    return "数据库插件";

                case "EventHandlePlugin":
                    return "消息插件";

                default:
                    return null;

            }
        }

        private string transName(string itemName)
        {
            switch(itemName)
            {
                case "缓存插件ToolStripMenuItem":
                    return "CachePlugin";

                case "日志插件ToolStripMenuItem":
                    return "LogPlugin";

                case "数据库插件ToolStripMenuItem":
                    return "DBPlugin";

                case "消息插件ToolStripMenuItem":
                    return "EventHandlePlugin";

                default:
                    return null;
            }
            
        }

        private string transState(int state)
        {
            switch(state)
            {
                case 0x00000001:
                    return "uninstall";

                case 0x00000002:
                    return "installed";

                case 0x00000004:
                    return "resolved";

                case 0x00000008:
                    return "starting";

                case 0x00000010:
                    return "stopping";

                case 0x00000020:
                    return "active";

                default:
                    return null;
            }
            
        }

        //private transState(string state)
        //{
        //    switch(state)
        //    {
        //        case ""
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripItemCollection toolStripItemCollection = this.pluginToolStripMenuItem.DropDownItems;
            int itemSize = toolStripItemCollection.Count;
            for (int index = 0; index < itemSize; index ++)
            {
                ToolStripItem toolStripItem = toolStripItemCollection[index];
                string toolStripItemName = toolStripItem.Name;
                string bundleName = transName(toolStripItemName);
                if (!bundleName.Contains(bundleName))
                {
                    toolStripItem.Enabled = false;
                }
                try
                {
                    IBundle bundle = bundleNameMap[bundleName];
                } catch
                {
                    continue;
                }
                
                var bundleState =  transState(bundleNameMap[bundleName].GetState());
                 
                ToolStripMenuItem toolStripMenuItem = toolStripItem as ToolStripMenuItem;
                ToolStripItemCollection subtoolStripItemCollection = toolStripMenuItem.DropDownItems;
                foreach(ToolStripItem subToolStripItem in subtoolStripItemCollection)
                {

                }
            }
            
            ToolStripItem toolStripItem2 = toolStripItemCollection[1];
        }
    }
}
