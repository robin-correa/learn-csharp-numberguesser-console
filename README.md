# Learning C#: Number Guesser

## 1. Display AppInfo

```cs
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
```

## 2. Asks User's name

```cs
    static void GreetUser()
    {
        // Ask user name
        Console.WriteLine("What is your name?");

        // Get user input
        string? name = Console.ReadLine();

        Console.WriteLine("Hello {0}, let's play a game.", name);
    }
```

## 3. Generate Random number from 1 - 10

```cs
    // Create a new Random object
    var random = new Random();

    // Init correct number
    int correctNumber = random.Next(1, 10);
```

## 4. Get User's input

```cs
    // Get user input
    string? input = Console.ReadLine();
```

## 5. Compare User's input vs Generated Random number

```cs
    if (guess != correctNumber)
    {
        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
        continue;
    }
```

## 6. Display result if correct (Play again?) or wrong (Try again?)

```cs
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
```
