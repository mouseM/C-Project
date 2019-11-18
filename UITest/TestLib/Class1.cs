using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class Class1
    {
        public Person person { set; get; }

        public void testMethod()
        {
            Person person = new Person();
            person.Name = "mih";
            person.Age = 25;
            this.person = person;
        }
    }
}
