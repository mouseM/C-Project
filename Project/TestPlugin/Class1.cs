using OSGi.NET.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventHandlePlugin;
using LogPlugin;
using DBPlugin;

namespace TestPlugin
{
    public class Class1 : IBundleActivator
    {
        private IEventService eventService;
        private ILogService logService;
        private IDBServices dBServices;

        public void Start(IBundleContext context)
        {
            var eventServiceReference = context.GetServiceReference<IEventService>();
            eventService = context.GetService<IEventService>(eventServiceReference);

            var dbServiceReference = context.GetServiceReference<IDBServices>();
            dBServices = context.GetService<IDBServices>(dbServiceReference);

            var logServiceReference = context.GetServiceReference<ILogService>();
            logService = context.GetService<ILogService>(logServiceReference);
            ListenerTest listener = new ListenerTest(eventService, logService, dBServices);
        }

        public void Stop(IBundleContext context)
        {
            
        }
    }
}
