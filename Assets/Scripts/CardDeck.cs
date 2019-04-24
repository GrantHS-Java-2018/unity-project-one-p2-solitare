using System;
using System.Collections.Generic;
using UnityEngine;


public class CardDeck : CardCollection{
 
    
    private Card.Suit[] intToSuit = {
            Card.Suit.Diamond,
            Card.Suit.Club,
            Card.Suit.Heart,
            Card.Suit.Spade
    };
    
    private Card.Rank[] intToRank = {
            Card.Rank.Two,
            Card.Rank.Three,
            Card.Rank.Four,
            Card.Rank.Five,
            Card.Rank.Six,
            Card.Rank.Seven,
            Card.Rank.Eight,
            Card.Rank.Nine,
            Card.Rank.Ten,
            Card.Rank.Jack,
            Card.Rank.Queen,
            Card.Rank.King,
            Card.Rank.Ace
     };




    public Card.Suit[] IntToSuit
    {
        get { return intToSuit; }
        set { intToSuit = value;  }
    }

    private Stack<Card> deckOfCards = new Stack<Card>();// Contains all 52 cards

      
    public CardDeck()    // Constructor
        {
            
            //shuffleDeck();
     

        }

      

        public Card dealCard()
        {
            Card topCard = deckOfCards.Pop();
            return topCard;
        }
        
   }



   




