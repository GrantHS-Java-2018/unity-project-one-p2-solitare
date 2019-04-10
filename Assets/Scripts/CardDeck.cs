using System;
using System.Collections;

public class CardDeck : CardCollection
{
    
    //don't know if any of this works/ what we'd use it for
    public override string begin()
    {
        label = "Card deck";
        Console.WriteLine(label);
        return label;
    }
}