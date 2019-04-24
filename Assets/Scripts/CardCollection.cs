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

