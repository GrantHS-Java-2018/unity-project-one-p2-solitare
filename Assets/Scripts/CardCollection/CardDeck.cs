using System;
using System.Collections.Generic;
using UnityEngine;


public class CardDeck : CardCollection{
 
    

    private Stack<Card> _deckOfCards = new Stack<Card>();// Contains all 52 cards

      
    public CardDeck()    // Constructor
        {
            
            //shuffleDeck();
            Debug.Log("Called");

        }

      

        public Card DealCard()
        {
            Card topCard = _deckOfCards.Pop();
            return topCard;
        }
        
   }



   





