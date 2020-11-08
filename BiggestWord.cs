using System;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\Jacob\Desktop\words_alpha.txt
            //Ask for location of the file
            Console.WriteLine("Location of text file you want to be read");
            string filename = Console.ReadLine();
            string[] words = System.IO.File.ReadAllLines(@filename);
            string biggestWord = "";
            foreach (string word in words)
            {
                if(word.Length >= biggestWord.Length)
                {
                    biggestWord = word;
                }
            }
            Console.WriteLine(biggestWord);
        }
    }
}
