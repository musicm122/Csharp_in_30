using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_In_30
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

    }

}
