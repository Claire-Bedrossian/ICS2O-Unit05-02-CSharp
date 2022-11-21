// Created by: Claire Bedrossian
// Created on: Nov 2022
//
// This program is a game to guess a random number the computer has generated.

using System;

class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        // This function accepts user input
        string integerType;
        float num = random.Next(1, 10);
        float negativeNum = random.Next(-10, -1);
        string positive = "positive";

        Console.WriteLine("Write below either positive or negative to recieve a random positive or negative number from one to ten...");
        Console.WriteLine("");

        Console.Write("Enter your guess: ");
        integerType = Convert.ToString(Console.ReadLine());

        if (integerType == positive)
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine(negativeNum);
        }

        Console.WriteLine("");
        Console.WriteLine("\nDone.");
    }
}