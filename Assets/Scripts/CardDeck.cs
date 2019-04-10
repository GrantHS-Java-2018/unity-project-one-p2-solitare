using System;
using System.Collections;

public class CardDeck : CardCollection
{
    
    //don't know if any of this works/ what we'd use it for
    public override string begin()
    {
        _label = "Card deck";
        Console.WriteLine(_label);
        return _label;
    }
}