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

        //Creating method to check validation
        public bool Validate(string info, string Pattern)
        {
            return Regex.IsMatch(info, Pattern);
        }
    }
}