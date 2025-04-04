using System;
using System.Media;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\prime\Desktop\2025\PROG\Part 1 Assignment\Welcome Audio.wav");
            player.Play();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error playing the voice greeting: " + ex.Message);
        }

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n====================================");
        Console.WriteLine("  WELCOME TO SAFENET ");
        Console.WriteLine("====================================");
        Console.ResetColor();

        Console.WriteLine(@"
    ____         __      _   _      _   
/ ___|  __ _ / _| ___| \ | | ___| |_ 
\___ \ / _` | |_ / _ \  \| |/ _ \ __|
 ___) | (_| |  _|  __/ |\  |  __/ |_ 
|____/ \__,_|_|  \___|_| \_|\___|\__|
");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("====================================\n");
        Console.ResetColor();

        // Prompting user for their name
        Console.Write("\nPlease enter your name: ");
        Console.WriteLine("          ");
        string name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Oops! I didn't catch your name, let's try again.");
            Console.ResetColor();

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
        }

        // Creating Text based welcome message to welcome user
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n====================================");
        Console.WriteLine($"Hello, {name}! My name is Mykll - your friendly Cybersecurity chatbot assistant.");
        Console.WriteLine("====================================");
        Console.ResetColor();

        // Prompting user for relative questions
        Console.WriteLine("\nFeel free to ask me any question such as: ");
        Console.WriteLine("- 'How are you doing?'\n- 'What's your purpose?'\n- 'What can I ask you about?'\n'What's is phishing?'\n- 'How can I create a strong password?'\n- 'What is safe browsing?'\n");
        Console.WriteLine("type 'exit' to end the conversation");

        Console.WriteLine("What would you like to ask?");
        string query = Console.ReadLine().ToLower();

        // Creating loop for user to ask multiple questions until they end conversation
        while (query != "exit")
        {
            // Creating Basic Response System
            if (query.Contains("purpose"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nI'm glad you asked! My purpose is to help you understand the dangers of cyber threats and how to avoid them.");
                Console.ResetColor();
            }
            else if (query.Contains("doing"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nI'm doing great! And looking forward to helping you.");
                Console.ResetColor();
            }
            else if (query.Contains("ask"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nYou can ask me about phishing, password safety, and browsing. And soon you can ask me about other topics related to cybersecurity!");
                Console.ResetColor();
            }
            else if (query.Contains("phishing"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPhishing is a cyberattack where criminals attempt to steal sensitive information, like passwords, credit card numbers, or personal data, often through fake emails or websites.");
                Console.ResetColor();
            }
            else if (query.Contains("password"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nFor password safety, make sure to include uppercase and lowercase letters, numbers, and special characters to create a strong reliable password.");
                Console.ResetColor();
            }
            else if (query.Contains("safe browsing"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nSafe browsing involves taking steps to protect yourself while using the internet, such as avoiding suspicious links and not downloading files from untrusted sources.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nI'm sorry I didn't quite get that. Could you please try again?");
                Console.ResetColor();
            }

            Console.WriteLine("\nWhat else would you like to ask me? Type 'exit' to end the conversation.");
            query = Console.ReadLine().ToLower();
        }

        // Ending program
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nConversation has ended. Thank you for your time!");
        Console.ResetColor();
    }
}
