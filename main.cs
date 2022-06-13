// Created by: Evgeny Vovk
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program calculate which movie rate can you watch
        int number1;
        int number2;
        var answer = 0;
        var repeat = 0;

        // input
        Console.Write("\nThis program multiplies two numbers using a loop system. ");
        Console.WriteLine("");
        Console.Write("\nInput the first number: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the second number: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        // process
        Console.WriteLine("");
        while (repeat < number1)
        {
          answer = answer + number2;
          repeat++;
        }
        Console.WriteLine("The answer is " + answer + ".");
        Console.WriteLine("\nDone.");
    }
}