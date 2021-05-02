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



            Console.WriteLine("Please specify what operation you want to perform. \n  Enter 1 for Addition \n Enter 2 for Subtraction \n Enter 3 for Division \n Enter 4 for Multiplication");

            int choice = int.Parse(Console.ReadLine());
            int result = 0;
           
            MathOperation mathOperation = new();

            if (choice == 1)
            {
               result = mathOperation.Sumoftwo(num1, num2);

            }
            else if (choice == 2)
            {
                result = mathOperation.Subtoftwo(num1, num2);
            }
            else if (choice == 3)
            {
                result = mathOperation.Divoftwo(num1, num2);
            }
            else if (choice == 4)
            {
                result = mathOperation.Multoftwo(num1, num2);
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Result {num1} and {num2} is {result}");

        }


    }
}
