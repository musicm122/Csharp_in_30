using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_In_30
{
    //class definition
    public class Person
    {
        //constructor
        public Person()
        {
        }

        //overloaded constructor
        public Person(string name)
        {
            this.Name = name;
        }

        //property
        public string Name { get; set; }

    }

}
