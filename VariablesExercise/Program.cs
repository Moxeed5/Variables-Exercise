﻿namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            char letter = 'a';

            bool nay = false;

            double num = 222;

            decimal bigNum = 10000; 

            //console write line prompting user for info

            Console.WriteLine("Enter your Name");

            //declaring a variable name to capture user input with Readline

            string name = Console.ReadLine();

            //prompt user to enter age
           
            Console.WriteLine("Input your age");

            // record user answer onto age variable
            int age = int.Parse(Console.ReadLine());



            Console.WriteLine($"Hi {name}, you are {age} years old.");

            Console.WriteLine($"If someone said that {num} > {bigNum}, that would {letter} {nay} statement.");

      
            


        }
    }
}
