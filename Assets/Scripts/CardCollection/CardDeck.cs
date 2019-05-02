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
    
    public void CardAdd()
    {
        for ( int suit = 0; suit < 4; suit++ ) {
            for ( int rank = 0; rank < 13; rank++ ) {
                cards.Push(new CardD(IntToSuit[suit], IntToRank[rank]));
            }
        }

    }

      

        public Card DealCard()
        {
            Card topCard = _deckOfCards.Pop();
            return topCard;
        }
        
   }



   





