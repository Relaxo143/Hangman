using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hangman
{
    class Program
    {
        public static Random rand = new Random();

        public static bool isBG = false;
        public static char firstLetter, lastLetter;
        public static string[] wordsEN;
        public static string[] wordsBG;
        public static int letterCount = 0;
        public static string chosenWord;



        static int GetArrayLenght()
        {
            int counter = 0;

            if (isBG)
            {
                foreach (string word in wordsBG)
                {
                    counter++;
                }
            }
            else
            {
                foreach (string word in wordsEN)
                {
                    counter++;
                }
            }
            return counter;
        }

        static int GetRandomNumber(int min, int max)
        {
            Thread.Sleep(rand.Next(1, 250));

            int cycles = rand.Next(40000, 45889);
            int finalNumber = 0;

            for (int i = 0; i < rand.Next(1, cycles); i++)
            {
                if (rand.Next(1, 5000) <= 2500)
                {
                    finalNumber = rand.Next(min, max);
                }
            }
            return finalNumber; // work to do; make the numbers more random
        }

        static void Main()
        {
            int letterCount = 0;

            if (!Program.isBG)
            {
                wordsEN = EN.wordList.Split(' ');
                int randChoice = GetRandomNumber(0, GetArrayLenght());
                 string chosenWord = wordsEN[randChoice];

                for (int i = 0; i < chosenWord.Length; i++)
                {
                   ////////////////////////
                }

                letterCount = chosenWord.Length;
                UI.DrawUI();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Enter a letter to guess the word!");
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (i == 0)
                    {
                        firstLetter = chosenWord[i];
                    }
                    if (i == chosenWord.Length - 1)
                    {
                        lastLetter = chosenWord[i];
                    }
                }
                for (int l = 0; l < chosenWord.Length; l++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    if (l == 0)
                    {
                        
                        Console.WriteLine();
                        Console.WriteLine(chosenWord[l]);

                    }
                   if(chosenWord[l] == firstLetter || chosenWord[l] == lastLetter)
                    {
                        if(l != 0 && l != chosenWord.Length)
                        {
                            Console.SetCursorPosition((l * 2) , 2);
                            Console.WriteLine(chosenWord[l]);
                        }

                    }
                    if (l == chosenWord.Length)
                    {
                       Console.SetCursorPosition((chosenWord.Length * 2) - 2, 2);
                       Console.WriteLine();
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition((l * 2) , 3);
                        Console.WriteLine("_");

                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

            }
            else
            {
                wordsBG = BG.wordList.Split(' ');
                int randChoice = GetRandomNumber(0, GetArrayLenght());
                string chosenWord = wordsBG[randChoice];

                for (int i = 0; i < chosenWord.Length; i++)
                {
                  //////////////////////// 
                }

                letterCount = chosenWord.Length;
                UI.DrawUI();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Enter a letter to guess the word!");
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (i == 0)
                    {
                        firstLetter = chosenWord[i];
                    }
                    if (i == chosenWord.Length - 1)
                    {
                        lastLetter = chosenWord[i];
                    }
                    Console.WriteLine(chosenWord[i]);
                }
                for (int l = 0; l < chosenWord.Length; l++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    if (l == 0)
                    {
                        
                        Console.WriteLine();
                        Console.WriteLine(chosenWord[l]);

                    }
                    if (chosenWord[l] == firstLetter || chosenWord[l] == lastLetter)
                    {
                        if (l != 0 && l != chosenWord.Length)
                        {
                            Console.SetCursorPosition((l * 2), 2);
                            Console.WriteLine(chosenWord[l]);
                        }

                    }
                    if (l == chosenWord.Length)
                    {
                        Console.SetCursorPosition((chosenWord.Length * 2) - 2, 2);
                        Console.WriteLine();
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition((l * 2), 3);
                    Console.WriteLine("_");

                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

            }
        }
    }
}


