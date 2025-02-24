using Algoritms.String;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nHello, this contains the details of algorithms, please choose from the menu:");

            StringBuilder menuBuilder = new();
            menuBuilder.AppendLine("[1] - String");
            menuBuilder.AppendLine("[2] - Sort");
            menuBuilder.AppendLine("[3] - Search");
            menuBuilder.AppendLine("[4] - Graph");
            menuBuilder.AppendLine("[5] - Bit");
            menuBuilder.AppendLine("[6] - Recursion");
            menuBuilder.AppendLine("[7] - Game");
            menuBuilder.AppendLine("[8] - Array + List");
            menuBuilder.AppendLine("[9] - Tree + Queue + Heap");
            menuBuilder.AppendLine("[Q] - Quit");

            Console.WriteLine(menuBuilder);

            Console.Write("Enter your choice: ");
            string? menuChoice = Console.ReadLine()?.Trim();

            if (string.Equals(menuChoice, "Q", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Exiting the application. Goodbye!");
                break;
            }

            string result = menuChoice switch
            {
                "1" => HandleStringAlgorithms(),
                "2" => "[Sorting Algorithms Menu]",
                "3" => "[Search Algorithms Menu]",
                "4" => "[Graph Algorithms Menu]",
                "5" => "[Bit Manipulation Algorithms Menu]",
                "6" => "[Recursion Algorithms Menu]",
                "7" => "[Game Algorithms Menu]",
                "8" => "[Array & List Algorithms Menu]",
                "9" => "[Tree, Queue & Heap Algorithms Menu]",
                _ => "Invalid choice. Please select a valid option."
            };

            Console.WriteLine(result);
        }
    }

    static string HandleStringAlgorithms()
    {
        Console.WriteLine("\nString Algorithms Menu:");
        StringBuilder sb = new();
        sb.AppendLine("[1] - Camel Case");
        sb.AppendLine("[2] - Anagram Check");
        sb.AppendLine("[3] - Palindrome Check");
        sb.AppendLine("[B] - Back to Main Menu");
        Console.WriteLine(sb);

        Console.Write("Enter your choice: ");
        string? choice = Console.ReadLine()?.Trim();

        Console.Write("Enter your input: ");
        string? input = Console.ReadLine()?.Trim();

        return choice switch
        {
            "1" => CamelCase.InvokeFunction(input!),
            "2" => Pangram.InvokeFunction(input!),
            "3" => "Executing Palindrome Check...",
            "B" or "b" => "Returning to Main Menu...",
            _ => "Invalid choice. Please select a valid option."
        };
    }


}
