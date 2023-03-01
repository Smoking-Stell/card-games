namespace OOP_ICT.Models;

public class CardDeck
{
    private List<Card> _cards;

    public CardDeck()
    {
        _cards = new List<Card>();
        string[] suits = {"clubs", "diamonds", "hearts", "spades"};
        string[] numbers = {"ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king"};

        foreach (string suit in suits)
        {
            foreach (string number in numbers)
            {
                _cards.Add(new Card(suit, number));
            }
        }
    }
    
    public List<Card> getCards()
    {
        return _cards;
    }

    public void shuffle()
    {
        int n = _cards.Count();
        int delim = n / 2;
        List < Card > newCards = new List<Card>();
        for (int i = 0; i < delim; i++)
        {
            newCards.Add(_cards[i]);
            newCards.Add(_cards[delim + i]);
        }
        _cards = newCards;
    }
}