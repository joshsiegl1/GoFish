#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework;
#endregion

public class Deck
{
    public const int LIMIT = 52;
    private const int SUIT_COUNT = 4;
    private const int RANK_COUNT = 13;
    private List<Card> cards = new List<Card>(LIMIT);
    public List<Card> Cards { get { return cards; } }
    public Deck() { }

    public void Populate()
    {
        for (int s = 1; s <= SUIT_COUNT; s++)
        {
            for (int r = 1; r <= RANK_COUNT; r++)
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

    public void Deal(ref PlayerHand playerHand, ref AiHand aiHand)
    {
        bool playerHandFull = false;
        bool aiHandFull = false;
        while (!playerHandFull && !aiHandFull)
        {
            if (playerHand.Cards.Count <= Hand.LIMIT)
            {
                playerHand.PlayerCards.Add(RemoveCard(true));
            }
            else playerHandFull = true;

            if (aiHand.Cards.Count <= Hand.LIMIT)
            {
                aiHand.Cards.Add(RemoveCard());
            }
            else aiHandFull = true;
        }
    }

    private PlayerCard RemoveCard(bool isPlayer = true)
    {
        PlayerCard c = new PlayerCard(Cards[0].Rank, Cards[0].Suit);
        cards.RemoveAt(0);
        return c;
    }

    private DrawableCard RemoveCard()
    {
        DrawableCard c = (DrawableCard)cards[0];
        cards.RemoveAt(0);
        return c;
    }
}