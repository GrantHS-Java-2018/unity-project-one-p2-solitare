
using System;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class Card : MonoBehaviour
{

	public enum Suit
	{
		Diamond,
		Club,
		Heart,
		Spade
	}

	public enum Rank
	{
		Ace = 1,
		Two = 2,
		Three = 3,
		Four = 4,
		Five = 5,
		Six = 6,
		Seven = 7,
		Eight = 8,
		Nine = 9,
		Ten = 10,
		Jack = 11,
		Queen = 12,
		King = 13
	}

	public Card()
	{
		CardSuit = CardSuitMethod(Suit.Club);
		CardRank = CardRankMethod(Rank.Ace);
		
		
	}

	private Suit CardSuit { get; set; }

	private Rank CardRank { get; set; }


	public Card.Suit CardSuitMethod (Suit suit)
	{
		CardSuit = suit;
		Debug.Log("worked");
		Debug.Log(suit);
		return suit;
		
	}
	
	public Card.Rank CardRankMethod (Rank rank)
	{
		CardRank = rank;
		Debug.Log("worked");
		Debug.Log(rank);
		return rank;
	}


	private void Update()
	{

	}

}
