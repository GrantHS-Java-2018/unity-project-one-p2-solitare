
using UnityEngine;
//Converted from Java, might need changing/not work
public class Card : MonoBehaviour
{

	public Card myPrefab;
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


	public Suit _cardSuit { get; set; }

	public Rank _cardRank { get; set; }


	public Card(Suit suit, Rank rank)
	{
		_cardSuit = suit;
		_cardRank = rank;
	}

	private void Start()
	{
		Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
	}
}
