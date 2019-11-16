using OSGi.NET.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventHandlePlugin;
using LogPlugin;

namespace TestPlugin
{
    public class Class1 : IBundleActivator
    {
        private IEventService eventService;
        private ILogService logService;

        public void Start(IBundleContext context)
        {
            var eventServiceReference = context.GetServiceReference<IEventService>();
            eventService = context.GetService<IEventService>(eventServiceReference);

            var logServiceReference = context.GetServiceReference<ILogService>();
            logService = context.GetService<ILogService>(logServiceReference);

        }

        public void Stop(IBundleContext context)
        {
            throw new NotImplementedException();
        }
    }
}
