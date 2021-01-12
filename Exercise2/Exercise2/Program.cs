/*
Programmer: Felipe SG
Date: 12/01/2021
Program: Exercise2
Objective: 
Which of the following values can be assigned to variables of type float,
double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
3456.091124875956542151256683467?
 */

using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Float 6 to 9 digits (32 bits)
            float Float = 5F;
            float Float2 = -5.01F;
            float Float3 = 12.345F;
            // Double 15 to 17 digits (64 bits)
            double Double = 34.567839023D;
            double Double2 = 8923.1234857D;
            //Decimal 28 to 29 digits (128 bits)
            decimal Decimal = 3456.091124875956542151256683467M;

            //Print to console 
            Console.WriteLine("Float values: {0}, {1}, {2}", Float, Float2, Float3, "/n");
            Console.WriteLine("Double values: {0}, {1}", Double, Double2, "/n");
            Console.WriteLine("Decimal values: {0}", Decimal, "/n");
        }
    }
}
