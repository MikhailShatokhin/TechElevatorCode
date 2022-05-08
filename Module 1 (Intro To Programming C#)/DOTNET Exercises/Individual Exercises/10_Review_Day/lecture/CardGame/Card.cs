﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class Card
    {
        //todo Create a Card
        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }
        public string Suit { get; private set; } // H, D, S, C
        public string Value { get; private set; } // 2, 3, 4, ....., 10, J, Q, K, A


    
    
    }
}
