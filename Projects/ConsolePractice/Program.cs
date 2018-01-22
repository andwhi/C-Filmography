using System;

namespace ConsolePractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MainClass averager = new MainClass();
            MainClass quiz = new MainClass();

            averager.Averager();
            quiz.Quiz();

        }

        void Averager()
        {
            string number;
            double total = 0;
            int numbers = 0;

            Console.WriteLine("Enter a number. Press d when done.");

            while ((number = Console.ReadLine().ToLower()) != "d")
            {
                total += double.Parse(number);
                numbers++;
            }

            Console.WriteLine("The average of the numbers is {0}", total / numbers);
        }

        void Quiz()
        {
            Console.WriteLine("What is the capital of the U.S.?");
            Console.WriteLine("1 - D.C.");
            Console.WriteLine("2 - NYC");
            Console.WriteLine();

            string answer;
            int score = 0;
            int wrong = 0;

            while ((answer = Console.ReadLine()) != "")
            {

                if (int.Parse(answer) == 1)
                {
                    score += 1;

                }
                else if (int.Parse(answer) == 2)
                {
                    wrong += 1;
                }

                Console.WriteLine("Press enter to continue.");
            }
            Console.WriteLine("Donald Trump is the 45th President.");
            Console.WriteLine("1 - True.");
            Console.WriteLine("2 - False");
            Console.WriteLine();

            while ((answer = Console.ReadLine()) != "")
            {
                if (int.Parse(answer) == 1)
                {
                    score += 1;

                }
                else if (int.Parse(answer) == 2)
                {
                    wrong += 1;
                }

                Console.WriteLine("Press enter to continue.");
            }


            Console.WriteLine("Which language is associated with Microsoft?");
            Console.WriteLine("1 - Java");
            Console.WriteLine("2 - C#");
            Console.WriteLine();


            while ((answer = Console.ReadLine()) != "")
            {
                if (int.Parse(answer) == 1)
                {
                    wrong += 1;

                }
                else if (int.Parse(answer) == 2)
                {
                    score += 1;
                }

                Console.WriteLine("Press enter to continue.");
            }

            Console.WriteLine("Press enter to see your results.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Correct: {0}", score);
            Console.WriteLine("Incorrect: {0}", wrong);





        }
    }
}
