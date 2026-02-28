// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

// Theme A - Student Score Analyzer
//      Process a set of monetary values representing expenses.

class Program
{
    static void Main()
    {
        string[] subject = new string[5];
        int[] scores = new int[5];

        Console.Write("1. Enter Test Scores\n2. Display Scores\n3. Analyze Scores \n4. Exit ");


        int number;

        do
        {
            Console.WriteLine("Enter a menu option (1-4): ");
            number = int.Parse(Console.ReadLine());

                
                if (number < 1 || number > 4)
                {
                    Console.WriteLine("Invalid option. Please try again.");

                }
                else if (number == 1)
                {
                    Console.WriteLine("Enter Test Subject: ");
                    string subjectName = Console.ReadLine();

                    Console.WriteLine("Enter Test Score: ");
                    double score = double.Parse(Console.ReadLine());

                }
                else if (number == 2)
                {
                    
                }
                else if (number == 3)
                {
                    
                }
                else if (number == 4)
                {
                    Console.WriteLine("Goodbye! ");
                    break;
                }


        } while (number >= 1 && number <= 4);

    }

    
    
}