using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Library2;

namespace Test
{
    

    class Program
    {
        public static Person person;
        public static void LoadAssemblyTest()
        {
            var dllFile = Assembly.LoadFile(@"D:\gitLib\C-Project\Test\Test\bin\Debug\Library2.dll");
            var personType = dllFile.GetType(@"Library2.Person");
            Person personInstance = (Person)dllFile.CreateInstance(@"Library2.Person");
            personType.GetProperty("Name").SetValue(personInstance, "mihao", null);
            var name = personType.GetProperty("Name").GetValue(personInstance);
            person = personInstance as Person;
        }

        static void Main(string[] args)
        {
            LoadAssemblyTest();
            if (Person.Name == null)
            {
                Console.WriteLine("Person.Name is null ");
            }
            else
            {
                Console.WriteLine("Person.Name is : {0}", Person.Name);
            }

            Console.ReadKey();

        }
    }
}
