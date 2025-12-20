using System.Xml.XPath;

internal class Program
{
    private static void Main(string[] args)
    {
        string correctWord = "Gaucho";
        string guessWord = "";

        int maxAttempts = 6;
        int attempts = 0;

        while (guessWord != correctWord && attempts < maxAttempts)
        {
            int remainAttempts = maxAttempts - attempts - 1; // Adjust remaining attempts
            System.Console.WriteLine("Guess the word");
            guessWord = Console.ReadLine() ?? string.Empty;
            System.Console.WriteLine($"Attempt Remain: {remainAttempts}");
            attempts++;
        }

        if (guessWord == correctWord)
        {
            System.Console.WriteLine($"Congratulations! You've guessed the correct word with {maxAttempts - attempts} attempts remaining.");
        }
        else
        {
            System.Console.WriteLine($"Sorry, you've used all attempts. The correct word was: {correctWord}");
        }
    }
}
    


    


    


