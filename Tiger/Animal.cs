using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiger
{

    public class Animal
    {

        //Public List<string> listOfHints { get; set; }

        //listOfHints.Add(1) = "It can run fast";
        //listOfHints.Add(2) = "It has a long tail";
        //listOfHints.Add(3) = "It has orange fur";
        //listOfHints.Add(4)="It has dark vertical stripes.";
        //listOfHints.Add(5)="It can run > 35 mph.";
        //"It has fur gives high camouglage that is orange and black.",

        public int Hints { get; set; }

        public string[] listOfHints { get; set; } = new string[] {"It can run fast", "It lives in the sahara", "it's a tiger"};

        public Animal() { }
    }

    public class Elephant
    { 
        
    
    }
}


