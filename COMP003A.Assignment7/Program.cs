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
        int index = 0;
        
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
                    subject[index] = subjectName;
                    
                    Console.WriteLine("Enter Test Score: ");
                    int subjectScore = int.Parse(Console.ReadLine());
                    scores[index] = subjectScore;
                    index++;

                }
                else if (number == 2)
                {
                    DisplayScores(scores, subject);
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


    static void DisplayScores(int[] scores, string[] subject)
    {
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine($"Subject: {subject[i]}, Score: {scores[i]}");
        }
        
    }

    
    
}