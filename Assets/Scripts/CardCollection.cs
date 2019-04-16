﻿using System;
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

	public virtual string begin()
	{
		label = "Card collection class";
		Console.WriteLine(label);
		return label;
	}

	public virtual void cardStack()
	{
		

	}


	public void SetUp(String label)
	{
		this.cards = new Stack<Card>();
		this.label = label;
	}

	public virtual void addCard(Card card)
	{
		cards.Push(card);
	}

	public void removeCard()
	{
		cards.Pop();
	}

	public Card GetCard(int i)
	{
		return cards.Peek();
	}
}

