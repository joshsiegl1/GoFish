#region Using Statments
using System.Collections.Generic;
using Microsoft.Xna.Framework;
#endregion

public class Hands
{
    public List<Card> TwoOfAKind = new List<Card>();
    public List<Card> ThreeOfAKind = new List<Card>();
    public List<Card> FourOfAKind = new List<Card>();

    public Hands()
    {
        TwoOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Heart));
        TwoOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Spade));

        ThreeOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Heart));
        ThreeOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Spade));
        ThreeOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Diamond));

        FourOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Heart));
        FourOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Spade));
        FourOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Diamond));
        FourOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Club)); 
    }
}