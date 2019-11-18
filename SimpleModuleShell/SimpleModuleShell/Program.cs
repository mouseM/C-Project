using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIShell.OSGi;
namespace SimpleModuleShell
{
    class Program
    {
        static void Main(string[] args)
        {
            using(BundleRuntime bundleRuntime = new BundleRuntime())
            {
                bundleRuntime.Start();

                Console.WriteLine("hello!");
                Console.ReadLine();
            }
        }
    }
}
