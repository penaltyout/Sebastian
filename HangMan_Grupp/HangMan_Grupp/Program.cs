using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Grupp
{
    class Program
    {

        static string yourName;
        static int totalGuesses;
        static string difficultyLevel;
        static string word;


        static void Main(string[] args)
        {
            Console.WriteLine("****** Welcome to the ever so delightful game, Hangman! ******");
            //Lägg in flera metoder, win game, lose game
            //lägg in "playa again Y/N och gå tillbaka till svårighetsgrad"
            //Fler val i meny? diskutera
            //Flytta metoder från Main? diskutera, för och nackdelar)
            //gör en switchsats för att spela igen.
            HangmanStart();
            Console.ReadLine();
        }

        private static void EnterYourName()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter your name to start");
                yourName = Console.ReadLine();
                Console.WriteLine("Welcome " + yourName + " good luck!");
                Console.WriteLine();
            } while (yourName.Length <= 3);
        }

        static void HangmanStart()
        {
            Console.WriteLine("Would you like to try it? Y/N");
            string yesOrNo = Console.ReadLine();

            switch (yesOrNo.ToUpper())
            {
                case "Y":
                    EnterYourName();                                    //Här hämtas namnet
                    DifficultyLevel();                                  //Här hämtas svårighetsnivån
                    GameEngine();                                       //Här startar vi spelet
                    break;
                case "N":
                    Console.WriteLine("Chicken shit!");
                    break;
                default:
                    Console.WriteLine("Please choose a valid letter.");
                    Console.WriteLine();
                    HangmanStart();
                    break;
            }
        }

        static void GenerateWords()
        {

            //For later

        }

        static void GameEngine()
        {
            bool isInputWord = true;

            while (isInputWord)
            {
                Console.WriteLine("Please guess the right word.");
                string wordToGuess = Console.ReadLine();

                if (wordToGuess == word)
                {
                    Console.WriteLine(yourName + " your guess was correct, the word is" + " " + wordToGuess + "!");
                    isInputWord = false;
                }
                else
                {
                    Console.WriteLine(wordToGuess + " was incorrect. Please try again");
                    totalGuesses--;
                    Console.WriteLine("Du har " + totalGuesses + " kvar");
                    Console.WriteLine();
                }
            }
        }

        static void WinLoseText()
        {


        }

        static void HangedManGraphic()
        {

        }

        static void DifficultyLevel()
        {
            Console.WriteLine("Choose level of difficulty");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Normal");
            Console.WriteLine("3. Hard");

            difficultyLevel = Console.ReadLine();
            switch (difficultyLevel)
            {
                case "1":
                    Console.WriteLine("Du har valt Svårighetsgrad 1");
                    word = "Hello";
                    totalGuesses = 15;
                    break;
                case "2":
                    Console.WriteLine("Du har valt Svårighetsgrad 2");
                    word = "Nationalencyklopedin";
                    totalGuesses = 10;
                    break;

                case "3":
                    Console.WriteLine("Du har valt Svårighetsgrad 2");
                    word = "abcdefghijklmnopqrstuvxyzåäö";
                    totalGuesses = 5;
                    break;

                default:
                    Console.WriteLine("Please choose a valid number.");
                    Console.WriteLine();
                    DifficultyLevel();
                    break;
            }
        }

        static void StoryLine()
        {

        }


    }

}
