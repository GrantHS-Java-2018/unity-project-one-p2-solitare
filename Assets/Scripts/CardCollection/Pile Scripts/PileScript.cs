using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PileScript : CardCollection {
	CardDeck deck = new CardDeck();

	// Use this for initialization
	void Start () {
		Stack<Card> Pile = new Stack<Card>(7);
		var newCard = deck.DealCard();
		Pile.Push(newCard);
		Debug.Log(newCard);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
}