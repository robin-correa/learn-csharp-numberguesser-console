class Program
{
    static void Main(string[] args)
    {
        GetAppInfo(); // Call GetAppInfo function
        GreetUser(); // Ask user's name and greet

        // While user wants to play again
        while (true)
        {

            // Create a new Random object
            var random = new Random();

            // Init correct number
            int correctNumber = random.Next(1, 10);

            // Init guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while (guess != correctNumber)
            {
                // Get user input
                string? input = Console.ReadLine();

                // Make sure it is a number
                if (!int.TryParse(input, out guess))
                {
                    // Print error message
                    PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                    // Keep going
                    continue;
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number

                if (guess != correctNumber)
                {
                    PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    continue;
                }
            }

            PrintColorMessage(ConsoleColor.Green, "Correct. You guessed it.");

            // Ask to play again
            Console.WriteLine("Play Again? [Y or N]");

            // Get answer
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                continue;
            }

            // Exit the application
            return;
        }
    }

    static void GetAppInfo()
    {
        // Set app vars
        string appName = "Number Guesser";
        string appVersion = "1.0.0";
        string appAuthor = "Robin Correa";

        // Change text color
        Console.ForegroundColor = ConsoleColor.Green;

        // Write out app info
        Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

        // Reset text color
        Console.ResetColor();
    }

    static void GreetUser()
    {
        // Ask user name
        Console.WriteLine("What is your name?");

        // Get user input
        string? name = Console.ReadLine();

        Console.WriteLine("Hello {0}, let's play a game.", name);
    }

    static void PrintColorMessage(ConsoleColor color, string message)
    {
        // Change text color
        Console.ForegroundColor = color;

        // Tell user it's not a number
        Console.WriteLine(message);

        // Reset text color
        Console.ResetColor();
    }
}