using System;
using Hangman;
using System.Threading;

public class UI
{
    public static int mistakeCounter = 0;
    public static int positionCounter = 0;
    public static string chosenLetter;
    public static void ShowInitMessages()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" Hangman v1.0 by Kalin Lalov and Miro Karagyozov");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(" Do you want to play with Bulgarian or English words? Please type 'bg' or 'en':");
        Console.ForegroundColor = ConsoleColor.Cyan;
    }


    public static void DrawUI()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Enter a letter to guess the word! " + Program.chosenWord);
        
        for (int l = 0; l < Program.chosenWord.Length; l++)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (l == 0)
            {

                Console.WriteLine();
                Console.WriteLine(" " + Program.chosenWord[l]);

            }
            if (Program.chosenWord[l] == Program.firstLetter || Program.chosenWord[l] == Program.lastLetter)
            {
                if (l != 0 && l != Program.chosenWord.Length)
                {
                    Console.SetCursorPosition((l * 2), 2);
                    Console.WriteLine(" " + Program.chosenWord[l]);
                }

            }
            if (l == Program.chosenWord.Length)
            {
                Console.SetCursorPosition((Program.chosenWord.Length * 2) - 2, 2);
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition((l * 2), 3);
            Console.WriteLine(" _");

        }
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine();

        while (true) // win or lose condition
        {

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            positionCounter++;
           
                chosenLetter = Console.ReadLine().ToLower();


                while (chosenLetter.Length > 1)
                {
                    Console.SetCursorPosition(0, 5 + positionCounter - 1);
                    for (int i = 1; i < chosenLetter.Length + 1; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.SetCursorPosition(0, 5 + positionCounter - 1);
                    chosenLetter = Console.ReadLine().ToLower();

                }

            while (Program.CheckForDuplicates())
            {             

                Console.SetCursorPosition(0, 5 + positionCounter - 1);
                 for (int i = 1; i < chosenLetter.Length + 1; i++)
                 {
                     Console.Write(" ");
                 }
                 Console.SetCursorPosition(0, 5 + positionCounter - 1);

                chosenLetter = Console.ReadLine().ToLower();               
            }

                if (chosenLetter.Length == 1)
            {

                for (int i = 0; i < Program.chosenWord.Length; i++)
                {
                    if (chosenLetter[0] == Program.chosenWord[i])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition((i * 2) + 1, 2);
                        Console.WriteLine(Program.chosenWord[i]);
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.SetCursorPosition(0, 4 + positionCounter);
                        Console.WriteLine(chosenLetter);
                    }


                }

                if (Program.chosenWord.Contains(chosenLetter) == false)
                {

                    mistakeCounter++;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(0, 4 + positionCounter);
                    Console.WriteLine(chosenLetter);
                }
            }


        }

    }
}



