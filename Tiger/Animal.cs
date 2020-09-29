using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public Animal() { }

        public string[] listOfHints { get; set; } = new string[]
        {
            "HINT:: IT CAN RUN FAST.",
            "HINT:: IT LIVES IN THE SAHARA",
            "HINT:: IT HAS A LONG TAIL",
            "HINT:: IT HAS ORANGE FUR",
            "HINT:: IT HAS DARK VERTICAL STRIPES",
            "HINT:: IT CAN RUN GREATER THAN 35 MPH.",
            "HINT:: IT HAS FUR THAT GIVES HIGH CAMOFLAUGE THAT IS ORANGE AND BLACK."
        };
    
    }
}


