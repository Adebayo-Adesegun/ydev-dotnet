using System;

namespace YdevAcademy_Module_2
{
    class Program
    {
        static void Main(string[] args)
        {


            Dog dog = new Dog();

            dog.MakeSound();

            dog.Name = "Bingo terry";


            Console.WriteLine("Please enter your name");

            string userName = Console.ReadLine();

            Console.WriteLine("-------------------------------------------------");

            string greetings = $"Hello {userName}! \n  \n Welcome to YdevAcademy Module 2";


            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine(greetings);

            Console.WriteLine("-------------------------------------------------");


            Console.WriteLine("Please enter the first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int num2 = int.Parse(Console.ReadLine());



            //Console.WriteLine("Please specify what operation you want to perform. \n  Enter 1 for Addition \n Enter 2 for Subtraction \n Enter 3 for Division \n Enter 4 for Multiplication");

            //int choice = int.Parse(Console.ReadLine());
            //int result = 0;

            //MathOperation mathOperation = new();

            //if (choice == 1)
            //{
            //   result = mathOperation.Sumoftwo(num1, num2);

            //}
            //else if (choice == 2)
            //{
            //    result = mathOperation.Subtoftwo(num1, num2);
            //}
            //else if (choice == 3)
            //{
            //    result = mathOperation.Divoftwo(num1, num2);
            //}
            //else if (choice == 4)
            //{
            //    result = mathOperation.Multoftwo(num1, num2);
            //}

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine($"Result {num1} and {num2} is {result}");

            if (num2 < num1)
            {
                Console.WriteLine("Please ensure num2 is greater than num1");
                Console.ReadLine();
                return;
            }
            else
            {

                Console.WriteLine("Please specify what operation you want to perform. \n  Enter 1 for Sum of Even Integers Between Range of Numbers \n Enter 2 for Sum of Odd Integers between range of numbers");

                int choice = int.Parse(Console.ReadLine());
                int result = 0;

                SumOfNumbers sumOf = new(num1, num2);

                if (choice == 1)
                {
                    result = sumOf.SumOfEvenNumbers();

                }
                else if (choice == 2)
                {
                    result = sumOf.SumOfOddNumbers();
                }


                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"Result {num1} and {num2} is {result}");



                Console.WriteLine("What is the Capital of Nigeria?");
                string answer = Console.ReadLine();

                int countCorrect = 0;

                if (answer.ToLower() == "Lagos".ToLower())
                {
                    countCorrect++;
                }

                Console.WriteLine($"Number of correct answers : {countCorrect}");

            }

        }


    }
}
