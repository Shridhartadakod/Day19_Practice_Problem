using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USer Regestration:");
            User_Regestration registration = new User_Regestration();
            registration.FirstName();
            Console.ReadKey();
        }
    }
}
