using System;

namespace Number_guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game starts
            // Game variables
            String appName = "Number Guesser";
            String appVersion = "1.0.0";
            String appAuthor = "Sakthi KC";

            // Change color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("{0} : Version {1} published by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
            Console.WriteLine("\nINSTRUCTION:\n1) Guess a number between 1 to 25 \n2) You're provided with 5 attempts\n");

            // Read user's name
            Console.Write("Pass your name:");
            String userName=Console.ReadLine();
            Console.WriteLine("{0}, lets play the game",userName);

            // Set original number and user number
            // int originalNumber = 10;
            // To generate a random number - The lower bound (1) is inclusive, while the upper bound (25) is exclusive.
            Random random = new Random();
            int originalNumber = random.Next(1, 25);
            Console.WriteLine("\n\nGuess a number between 1 and 25");
            int userNumber = 0;
            
            // Turn count
            int count = 0;
            // Check if matching
            while(userNumber!= originalNumber && count<5)
            {
                String guess = Console.ReadLine();
                if (Char.IsLetter(guess, 0))
                {
                    if (count < 4)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Enter any digit to win the game");
                        Console.ResetColor();
                    }
                    count++;
                }
                else
                {
                    userNumber = Int32.Parse(guess);
                    if (userNumber > 25)
                    {
                        if (count < 4)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Enter between the specified range");
                            Console.ResetColor();
                        }
                        count++;
                    }
                    else if (userNumber != originalNumber)
                    {
                        if (count < 4)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Nope! Try again");
                            Console.ResetColor();
                        }
                        count++;
                    }
                    else
                        break;
                }
            }
            if (count == 5)
            {
                //Failure
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nHey {0}, it's okay. Try again!", userName);
                Console.ResetColor();
                Console.WriteLine("The actual number to be guessed was "+ originalNumber);
            }
            else
            {
                //Sucess
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHey {0}, you made it. Congrats!", userName);
                Console.ResetColor();
            }

            Console.WriteLine("\nThanks for playing!");
            Console.ReadKey();
        }
    }
}
