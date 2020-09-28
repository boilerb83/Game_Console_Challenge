using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiger;

namespace Game
{
    public class ProgramUI
    {
        public void Run()
        {
            RunMenu();
        }

        public void RunMenu()
        {
            Animal animal = new Animal();
            
            /*********************  DECLARATION OF VARIABLES ***********************/
            //int time_delay = 50;        //TIME DELAY FOR CONSOLE SCREEN
            //int hint_count = 0;         //HINT COUNT TO DISPLAY NEXT HINT AND INCREASE BY ONE also checks if hint count = last hint and wrong then end game

            /******************************  VULNERABLE OR NOT VULNERABLE FOR POINTS **************/
            bool guessedAnimal = false; 

            /**********************  Formatting background *****************/
            Console.BackgroundColor = ConsoleColor.Black;    // Change the background color
            Console.ForegroundColor = ConsoleColor.Green;    // Change the text color 

            /***********************  INITIAL DISPLAY  *****************/
            Console.WriteLine("WELCOME TO THE ANIMAL GUESSING GAME::\n" +       ////////   START BACK HERE AFTER LUNCH HERE /////////
                    "1) ENTER A 1 TO PLAY THE GAME \n" +
                    "2) ANY OTHER KEY TO EXIT GAME");
            Console.WriteLine("______________________________________________________");

            string userInput = Console.ReadLine();
            string animalInput;
            //Tiger = new Tiger();     ///    ///

            Console.Clear();


            /*************************** GAME LOGIC HERE *********************/

            int hint_count = 0;
            while (userInput == "1" && guessedAnimal == false)      //play game and user has not selected tiger
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("GUESS THE ANIMAL THAT LIVES IN THE JUNGLE! \n");      //Game over as the score reached 0 lives
                Console.ForegroundColor = ConsoleColor.Blue;
                animalInput = Console.ReadLine().ToLower();

                //hint_count++;
                if (hint_count <= 7 && animalInput != "tiger")           //might need to change hint count here 
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    switch (hint_count)
                    {
                        case (0):
                            Console.WriteLine(animal.listOfHints[hint_count]);
                            break;
                        case (1):
                            Console.WriteLine(animal.listOfHints[hint_count] + "\n");
                            break;
                        case (3):
                            Console.WriteLine("He has a long tail. \n");
                            break;
                        case (4):
                            Console.WriteLine("He has orange fur. \n");
                            break;
                        case (5):
                            Console.WriteLine("He has dark vertical stripes. \n");
                            break;
                        case (6):
                            Console.WriteLine("He can run >35 mph. \n");
                            break;
                        case (7):
                            Console.WriteLine("His fur gives high camouflage that is orange and black. \n");
                            break;
                        default:
                            break;
                    }
                hint_count++;
                }
                else if (animalInput != "tiger")
                {
                    guessedAnimal = true;
                    Console.ForegroundColor = ConsoleColor.Red;    // Change the text color to white
                    Console.WriteLine("YOU DID NOT GUESS WITHIN THE GIVEN AMOUNT OF TRIES.");
                }
                else
                {
                    guessedAnimal = true;
                    Console.ForegroundColor = ConsoleColor.Yellow;    // Change the text color to white
                    Console.WriteLine($"YOU GUESSED THE CORRECT ANIMAL A TIGER!!!");
                }
            }

            Console.WriteLine("EXITING NOW!");
            Console.ForegroundColor = ConsoleColor.Gray;    // Change the text color to white
            Console.ReadLine();
        }
    }
}
