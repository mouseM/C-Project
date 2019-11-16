using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventHandlePlugin;
using log4net;
using LogPlugin;

namespace TestPlugin
{
    class ListenerTest : IListener
    {
        private IEventService eventService;
        private ILogService logService;
        private ILog log;

        public ListenerTest(IEventService eventService, ILogService logService)
        {
            this.eventService = eventService;
            this.logService = logService;
            log = logService.GetLogger(typeof(ListenerTest));
            eventService.registListener(this);
        }

        public void notify(Event e)
        {
            EventMessage message = e.getMessage();
            if (message != null)
            {
                log.Info("recieve message!");
            }
            else
            {
                log.Info("unable to recieve message!");
            }
        }
    }
}
