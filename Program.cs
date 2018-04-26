using System;



namespace Lab3_DecisionTree

{

    class Program

    {

        static void Main(string[] args)

        {


            while (true)

            {
                Console.WriteLine("Enter a number between 1 and 100:");
                string input = Console.ReadLine();
                int num1 = int.Parse(input);

                if (num1 % 2 == 1)
                {
                    Console.WriteLine(num1 + " and Odd");
                }

                else if (num1 <= 25)
                {
                    Console.WriteLine(num1 + " Even and less than 25");
                }

                else if (num1 <= 60)
                {
                    Console.WriteLine(num1 + " Even");
                }

                else if (num1 <= 100)
                {
                    Console.WriteLine(num1 + " Even");
                }

                Console.WriteLine("Continue? (Y/N)");
                string playAgain = Console.ReadLine();

                if (playAgain.ToLower() != "y")
                {
                    Console.WriteLine("Good Bye!");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
