//this states the Namespaces used in the application 
using System;

namespace Csharp_In_30
{
    //class definition
    public class Program
    {
        //entry method
        static void Main()
        {
            //Object of the type
            Person user = new Person();

            Console.WriteLine("Ello Mate.\r\nWhat is your name?");
            user.Name = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(user.Name))
            {
                Console.WriteLine("Well thats just a mite bit bloody rude. Good day to you indeed");
            }
            else
            {
                Console.WriteLine("Well nice to meet you. " + user.Name);
            }

            Console.ReadLine();
        }
    }
}
