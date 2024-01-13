using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Patience
{
    internal class Card
    {
        //boolean variable for card facing up or down
        public bool faceUp { get; set; }
        public bool faceDown { get; set; }

        //default constructor
        public Card() { }

        //constructor with parameters 
        public Card(bool faceUp, bool faceDown)
        {
            this.faceUp = faceUp;
            this.faceDown = faceDown;   
        }
    }
}
