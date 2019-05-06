using UnityEngine;

public abstract class PileScript : CardCollection {
	CardDeck deck = new CardDeck();

	// Use this for initialization
	void Start () {
		var newCard = deck.DealCard();
		Debug.Log(newCard);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
}