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
                    Console.WriteLine(chosenWord[i]);
                }

                letterCount = chosenWord.Length;
                UI.DrawUI();
            }
            else
            {
                wordsBG = BG.wordList.Split(' ');
                int randChoice = GetRandomNumber(0, GetArrayLenght());
                string chosenWord = wordsBG[randChoice];

                for (int i = 0; i < chosenWord.Length; i++)
                {
                    Console.WriteLine(chosenWord[i]);
                }

                letterCount = chosenWord.Length;
                UI.DrawUI();
            }
        }
    }
}



