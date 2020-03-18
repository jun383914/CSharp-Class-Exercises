//using System class library namespace, it contains string class with several functions
using System;

namespace Form_Namespace
{
    class String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Namespace: System; \nClass: String;");
            Console.ReadLine();
            //Create variable x to store string type data
            string x = "Hello World and Nice.to.meet.you";
            Console.WriteLine("Test String is:  " + x);
            //using ReadLine method to wait for user input
            Console.ReadLine();


            //Function #1: System.String.Substring()
            //Description: It extract a portion of a string, if you omit the length, it will gives you the reminder of the string
            Console.WriteLine("Function 1: Substring()");
            string sub_s = x.Substring(5);
            Console.WriteLine("The Substring(5) fuction gives us:" + sub_s);
            Console.ReadLine();

            //Function #2: System.String.EndsWith()
            //Description: It is a way to search a string and perform a case-sensitive match.
            Console.WriteLine("Function 2: EndsWith()");
            bool endsIn = x.EndsWith("U");
            Console.WriteLine("-"+"Does the test string end with letter \"U\"?");
            Console.WriteLine(endsIn);
            Console.ReadLine();

            //Function #3: System.String.ToUpper()
            //Description: Capitalize all letters in a string
            Console.WriteLine("Function 3: ToUpper()");
            string cStr = x.ToUpper();
            Console.WriteLine("-"+"What will this function do to my string?");
            Console.WriteLine(cStr);
            Console.ReadLine();

            //Function #4: System.String.Split()
            //Description: It divides strings into pieces; By default it uses whitespace as delimiters but it can be overloaded 
            //to accept a params array of char.
            Console.WriteLine("Function 4: Split()");
            string[] split = x.Split(new char[] { ' ', '.' });
            Console.WriteLine("What does it look like using Split function with whitespace and dot? ");
            foreach (string i in split)
                {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //Function #5: System.String.PadLeft()
            //Description: It pads a string to a given length with a specific character
            Console.WriteLine("Function 5: PadLeft()");
            int length_X = x.Length;
            Console.WriteLine("-"+"What is the string look like using PadLeft function?  PadLeft with 5 *");
            Console.WriteLine(x.PadLeft(x.Length+5,'*'));
            Console.ReadLine();
        }
    }
}

//Reference: https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.8
