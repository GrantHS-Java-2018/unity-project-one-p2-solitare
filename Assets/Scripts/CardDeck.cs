using System;
using System.Collections;

public class CardDeck : CardCollection
{
    public override string begin()
    {
        _label = "Card deck";
        Console.WriteLine(_label);
        return _label;
    }
}