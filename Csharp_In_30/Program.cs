//this states the Namespaces used in the application 
using System;

namespace Csharp_In_30
{
    //
    public class Program
    {
        static void Main()
        {
            //The user of this application
            Person user;

            Console.WriteLine("Ello Mate.\r\nWhat is your name?");
            user = new Person(Console.ReadLine());

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
