using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.Serialization;

public abstract class CardCollection : MonoBehaviour
{

	public String _label;
	public Stack<Card> cards;

	protected CardCollection()
	{
		begin();
	}

	public virtual string begin()
	{
		_label = "Card collection class";
		
		Console.WriteLine(_label);
		return _label;
	}


	public void SetUp(String label)
	{
		this.cards = new Stack<Card>();
		this._label = label;
	}

	public virtual void  addCard(Card card)
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
