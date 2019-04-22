
using UnityEngine;

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


	public Suit cardSuit { get; set; }

	public Rank cardRank { get; set; }


	public Card(Suit suit, Rank rank)
	{
		cardSuit = suit;
		cardRank = rank;
	}


	private void Update()
	{

	}

}
