﻿using log4net;
using LogPlugin;
using OSGi.NET.Core;
using OSGi.NET.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlePlugin
{
    public class Class1 : IBundleActivator
    {

        private IServiceRegistration serviceRegistration;
        private ILogService logService;
        private ILog log;
        public void Start(IBundleContext context)
        {
            string fullName = typeof(ILogService).Assembly.FullName;
            var logServiceReference = context.GetServiceReference<ILogService>();
            logService = context.GetService<ILogService>(logServiceReference);

            log = logService.GetLogger(typeof(Class1));

            // 注册服务
            serviceRegistration = context.RegisterService<IEventService>(new EventService());

            log.Info("EventHandlePlugin Started!");
        }

        public void Stop(IBundleContext context)
        {
            log.Info("EventHandlePlugin Stopped!");
        }
    }
}
