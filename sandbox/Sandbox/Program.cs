using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        List<int> numbers = new List<int>();
        List<string> words = new List<string>();
        
        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        foreach (string word in words)
        {
            Console.WriteLine(word);  
        }

        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }

        
        Console.WriteLine(words.Count);

    }
}