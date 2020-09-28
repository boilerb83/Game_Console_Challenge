using Game;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Game_Challenge
{
    public class Game
    {

        static void Main(string[] args)
        {

        /*********************  DECLARATION OF VARIABLES ***********************/
            int time_delay = 50;  
            int total_lives_left = 3;     
            int vulnerable_multiplier = 1;    
            int birdvalue = 1;    
            int score = 5000;     

            string filePath = @"C:\ElevenFiftyProjects\GoldBadge\Challenge\Assets\game-sequence.txt";    //text document location @ can be used to read the direct file path
            
            /*******************************   SCORING SYSTEM *************************/
            int bird = 10;   
            int crested_Ibis = 100;  
            int greatKiskudee = 300;           
            int redCrossbill = 500;
            int redneckedPhalarope = 700;             
            int eveningGrosbreak = 1000;       
            int greaterPrairieChicken = 2000;
            int icelandgull = 3000;                   
            int Orange_BelliedParrot = 5000;   
            int vulnerable_bird = 200;    
            int vulnerable_bird_succession = 1;
            
            string recentbirdtype = "none";           
            string currentbirdtype = "none";
            
            /******************************  VULNERABLE OR NOT VULNERABLE FOR POINTS **************/
            bool vulnerableBirdHunters = true;  bool invincibleBirdHunter = false;   bool bonusgiven = false;
            
            /**********************  Formatting background *****************/
            Console.BackgroundColor = ConsoleColor.Black;    // Change the background color
            Console.ForegroundColor = ConsoleColor.Green;    // Change the text color 
            
            /***********************  READING AND PARSING TEXT FILE/ INITIAL DISPLAY  *****************/
            List<Phrase> phrases = new List<Phrase>();
            List<string> lines = File.ReadAllLines(filePath).ToList();
            Console.WriteLine("Event           Value          Total Score       Lives");
            Console.WriteLine("______________________________________________________");

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                foreach (var entry in entries)
                {
                    currentbirdtype = entry;  
                    Console.ForegroundColor = ConsoleColor.Green;    // Set the Console.Foreground Color back to green if it is changed
                    /*************************** GAME LOGIC HERE *********************/
                    if (total_lives_left > 0)
                    {
                        if (entry == "Bird") { birdvalue = bird; }
                        else if (entry == "CrestedIbis") { birdvalue = crested_Ibis; }
                        else if (entry == "EveningGrosbeak") { birdvalue = eveningGrosbreak; }
                        else if (entry == "GreaterPrairieChicken") { birdvalue = greaterPrairieChicken; }
                        else if (entry == "VulnerableBirdHunter")
                        {
                            if (recentbirdtype == "VulnerableBirdHunter")
                            {
                                vulnerable_bird_succession ++;   //increase succession count by 1
                                if (vulnerable_bird_succession == 2)
                                {
                                    birdvalue = vulnerable_bird * vulnerable_bird_succession;   //should be 400
                                }
                                else if (vulnerable_bird_succession == 3)
                                {
                                    birdvalue = vulnerable_bird * 4;  //should be 800
                                }
                                else if (vulnerable_bird_succession == 4)
                                {
                                    birdvalue = vulnerable_bird * 8;        //should be 1600
                                }
                                else
                                { birdvalue = vulnerable_bird; }
                            }
                            else
                            {
                                birdvalue = vulnerable_bird;        //keep original 200 value
                            }
                        }
                        else if (entry == "IcelandGull") { birdvalue = icelandgull; }
                        else if (entry == "GreatKiskudee") { birdvalue = greatKiskudee; }
                        else if (entry == "Orange-belliedParrot") { birdvalue = Orange_BelliedParrot; }
                        else if (entry == "Red-neckedPhalarope") { birdvalue = redneckedPhalarope; }
                        else if (entry == "RedCrossbill") { birdvalue = redCrossbill; }
                        else if (entry == "InvincibleBirdHunter")
                    {
                        total_lives_left = (total_lives_left - 1);       // Remove a life 
                        birdvalue = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                        if (score >= 10000 & bonusgiven == false)   //give a bonus once at 10,000 and then set bonusgiven to true
                        {
                            bonusgiven = true;    //bonus has already been given once 10,000 was reached.
                            total_lives_left = total_lives_left + 1;
                            Console.WriteLine($"You reached 10,000 you now have {total_lives_left} lives.");
                            Console.ForegroundColor = ConsoleColor.Yellow;    // Change the text color to white
                        }
                        else
                        {
                            score = score + birdvalue;      //Update Total score here with each value of bird
                            recentbirdtype = entry;
                            Console.WriteLine($"{entry}              {birdvalue}             {score}             {total_lives_left}");
                            Console.ReadLine(); 
                        } 
                    }
                }
                Console.WriteLine("Game Over!");        //Game over as the score reached 0 lives
                Console.ReadLine();
            }
        }
    }
}