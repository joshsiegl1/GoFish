#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
#endregion

public class Deck
{
    public const int LIMIT = 52;
    private List<Card> cards = new List<Card>(LIMIT);
    public List<Card> Cards { get { return cards; } }
    public Deck() { }

    public void Populate()
    {
        for (int s = 1; s <= 4; s++)
        {
            for (int r = 1; r <= 13; r++)
            {
                cards.Add(new Card((Card.E_Rank)r, (Card.E_Suit)s));
            }
        }
    }

    Random random = new Random();
    public void Shuffle()
    {
        List<Card> newCards = new List<Card>(LIMIT);
        while (cards.Count > 0)
        {
            int replace = random.Next(cards.Count);
            newCards.Add(cards[replace]);
            cards.RemoveAt(replace);
        }
        cards = newCards; 
    }
}