#region Using Statments
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

public class Hands
{
    private float normalizedScale = 3; 
    private float scale = 1f; 
    public List<Card> TwoOfAKind = new List<Card>();
    public List<Card> ThreeOfAKind = new List<Card>();
    public List<Card> FourOfAKind = new List<Card>();
    public List<Card> Straight = new List<Card>();
    public List<Card> Flush = new List<Card>();

    public Hands()
    {
        scale = scale / normalizedScale; 
        TwoOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Heart));
        TwoOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Spade));

        ThreeOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Heart));
        ThreeOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Spade));
        ThreeOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Diamond));

        FourOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Heart));
        FourOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Spade));
        FourOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Diamond));
        FourOfAKind.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Club));

        Straight.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Heart));
        Straight.Add(new Card(Card.E_Rank.Two, Card.E_Suit.Spade));
        Straight.Add(new Card(Card.E_Rank.Three, Card.E_Suit.Club));
        Straight.Add(new Card(Card.E_Rank.Four, Card.E_Suit.Diamond));
        Straight.Add(new Card(Card.E_Rank.Five, Card.E_Suit.Heart));

        Flush.Add(new Card(Card.E_Rank.Ace, Card.E_Suit.Heart));
        Flush.Add(new Card(Card.E_Rank.Five, Card.E_Suit.Heart));
        Flush.Add(new Card(Card.E_Rank.Ten, Card.E_Suit.Heart));
        Flush.Add(new Card(Card.E_Rank.Jack, Card.E_Suit.Heart));
        Flush.Add(new Card(Card.E_Rank.King, Card.E_Suit.Heart));
    }

    public void Show(SpriteBatch spritebatch)
    {
        for (int i = 0; i < TwoOfAKind.Count; i++)
        {
            Texture2D t = TwoOfAKind[i].Texture; 
            spritebatch.Draw(t, new Vector2(100 + (i * t.Width / normalizedScale) + 10, 100),
             null, Color.White, 0f, new Vector2(t.Width / normalizedScale, t.Height / normalizedScale),
             scale, SpriteEffects.None, 1f); 
        }
    }
}