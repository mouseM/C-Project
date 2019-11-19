using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventHandlePlugin;
using log4net;
using LogPlugin;
using DBPlugin;
using ModelPlugin;

namespace TestPlugin
{
    class ListenerTest : IListener
    {
        private IEventService eventService;
        private ILogService logService;
        private IDBServices dBServices;
        private ILog log;

        public ListenerTest(IEventService eventService, ILogService logService, IDBServices dBServices)
        {
            this.eventService = eventService;
            this.logService = logService;
            this.dBServices = dBServices;
            log = logService.GetLogger(typeof(ListenerTest));
            eventService.registListener(this);
        }

        public void notify(Event e)
        {
            EventMessage message = e.getMessage();

            Person person = new Person();
            person.Age = 66;
            person.name = "接受到事件";
            dBServices.createOperation(person);
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
