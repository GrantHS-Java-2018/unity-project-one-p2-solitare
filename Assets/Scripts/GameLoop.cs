using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class GameLoop : MonoBehaviour {

	
	Stack drawPile= new Stack();
	Stack drawPileClicked = new Stack();
	Stack rowOne= new Stack();
	Stack rowTwo= new Stack();
	Stack rowThree= new Stack();
	Stack rowFour= new Stack();
	Stack rowFive= new Stack();
	Stack rowSix= new Stack();
	Stack rowSeven= new Stack();
	Stack acesDiamond= new Stack();
	Stack acesHearts= new Stack();
	Stack acesClubs= new Stack();
	Stack acesSpades= new Stack();
	Stack movementSpace= new Stack();
	Stack rowTwoFacedown= new Stack();
	Stack rowThreeFacedown= new Stack();
	Stack rowFourFacedown= new Stack();
	Stack rowFiveFacedown= new Stack();
	Stack rowSixFacedown= new Stack();
	Stack rowSevenFacedown= new Stack();
	void Start ()
	{
		CardDeck deck = new CardDeck();
		
		
		int color;
		
		
		if (deck.IntToSuit.Equals(1))
		{
			color = 1;
		}
		
		//Hearts, Diamonds color =1
		//Spades, Clubs color=2
		//+ suit for the ace piles
		



		
	}

	//public void Aces()
	//{

	//	if (Card.value == TopCard.value + 1 && suit == matching)
	///	{
	//move to pile
	//from which and to which?
	//}
	//Else{
	//do nothing }
//}

//only interact with face up cards


	
	

	public void Shuffle()
	{
		var card = drawPile.Pop();
		rowOne.Push(card);
		card = drawPile.Pop();
		rowTwoFacedown.Push(card);
		card = drawPile.Pop();
		rowTwo.Push(card);
		
		for(var q = 0; q < 2; q++){
			card = drawPile.Pop();
			rowThreeFacedown.Push(card);}
		
		card = drawPile.Pop();
		rowThree.Push(card);
		
		for (var w = 0; w < 3; w++)
		{
			card = drawPile.Pop();
			rowFourFacedown.Push(card);
		}

		card = drawPile.Pop();
		rowFour.Push(card);
		
		for(var e = 0; e < 4; e++){
			card = drawPile.Pop();
			rowFiveFacedown.Push(card);}
		
		card = drawPile.Pop();
		rowFive.Push(card);
		
		for(var r = 0; r < 5; r++){
			card = drawPile.Pop();
			rowSixFacedown.Push(card);}
		
		card = drawPile.Pop();
		rowSix.Push(card);
		
		for(var t = 0; t < 6; t++){
			card = drawPile.Pop();
			rowSevenFacedown.Push(card);}
		
		card = drawPile.Pop();
		rowSeven.Push(card);

	}

	private void CheckLength()
	{
		object current;
		//Sense when stack for flipped cards is empty and shift stacks
		if(rowTwo.Count==0){
			current = rowTwoFacedown.Pop();
			rowTwo.Push(current);
		}
		if(rowThree.Count==0){
			current = rowThreeFacedown.Pop();
			rowThree.Push(current);
		}
		if(rowFour.Count==0){
			current= rowFourFacedown.Pop();
			rowFour.Push(current);
		}
		if(rowFive.Count==0){
			current = rowFiveFacedown.Pop();
			rowFive.Push(current);
		}
		if(rowSix.Count==0){
			current = rowSixFacedown.Pop();
			rowSix.Push(current);
		}
		if(rowSeven.Count==0){
			current = rowSevenFacedown.Pop();
			rowSeven.Push(current);
		}

	}



//Deal in 7 rows, 1,2,3,4,5,6,7 cards each, only top card visible

//only check if player moves card to the pile
//does not apply to movement stack

	

	public bool Win()
	{
		bool win; 
		if(acesDiamond.Count==13 && acesHearts.Count==13  && acesClubs.Count==13 
		   && acesSpades.Count==13)
		{
			win = true;
		}
		else
		{
			win = false;
		}

		return win;
	}
}
