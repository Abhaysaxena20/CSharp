using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Class1
    {
        public string Name;
        public string EMAIL;
        public Class1(string name,string email)
        {
            this.Name = name;
            this.EMAIL = email;
        }
        public Class1(Class1 obj)
        {
            this.Name = obj.Name;
            this.EMAIL = obj.EMAIL;

        }
    }
}
