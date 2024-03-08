using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Arithmetic_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("  Arithmetic Quiz");
            Console.WriteLine("----------------------\n");

            int totalScore = 0, totalQuestions = 0;
            string value;
            do {
                int num1, num2, result;

                // Generate random numbers and choose a random operator
                Random random = new Random();
                string[] operators = { "+", "-", "*", "/" };
                int operatorIndex = random.Next(operators.Length);
                string selectedOperator = operators[operatorIndex];


                // Generate the question 
                num1 = random.Next(1, 20);
                num2 = random.Next(1, 20);
                string question = $"What is {num1}{selectedOperator}{num2}= ?  ";
                Console.Write(question);

                // Get the user's answer
                // Check if the user's answer is an integer
                bool isInteger = int.TryParse(Console.ReadLine(), out result);
                if (!isInteger)
                { Console.Write("Incorrect! You've entered an invalid number.");
                } else { 

                   // Check if the user's answer is correct and tally score
                switch (selectedOperator) {
                    case "+":
                        if (result == num1 + num2)
                        {
                            Console.Write("Correct!");
                            totalScore++;
                        }
                        else
                        {
                            Console.Write("Incorrect!");
                        }
                        break;
                    case "-":
                        if (result == num1 - num2)
                        {
                            Console.Write("Correct!");
                            totalScore++;
                        }
                        else
                        {
                            Console.Write("Incorrect!");
                        }
                        break;
                    case "*":
                        if (result == num1 * num2)
                        {
                            Console.Write("Correct!");
                            totalScore++;
                        }
                        else
                        {
                            Console.Write("Incorrect!");
                        }
                        break;
                    case "/":
                        if (result == num1 / num2)
                        {
                            Console.Write("Correct!");
                            totalScore++;
                        }
                        else
                        {
                            Console.Write("Incorrect!");
                        }
                        break;
                }
            }
                // Tally the total number of questions
                totalQuestions++;

                // Ask the user if they want to continue answering questions
                Console.Write("  Do you want to continue(y/n): ");
                value = Console.ReadLine();
                Console.WriteLine();
            }
            // Continue asking questions if the user enters "y"
            while (value.ToLower() == "y");

            int percentage = (totalScore * 100) / totalQuestions;

            // Display the user's score
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine($" Your score is {percentage}%");
            Console.WriteLine($" You got {totalScore} out of {totalQuestions} questions correct.");
            Console.WriteLine("----------------------------------------");

        }
    }
}
