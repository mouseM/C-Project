using OSGi.NET.Core.Root;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBPlugin;
using EventHandlePlugin;
using TestPlugin;
using CachePlugin;
using LogPlugin;

namespace Project
{
    class BundleTools
    {
        public IFramework Framework { get; set; }
        public IDBServices DBservice { get; set; }
        public IEventService EventService { get; set; }
        public ILogService LogService { get; set; }

        public BundleTools(IFramework framework)
        {
            this.Framework = framework;
            initServices();
        }

        public void initServices()
        {
            var context = Framework.GetBundleContext();
            DBservice = context.GetService<IDBServices>();
            EventService = context.GetService<IEventService>();
            LogService = context.GetService<ILogService>();

        }

    }
}
