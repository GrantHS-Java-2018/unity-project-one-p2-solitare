<<<<<<< HEAD:Assets/Scripts/CardCollection/PileScript.cs
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PileScript : CardCollection {

	// Use this for initialization
	void Start () {
=======
﻿using UnityEngine;

public abstract class PileScript : CardCollection {
	private CardDeck deck = new CardDeck();

	// Use this for initialization
	void Start () {
		var newCard = deck.DealCard();
		Debug.Log(newCard);
>>>>>>> master:Assets/Scripts/CardCollection/Pile Scripts/PileScript.cs
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
<<<<<<< HEAD:Assets/Scripts/CardCollection/PileScript.cs
}
=======
	
}
>>>>>>> master:Assets/Scripts/CardCollection/Pile Scripts/PileScript.cs
