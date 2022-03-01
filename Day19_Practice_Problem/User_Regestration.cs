﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Practice_Problem
{
    internal class User_Regestration
    {
        public void FirstName()
        {
            Console.Write("Enter the name = ");
            string name = Console.ReadLine();
            string Pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Validate(name, Pattern))
                Console.WriteLine("The entered name is valid!!");
            else
                Console.WriteLine("Please enter the valid name..");
        }

        public void LastName()
        {
            Console.WriteLine("Enter the last name = ");
            string name = Console.ReadLine();
            string pattern = "^[A-Z][a-zA-Z]{2,}$";
            if (Validate(name, pattern))
                Console.WriteLine("The entered last name is valid!!");
            else
                Console.WriteLine("Please enter the valid last name..");
        }

        public void EmailId()
        {
            Console.Write("Enter the email id = ");
            string emailId = Console.ReadLine();
            string pattern = "^[A-Za-z0-9]{3,}([.][A-Za-z0-9]{3,})?[@][a-zA-Z]{2,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2})?$";

            if (Validate(emailId, pattern))
                Console.WriteLine("The entered email id is valid!!");
            else
                Console.WriteLine("Please enter the valid email id..");
        }

        //Creating method to check validation
        public bool Validate(string info, string Pattern)
        {
            return Regex.IsMatch(info, Pattern);
        }
    }
}
