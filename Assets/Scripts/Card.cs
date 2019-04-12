
using UnityEngine;
//Converted from Java, might need changing/not work
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


	private Suit _cardSuit;
	private Rank _cardRank;


	public Card(Suit suit, Rank rank)
	{
		_cardSuit = suit;
		_cardRank = rank;
	}

	public Rank GetCardRank()
	{
		return _cardRank;
	}

	public Suit GetCardSuit()
	{
		return _cardSuit;
	}

	public void SetCardRank(Rank cardRank)
	{
		this._cardRank = cardRank;
	}

	public void SetCardSuit(Suit cardSuit)
	{
		this._cardSuit = cardSuit;
	}
}
