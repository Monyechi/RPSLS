using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    abstract class Player
    {
        // Member variables (HAS A)
        public int score;
        public string chosenGesture;
        public List<string> gestures;
        public string name;
        // Constructor (SPAWNER)        
        public Player()
        {
            gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Sissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
            SetName();
        }
        // member methods (CAN DO)
        public abstract void ChoseGesture();

        public abstract void SetName();
            

    }
}
