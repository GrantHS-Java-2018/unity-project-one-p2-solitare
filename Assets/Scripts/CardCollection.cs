using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardCollection : MonoBehaviour
{

	private String _label;
	private Stack<Card> _cards;

	public CardCollection(String label)
	{
		this._cards = new Stack<Card>();
		this._label = label;
	}

	public void addCard(Card card)
	{
		_cards.Push(card);
	}

	public void removeCard()
	{
		_cards.Pop();
	}

	public Card GetCard(int i)
	{
		return _cards.Peek();
	}
}
