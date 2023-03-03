﻿namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToList();

            foreach (string word in words) 
            { 
                Console.WriteLine(word);
            }
        }
    }
}