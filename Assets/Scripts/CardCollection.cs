using System;
using System.Collections.Generic;
using UnityEngine;


public abstract class CardCollection : MonoBehaviour
{
	//Don't know if any of this works or if we need it, might have extra things
	public String label;
	public Stack<Card> cards;

	protected CardCollection()
	{
	
	}
	
	private Card.Suit[] _intToSuit = {
		Card.Suit.Diamond,
		Card.Suit.Club,
		Card.Suit.Heart,
		Card.Suit.Spade
	};
    
	private Card.Rank[] _intToRank = {
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
		get { return _intToSuit; }
		set { _intToSuit = value;  }
	}
    
	public Card.Rank[] IntToRank
	{
		get { return _intToRank; }
		set { _intToRank = value;  }
	}


	public virtual string Begin()
	{
		label = "Card collection class";
		Console.WriteLine(label);
		return label;
	}

	public virtual void CardStack()
	{
		

	}


	public void SetUp(String label)
	{
		this.cards = new Stack<Card>();
		this.label = label;
	}

	public virtual void  AddCard(Card card)
	{
		cards.Push(card);
	}

	public void RemoveCard()
	{
		cards.Pop();
	}

	public Card GetCard(int i)
	{
		return cards.Peek();
	}
	
	
}

