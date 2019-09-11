using System;

namespace Week3Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years do you have in professional programming?");

            try
            {
                String practiceYears = Console.ReadLine(); ;

                int inputYears = int.Parse(practiceYears);

                if (inputYears == 0)
                {
                    Console.WriteLine("You need a lot of practice.");
                }
                else if (inputYears == 1)
                {
                    Console.WriteLine("Looks like you have a little experience.");
                }
                else if (inputYears == 2)
                {
                    Console.WriteLine("Wow! You've been doing this for a little while.");
                }
                else 
                 {
                    Console.WriteLine("Youre an Expert!");
                }
            }
            catch
            {
                Console.WriteLine("You didnt input any years!");
            }
        }
    }
}
