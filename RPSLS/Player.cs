﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    abstract class Player
    {
        // Member variables (HAS A)
        public int score;
        public string coosenGesture;

        // Constructor (SPAWNER)        
        public Player()
        {            
            
        }
        // member methods (CAN DO)
        public abstract void ChooseGesture();              
              
               
            

    }
}