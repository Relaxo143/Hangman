using System;
using Hangman;
using System.Threading;

public class UI
{
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
        Console.WriteLine("Enter a letter to guess the word!");
        for (int i = 0; i < Program.chosenWord.Length; i++)
        {
            if (i == 0)
            {
                Program.firstLetter = Program.chosenWord[i];
            }
            if (i == Program.chosenWord.Length - 1)
            {
                Program.lastLetter = Program.chosenWord[i];
            }
        }
        for (int l = 0; l < Program.chosenWord.Length; l++)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
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
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

    }
}
