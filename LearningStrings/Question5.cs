//using System;
//using System.Collections.Generic;
//using System.Text;
////Find duplicate characters
//namespace LearningStrings
//{
//    internal class Question5
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
//            Console.WriteLine("The duplicate characters in the sentence are:");
//            foreach (var item in charCount)
//            {
//                if (item.Value > 1)
//                {
//                    Console.WriteLine(item.Key + " - " + item.Value);
//                }
//            }
//        }
//    }
//}
