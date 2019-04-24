using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	[SerializeField] private GameObject card;
	// Use this for initialization
	void Start ()
	{
		Instantiate(card);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}

//Use Fenger's code example for reference on making the card decks