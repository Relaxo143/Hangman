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


    public static void MistakePhases()
    {
        switch(mistakeCounter)
            {
            case 1:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(30,3);
                Console.Write("┌");
                Console.SetCursorPosition(30,4);
                Console.Write("│");
                Console.SetCursorPosition(30,5);
                Console.Write("│");
                Console.SetCursorPosition(30,6);
                Console.Write("│");
                Console.SetCursorPosition(30,7);
                Console.Write("│");
                Console.SetCursorPosition(30,8);
                Console.Write("│");
                Console.SetCursorPosition(0, 5 + positionCounter);

            break;

            case 2:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(31,3);
                Console.Write("─");
                Console.SetCursorPosition(32,3);
                Console.Write("─");
                Console.SetCursorPosition(33,3);
                Console.Write("─");
                Console.SetCursorPosition(34,3);
                Console.Write("─");
                Console.SetCursorPosition(35,3);
                Console.Write("┐");
                Console.SetCursorPosition(0, 5 + positionCounter);

            break;

            case 3:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(35,4);
                Console.Write("0");
                Console.SetCursorPosition(0, 5 + positionCounter);
            break;

            case 4:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(35,5);
                Console.Write("│");
                Console.SetCursorPosition(35,6);
                Console.Write("│");
                Console.SetCursorPosition(0, 5 + positionCounter);
            break;

            case 5:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(34,5);
                Console.Write("┌");
                Console.SetCursorPosition(36,5);
                Console.Write("┐");
                Console.SetCursorPosition(0, 5 + positionCounter);
            break;

            }
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


            string existingLetters = Program.used_letters.ToString();

        while (true) // win or lose condition
        {
            MistakePhases();
            if(mistakeCounter == 6)
            {
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.SetCursorPosition(34,6);
              Console.Write("┌");
              Console.SetCursorPosition(36,6);
              Console.Write("┐");
              Console.SetCursorPosition(34,7);
              Console.Write("│");
              Console.SetCursorPosition(36,7);
              Console.Write("│");
              Console.SetCursorPosition(0, 5 + positionCounter);
              Thread.Sleep(2000);
              Console.Clear();
              Console.ForegroundColor = ConsoleColor.DarkRed;
              Console.WriteLine("YOU LOST!!!");
              Thread.Sleep(4000);
              Console.Clear();
              mistakeCounter = 0;
              positionCounter = 0;
              chosenLetter = "";
              break;
            }

             if (Program.letters_word.Length == Program.used_letters.Length + 2)
             { 
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("YOU WON!!!");
                    Thread.Sleep(4000);
                    Console.Clear();
                    mistakeCounter = 0;
                    positionCounter = 0;
                    chosenLetter = "";
                    break;
             }

             Program.stringLength_counter = 0;
             existingLetters = Program.used_letters.ToString();

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


                for (int i = 0; i < Program.letters_word.Length; i++) ////////////////////////
                {
                    if (chosenLetter[0] == Program.letters_word[i])
                    {
                        for (int k = 0; k < existingLetters.Length; k++)
                        {
                            if(chosenLetter[0] != existingLetters[k])
                            {
                                Program.stringLength_counter++;
                            }
                            
                        }
                        if (Program.stringLength_counter == existingLetters.Length) Program.used_letters.Append(chosenLetter);
                    }
                }


            }


        }

    }
}



