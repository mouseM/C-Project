using OSGi.NET.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBPlugin;
using LogPlugin;
using EventHandlePlugin;
using log4net;
using System.Threading;

namespace BundleServicesProvider
{
    public class Class1 : IBundleActivator
    {
        private IDBServices dBServices;
        private ILogService logService;
        private IEventService eventService;
        private ILog log;
        public void Start(IBundleContext context)
        {
            dBServices = context.GetService<IDBServices>();
            logService = context.GetService<ILogService>();
            eventService = context.GetService<IEventService>();
            //BunderServicesProvider.Context = context;
            //BunderServicesProvider.DBServices = dBServices;
            //BunderServicesProvider.LogService = logService;
            //BunderServicesProvider.EventService = eventService;
            //BunderServicesProvider.TestString = "mihao";
            BunderServicesProvider instance = BunderServicesProvider.getInstance();
            instance.setDBServices(dBServices);
            instance.setEventService(eventService);
            instance.setLogServiecs(logService);
            log = logService.GetLogger(typeof(Class1));
          
            log.Info("BundleServicesProvider Started!");


        }



        public void Stop(IBundleContext context)
        {
            log.Info("BundleServicesProvider Stopped!");
        }
    }
}
