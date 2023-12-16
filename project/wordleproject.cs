using System;

class WordleGame
{
    // one integer variable.
    static int someInteger;

    // one float variable.
    static float someFloat;

    // one string variable.
    static string someString;

    // one Boolean variable.
    static bool someBoolean;

    // one variable must be an array.
    static string[] wordList = { "apple", "banana", "cherry", "grape", "lemon", "mango", "melon", "peach" };

    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Wordle!");
        Console.WriteLine("Try to guess the five-letter word.");

        // Generate a random word
        string targetWord = GenerateTargetWord();

        // Main loop
        while (true)
        {
            // Get user input
            string userGuess = GetUserGuess();

            // Check if the user guessed the right word
            if (userGuess.ToUpper() == targetWord)
            {
                Console.WriteLine("Congratulations! You guessed the word!");
                break; // Exit the loop if the guess is right
            }
            else
            {
                // Display a hint for an incorrect guess
                DisplayHint(targetWord, userGuess);
            }
        }

        Console.ReadLine(); // Keep the console window open
    }

    // Method 1: GenerateTargetWord
    // This method generates a random target word from a predefined list.
    static string GenerateTargetWord()
    {
        // Generate a random index to select a word from the list
        Random random = new Random();
        int index = random.Next(0, wordList.Length);

        // Convert to uppercase for case-insensitive comparison
        return wordList[index].ToUpper();
    }

    // Method 2: GetUserGuess
    // This method prompts the user to input a guess and validates the input.
    static string GetUserGuess()
    {
        while (true)
        {
            Console.Write("Enter your guess (five letters): ");
            string guess = Console.ReadLine().ToUpper();

            // Validate user input: Check if the guess is five letters and contains only letters
            if (IsValidGuess(guess))
            {
                return guess;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a five-letter word.");
            }
        }
    }

    // Method 3: IsValidGuess
    // This method checks if a string is a valid guess (five letters, only letters).
    static bool IsValidGuess(string guess)
    {
        return guess.Length == 5 && IsAllLetters(guess);
    }

    // Method 4: IsAllLetters
    // This method checks if a string contains only letters.
    static bool IsAllLetters(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
            {
                return false; // Return false if any character is not a letter
            }
        }
        return true; // Return true if all characters are letters
    }

    // Method 5: DisplayHint
    // This method displays a hint for an incorrect guess, showing correct letters in their positions.
    static void DisplayHint(string targetWord, string userGuess)
    {
        Console.WriteLine("Incorrect! Here's a hint:");

        // Compare each character of the target word with the corresponding character of the user's guess
        for (int i = 0; i < targetWord.Length; i++)
        {
            if (userGuess.Length > i && userGuess[i] == targetWord[i])
            {
                Console.Write(targetWord[i]); // Display correct letters in their positions
            }
            else
            {
                Console.Write("_"); // Display underscore for incorrect positions
            }
        }

        Console.WriteLine();
    }
}