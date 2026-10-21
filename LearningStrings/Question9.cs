//using System;
//using System.Collections.Generic;
//using System.Text;
////Find the frequency of each character
//namespace LearningStrings
//{
//    internal class Question9
//    {
//        static void Main()
//        {
//            string? str;
//            Console.WriteLine("Enter a sentence:");
//            str = Console.ReadLine();
//            Dictionary<char, int> charCount = new Dictionary<char, int>();
//            foreach (char c in str)
//            {
//                if (charCount.ContainsKey(c))
//                {
//                    charCount[c]++;
//                }
//                else
//                {
//                    charCount[c] = 1;
//                }
//            }
//            Console.WriteLine("The frequency of each character in the sentence is:");
//            foreach (var item in charCount)
//            {
//                Console.WriteLine(item.Key + " - " + item.Value);
//            }
//        }
//    }
//}
