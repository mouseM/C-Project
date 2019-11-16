using EventHandlePlugin;
using log4net;
using LogPlugin;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPlugin;

namespace DBPlugin
{

    class DBServices: IDBServices, IPublisher
    {
        private ILogService logService;
        private IEventService eventService;
        private static string SqlServerConnString = @"Data Source=127.0.0.1,1433;database=MihTest;uid=sa;pwd=123";
        private SqlSugarClient db;

        private ILog log;

        public DBServices()
        {
            log = logService.GetLogger(typeof(DBServices));
        }

        public DBServices(ILogService logService, IEventService eventService)
        {
            this.logService = logService;
            this.eventService = eventService;
            initDBServices();
        }

        public bool createOperation(Model model)
        {
            try
            {
                // 数据库添加一条数据， 并告诉相关订阅者；
                db.Insertable(model).ExecuteCommand();
                post();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool deleteOperation(string sqlCommond)
        {
            return false;
        }

        public bool executeCommands(string sqlCommand)
        {
            return false;
        }


        public bool modifyOperation(string sqlCommond)
        {
            return false;
        }

        public object queryOperation(string sqlCommond)
        {
            return null;
        }

        public List<object> queryOperations(string sqlCommond)
        {
            return null;
        }

        public void initDBServices()
        {
            db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = SqlServerConnString,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            }
            );

            db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" +
                db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
        }

        private EventMessage GetEventMessage
        {
            get
            {

                EventMessage eventMessage = new EventMessage();

                return eventMessage;
            }
        }

        public void post()
        {
            DBEvent dBEvent = new DBEvent(GetEventMessage);
            eventService.postEvent(dBEvent);
        }
    }
}
