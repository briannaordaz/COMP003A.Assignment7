// See https://aka.ms/new-console-template for more information
using System;


// Theme A - Student Score Analyzer
//      Process a set of monetary values representing expenses.

class Program
{
    static void Main()
    {
        
        //this is where the string and integer arrays are declared and initialized
        //syntax  data type[] variable = new data type[size]
            string[] subject = new string[5];
            int[] scores = new int[5];
            int index = 0;
        
        Console.Write("1. Enter Test Scores\n2. Display Scores\n3. Total Score\n4. Average Score\n5. Exit");


        int number = 0;

        //this do-while loop will continue to display the menu prompt as long as the user enters a number equal to or greater than 1 and less than 5.
        //if user chooses option 1, they will be prompted to add the subject of the test and the score
        //if user chooses option 2, both the subject and score of the tests will be displayed
        //if user chooses option 3, the program will display the total sum of all the test scores
        //if user chooses option 4, the program will display the average of all the test scores
        //if user chooses option 5, the program will display a goodbye message and end the execution
        do
        {
            //this try-catch block will handle non-numeric input, if the user enters a value that is not an integer, the program will display "invalid input"
            //if it does not catch any errors, the program will continue executing
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

    
    //This method displays the subject name of the tests and their scores,
    //it has 3 parameters, an integer array named 'scores, a string array called 'subject' and an integer named 'index'
    //they are all passed down from the Main() method
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