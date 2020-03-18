//using System class library namespace, it contains Math class with 5 different function listed below
using System;

namespace myMath
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Console Class and WriteLine function to display message to user
            Console.WriteLine("Namespace: System; \nClass: Math;");
            //using ReadLine function to wait for user input
            Console.ReadLine();
            //Store different types of numeric data into a,b,c,d variable
            double a = 45000.6789;
            double b = -60.3;
            double c = 5.2;
            double d = 3.8;
            //Function #1: Ceiling();
            //Description: Round up a number
            Console.WriteLine("Function 1: Ceiling()");
            double r = Math.Ceiling(b);
            Console.WriteLine("The ceiling of "+ b+ " is: " + r);
            Console.ReadLine();
            //Function #2: Floor();
            //Description: Round down a number
            Console.WriteLine("Function 2: Floor()");
            double s = Math.Floor(b);
            Console.WriteLine("Floor of" + b + "is: " + s);
            Console.ReadLine();
            //Function #3: Max();
            //Description: It returns the max of two numbers
            double u = Math.Max(a,b);
            Console.WriteLine("Function 3: Max()");
            Console.WriteLine("Max number of " + a + " and " + b + ": " + u);
            Console.ReadLine();
            //Function #4: Truncate();
            //Description: 
            Console.WriteLine("Function 4: Truncate()");
            double t = Math.Truncate(a);
            Console.WriteLine("Truncate " + a + " is: : {0:N0}", t);
            Console.ReadLine();
            //Function #5: Round();
            //Description: Rounds a value to the nearest integer or to the specified number of fractional digits
            double v = Math.Round(a,3);
            Console.WriteLine("Function 5: Round()");
            Console.WriteLine("If we set the fractional digits to 3, the rounding value of " + a + " will be: " + v);
            Console.ReadLine();

        }
    }
}

//The example is from website: https://docs.microsoft.com/en-us/dotnet/api/system.math?view=netframework-4.8
