namespace OOP_ICT.Models;

public class Card
{
    private string _suit;
    private string _number;

    public string GetSuit()
    {
        return _suit;
    }        
    public string GetNumber()
    {
        return _number;
    }    
    
    public Card(string suit, string number)
    {
        _suit = suit;
        _number = number;
    }

    public override string ToString()
    {
        return _number + " of " + _suit;
    }
}