using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string lettergrade = "";

        if (percentage>=97)
        {
            lettergrade = "A";
        }
        else if (percentage >= 90)
        {
            lettergrade = "A-";
        }
        else if(percentage>=87)
        {
            lettergrade = "B+";
        }
        else if (percentage >= 82)
        {
            lettergrade = "B";
        }
        else if(percentage>= 80)
        {
            lettergrade = "B-";
        }
        else if (percentage>=77)
        {
            lettergrade = "C+";
        }
        else if (percentage >= 73)
        {
            lettergrade = "C";
        }
        else if (percentage >= 68)
        {
            lettergrade = "C-";
        }
        else if (percentage >= 64)
        {
            lettergrade = "D+";
        }
        else if (percentage >= 60)
        {
            lettergrade = "D";
        }
        else if (percentage >= 58)
        {
            lettergrade = "D-";
        }
        else
        {
            lettergrade = "F-";
        }

        Console.WriteLine($"Grade: {lettergrade}");
        
        if (percentage >= 70)
        {
            Console.WriteLine("Congrats!! You've passed this class!");
        }
        else
        {
            Console.WriteLine("I'm sorry. Unfortunately you have not passed this class!");
        }
    }
}