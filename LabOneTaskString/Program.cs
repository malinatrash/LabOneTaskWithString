using System;
using System.Collections.Generic;

namespace LabOneTaskString
{
    public class Logic
    {
        public static string Reverse(string sentense)
        {   
            string[] wordsOfSentense = sentense.Split(' ');
            Array.Reverse(wordsOfSentense);

            string reversedSentense = "";

            foreach (var word in wordsOfSentense)
            {
                reversedSentense += word + " ";
            }
            return (reversedSentense);
        }
    }
    class Programm
    {
        static void Main()
        {
            Console.WriteLine("Please enter a sentense: ");
            var sentense = Console.ReadLine();

            var reversedSentense = Logic.Reverse(sentense);

            Console.WriteLine(reversedSentense);
            Console.ReadKey();
        }
    }
}
