using System;
using System.Collections;
using UnityEngine;

public class CardDeck : CardCollection
{
    private Card card = new Card();
   
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

    private Queue<Card> deckOfCards = new Queue();// Contains all 52 cards

    public CardDeck()    // Constructor
    {
        for ( int suit = 0; suit < 4; suit++ ) {
            for ( int rank = 0; rank < 13; rank++ ) {
                deckOfCards.Enqueue(new Card(intToSuit[suit], intToRank[rank]));
            }
        }
        shuffleDeck();
       

    }

    public void shuffleDeck()
    {
        deckOfCards.
        Collections.shuffle(deckOfCards);
    }

    public Card dealCard()
    {
        Card topCard = deckOfCards.get(0);
        deckOfCards.remove(0);
        return topCard;
    }
}



