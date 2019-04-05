
using UnityEngine;

public class Card : MonoBehaviour
{

	public enum Suit
	{
		diamond,
		club,
		heart,
		spade
	}

	public enum Rank
	{
		ace = 1,
		two = 2,
		three = 3,
		four = 4,
		five = 5,
		six = 6,
		seven = 7,
		eight = 8,
		nine = 9,
		ten = 10,
		jack = 11,
		queen = 12,
		king = 13
	}





	private Suit cardSuit;
	private Rank cardRank;


	public Card(Suit suit, Rank rank)
	{
		cardSuit = suit;
		cardRank = rank;
	}

	public Rank getCardRank()
	{
		return cardRank;
	}

	public Suit getCardSuit()
	{
		return cardSuit;
	}

	public void setCardRank(Rank cardRank)
	{
		this.cardRank = cardRank;
	}

	public void setCardSuit(Suit cardSuit)
	{
		this.cardSuit = cardSuit;
	}
}
