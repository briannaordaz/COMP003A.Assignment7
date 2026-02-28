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
        
        Console.Write("1. Enter Test Scores\n2. Display Scores\n3. Total Score\n4. Average Score\n5. Exit");


        int number = 0;

        do
        {
            try
            {

                Console.WriteLine("\nEnter a menu option (1-5): ");
                number = int.Parse(Console.ReadLine());


                if (number < 1 || number > 5)
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


                    DisplayScores(scores, subject, index);


                }
                else if (number == 3)
                {


                    int totalScore = ScoreTotalCalculation(scores, index);

                    Console.WriteLine($"Total Sum: {totalScore}");


                }
                else if (number == 4)
                {


                    int totalScore = ScoreTotalCalculation(scores, index);
                    double averageScore = (double) totalScore / index;
                    Console.WriteLine($"Average Score: {averageScore}");


                }
                else if (number == 5)
                {
                    Console.WriteLine("Goodbye! ");
                    break;


                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input");
            }


        } while (number >= 1 && number <= 5);

        
    }

    
    //This method displays the subject name and score of the tests
    static void DisplayScores(int[] scores, string[] subject, int index)
    {
        /* A bug I was facing while working on my program is that since I used scores.Length in the DisplayScores() method,
         the program kept getting empty values displayed. To fix it I passed down the index variable and did “i < index” 
         so that ONLY the scores entered can be displayed on the program */
        for (int i = 0; i < index; i++) 
        {
            
            Console.WriteLine($"Subject: {subject[i]}, Score: {scores[i]}");
            
        }
        
    }

    //This method calculates the sum of the scores entered on the program
    static int ScoreTotalCalculation(int[] scores, int index)
    {
        int totalSum = 0;
        for (int i = 0; i < index; i++)
        {
            
            totalSum += scores[i];
            
        }
        return totalSum;
    }

    



}