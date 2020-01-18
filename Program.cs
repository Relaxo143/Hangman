using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace Hangman
{
    class Program
    {
		public static string versionNumber = "v1.1";

		public static string userName;

        public static Random rand = new Random();
        static SoundPlayer DJ = new SoundPlayer(Hangman.Properties.Resources.thefatrat_origin);
		public static bool isMusicPlaying; 
     //   static Thread MusicPlayer = new Thread(PlayMusic);
		static Thread NumChecker = new Thread(ToggleMusicPlayback);


        public static bool isBG = false;
		public static bool numState;
        public static char firstLetter, lastLetter;
        public static string[] wordsEN;
        public static string[] wordsBG;
        public static string chosenWord = "";
        public static string languageChoice = "";
        public static int letterCount = 0;
        public static StringBuilder used_letters = new StringBuilder(); 
        public static StringBuilder letters_word = new StringBuilder(); 
        public static int stringLength_counter = 0; 
        public static StringBuilder usedLetters = new StringBuilder();
		public static int bestStreak = 0;
		public static int sessionStreak = 0;
 

		static void ToggleMusicPlayback()
		{
			while (true)
			{
			                                                                                
				if (Console.NumberLock != numState)
				{
					if (isMusicPlaying)
					{
						DJ.Stop();
						isMusicPlaying = false;
						numState = !numState;
					}
					else
					{
						DJ.PlayLooping();
						isMusicPlaying = true;
						numState = !numState;
					}
					Thread.Sleep(100);
				}
			  }
			}

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

           
        public static bool CheckForDuplicates()
        {
            if (usedLetters.ToString().Contains(UI.chosenLetter[0])) return true;

            if (!usedLetters.ToString().Contains(UI.chosenLetter[0])) usedLetters.Append(UI.chosenLetter);

            return false;               
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
            return finalNumber;
        }

        static void Main()
        {
		    userName = Environment.UserName;
			numState = Console.NumberLock;
			Console.Title = "Hangman " + versionNumber;
			Disk.SetupDataDir();
			bestStreak = Disk.LoadStreak();
			MusicChoice musicChoice = new MusicChoice();
			musicChoice.musicCheckBox.Checked = true;
			musicChoice.ShowDialog();
			if (MusicChoice.isMusicWanted)
			{
				DJ.PlayLooping();
				isMusicPlaying = true;
			}
			else isMusicPlaying = false;
			NumChecker.Start();


            A:

          isBG = false;
          chosenWord = "";
          languageChoice = "";
          used_letters.Clear(); 
          letters_word.Clear(); 
          stringLength_counter = 0;                     
          usedLetters.Clear();
          
          // static int index = 2;

			int letterCount = 0;
            int randChoice;
         
            do
            {
                Console.Clear();
                UI.ShowInitMessages();
                languageChoice = Console.ReadLine();
                Console.Clear();
                UI.ShowInitMessages();
            }
            while (languageChoice != "bg" && languageChoice != "BG" && languageChoice != "en" && languageChoice != "EN");


            if (languageChoice == "bg" || languageChoice == "BG") isBG = true;
            else isBG = false;

            if (Program.isBG)
            {
                wordsBG = BG.wordList.Split(' ');
                randChoice = GetRandomNumber(0, GetArrayLenght());
                chosenWord = wordsBG[randChoice];

                for (int i = 1072; i < 1104; i++)
                {
                   
                   if (Program.chosenWord.Contains((char)i))
                   { 
                      Program.letters_word.Append((char)i);
                   }
                }
            }
            else
            {
                wordsEN = EN.wordList.Split(' ');
                randChoice = GetRandomNumber(0, GetArrayLenght());
                chosenWord = wordsEN[randChoice];

                for (int i = 97; i < 123; i++)
                {
                   if (Program.chosenWord.Contains((char)i))
                   { 
                      Program.letters_word.Append((char)i);
                   }
                }
            }



            for (int i = 0; i < chosenWord.Length; i++)
            {
                //////////////////////// //debug
            }

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
            usedLetters.Append(firstLetter);
            usedLetters.Append(lastLetter);
            letterCount = chosenWord.Length;

            UI.DrawUI();
            goto A;
        }
    }
}

