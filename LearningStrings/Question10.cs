using System;
using System.Collections.Generic;
using System.Text;
// Convert the first letter of every word to uppercase
namespace LearningStrings
{
    internal class Question10
    {
        static void Main()
        {
            string? str;
            Console.WriteLine("Enter a sentence:");
            str = Console.ReadLine();
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            string result = string.Join(" ", words);
            Console.WriteLine("The sentence with the first letter of every word in uppercase is: " + result);
        }
    }
}
