using NLog.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
namespace NLogTest
{
    class Program
    {
        static void Main(string[] args)
{
            NLog.Logger logger = LogManager.GetCurrentClassLogger();
            logger.Debug("hello world!");
        }
    }
}
