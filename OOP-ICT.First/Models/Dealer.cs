using OOP_ICT.Interfaces;

namespace OOP_ICT.Models;

public class Dealer : IDealer
{
    private UserDeck _currentDeck;
    
    public void InitializeCardDeck()
    {
        _currentDeck = new UserDeck();
    }

    public UserDeck CreateShuffledUserDeck()
    {
        _currentDeck.shuffle();
        return _currentDeck;
    }
}