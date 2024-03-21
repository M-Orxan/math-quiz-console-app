using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            char[] operations = new char[] { '+', '-', '*', '/' };
            char[] choices = new char[] { 'A', 'B', 'C', 'D' };

            int randomNumber1;
            int randomNumber2;
            char choice;

            char operation;

            double rightAnswer;
            string userInput;

            char userAnswerChar;
            int correctAnswersCount = 0;
            int questionsCountPerGame;
            int totalQuestionsCount = 0;
            double accuracyRate;
            bool shouldContinue = true;
            bool resetGameStatistics;

            Console.WriteLine("Welcome to Math Quiz");

            while (shouldContinue)
            {

                Console.WriteLine("How many questions do you want:");
                userInput = Console.ReadLine();
                questionsCountPerGame = ConvertToInt(userInput);
                totalQuestionsCount += questionsCountPerGame;
                Console.WriteLine();

                for (int i = 1; i <= questionsCountPerGame; i++)
                {
                    randomNumber1 = random.Next(1, 51);
                    randomNumber2 = random.Next(1, 51);

                    operation = operations[random.Next(operations.Length)];

                    choice = choices[random.Next(choices.Length)];

                    Console.WriteLine($"{i}) {randomNumber1} {operation} {randomNumber2} = ?");

                    rightAnswer = CalculateRightAnswer(randomNumber1, randomNumber2, operation);


                    PrintMultipleChoices(choice, rightAnswer, random, randomNumber2);





                    Console.WriteLine();
                    Console.WriteLine("Enter your answer (A, B, C or D):");
                    userInput = Console.ReadLine();

                    userAnswerChar = ConvertUserInputToChar(userInput);

                    if (userAnswerChar == choice || userAnswerChar == char.ToLower(choice))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Right:)");
                        correctAnswersCount++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Wrong:(");
                        Console.WriteLine($"Right answer : {choice}");
                    }

                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();



                }

                accuracyRate = (double)correctAnswersCount / totalQuestionsCount * 100;

                Console.WriteLine($"Correct answers count : {correctAnswersCount}");
                Console.WriteLine($"Total questions count : {totalQuestionsCount}");
                Console.WriteLine($"Accuracy Rate : {accuracyRate}%");

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Do you want to play again? Yes or no:");
                userInput = Console.ReadLine();
                shouldContinue = ShouldContinue(userInput);

                if (shouldContinue)
                {
                    Console.WriteLine("Do you want to reset game statistics? Yes or no:");
                    userInput = Console.ReadLine();
                    resetGameStatistics = ResetGameStatictics(userInput);

                    if (resetGameStatistics)
                    {
                        totalQuestionsCount = 0;
                        correctAnswersCount = 0;
                    }
                }



                Console.WriteLine();

            }

            Console.WriteLine("Thanks for playing!");





        }

        static double CalculateRightAnswer(int number1, int number2, char operation)
        {
            double rightAnswer;


            switch (operation)
            {
                case '+':
                    rightAnswer = number1 + number2;
                    break;
                case '-':
                    rightAnswer = number1 - number2;
                    break;
                case '*':
                    rightAnswer = number1 * number2;
                    break;
                default:

                    rightAnswer = (double)number1 / number2;


                    break;
            }

            return rightAnswer;
        }

        static void PrintMultipleChoices(char choice, double rightAnswer, Random random, int randomNumber2)
        {
            Console.WriteLine();

            switch (choice)
            {
                case 'A':

                    Console.WriteLine($"A) {rightAnswer}");

                    Console.WriteLine($"B) {random.Next(1, 101)}");
                    Console.WriteLine($"C) {random.Next(1, 101)}");
                    Console.WriteLine($"D) {random.Next(1, 101)}");
                    break;
                case 'B':
                    Console.WriteLine($"A) {random.Next(1, 101)}");

                    Console.WriteLine($"B) {rightAnswer}");

                    Console.WriteLine($"C) {random.Next(1, 101)}");
                    Console.WriteLine($"D) {random.Next(1, 101)}");
                    break;
                case 'C':
                    Console.WriteLine($"A) {random.Next(1, 101)}");
                    Console.WriteLine($"B) {random.Next(1, 101)}");

                    Console.WriteLine($"C) {rightAnswer}");

                    Console.WriteLine($"D) {random.Next(1, 101)}");
                    break;
                default:
                    Console.WriteLine($"A) {random.Next(1, 101)}");
                    Console.WriteLine($"B) {random.Next(1, 101)}");
                    Console.WriteLine($"C) {random.Next(1, 101)}");

                    Console.WriteLine($"D) {rightAnswer}");


                    break;
            }
        }

        static char ConvertUserInputToChar(string input)
        {
            char symbol;


            bool isChar = char.TryParse(input, out symbol);

            while (!isChar || symbol != 'A' && symbol != 'a' && symbol != 'B' && symbol != 'b' && symbol != 'C' && symbol != 'c' && symbol != 'D' && symbol != 'd')
            {
                Console.WriteLine("Invalid input. Try again:");
                input = Console.ReadLine();
                isChar = char.TryParse(input, out symbol);
            }




            return symbol;
        }


        static int ConvertToInt(string input)
        {
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("Invalid input. Try again:");
                input = Console.ReadLine();
            }

            return result;
        }



        static bool ShouldContinue(string input)
        {

            bool result = false;
            bool breakeLoop = false;
            while (!breakeLoop)
            {
                input = input.ToLower();

                if (input == "yes")
                {

                    result = true;
                    breakeLoop = true;

                }

                else if (input == "no")
                {
                    result = false;
                    breakeLoop = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again:");
                    input = Console.ReadLine();
                }
            }

            return result;



        }


        static bool ResetGameStatictics(string input)
        {

            bool result = false;
            bool breakeLoop = false;
            while (!breakeLoop)
            {
                input = input.ToLower();

                if (input == "yes")
                {

                    result = true;
                    breakeLoop = true;

                }

                else if (input == "no")
                {
                    result = false;
                    breakeLoop = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again:");
                    input = Console.ReadLine();
                }
            }

            return result;



        }




    }
}