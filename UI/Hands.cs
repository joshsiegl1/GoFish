#region Using Statments
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
#endregion

public class Hands
{
    private float normalizedScale = 3;
    private float scale = 1f;
    public List<DrawableCard> TwoOfAKind = new List<DrawableCard>();
    public List<DrawableCard> ThreeOfAKind = new List<DrawableCard>();
    public List<DrawableCard> FourOfAKind = new List<DrawableCard>();
    public List<DrawableCard> Straight = new List<DrawableCard>();
    public List<DrawableCard> Flush = new List<DrawableCard>();
    public List<DrawableCard> StraightFlush = new List<DrawableCard>();
    public List<DrawableCard> RoyalFlush = new List<DrawableCard>();

    public Hands()
    {
        scale = scale / normalizedScale;
        TwoOfAKind.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Heart));
        TwoOfAKind.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Spade));

        ThreeOfAKind.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Heart));
        ThreeOfAKind.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Spade));
        ThreeOfAKind.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Diamond));

        FourOfAKind.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Heart));
        FourOfAKind.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Spade));
        FourOfAKind.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Diamond));
        FourOfAKind.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Club));

        Straight.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Heart));
        Straight.Add(new DrawableCard(Card.E_Rank.Two, Card.E_Suit.Spade));
        Straight.Add(new DrawableCard(Card.E_Rank.Three, Card.E_Suit.Club));
        Straight.Add(new DrawableCard(Card.E_Rank.Four, Card.E_Suit.Diamond));
        Straight.Add(new DrawableCard(Card.E_Rank.Five, Card.E_Suit.Heart));

        Flush.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Heart));
        Flush.Add(new DrawableCard(Card.E_Rank.Five, Card.E_Suit.Heart));
        Flush.Add(new DrawableCard(Card.E_Rank.Ten, Card.E_Suit.Heart));
        Flush.Add(new DrawableCard(Card.E_Rank.Jack, Card.E_Suit.Heart));
        Flush.Add(new DrawableCard(Card.E_Rank.King, Card.E_Suit.Heart));

        StraightFlush.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Heart));
        StraightFlush.Add(new DrawableCard(Card.E_Rank.Two, Card.E_Suit.Heart));
        StraightFlush.Add(new DrawableCard(Card.E_Rank.Three, Card.E_Suit.Heart));
        StraightFlush.Add(new DrawableCard(Card.E_Rank.Four, Card.E_Suit.Heart));
        StraightFlush.Add(new DrawableCard(Card.E_Rank.Five, Card.E_Suit.Heart));

        RoyalFlush.Add(new DrawableCard(Card.E_Rank.Ten, Card.E_Suit.Heart));
        RoyalFlush.Add(new DrawableCard(Card.E_Rank.Jack, Card.E_Suit.Heart));
        RoyalFlush.Add(new DrawableCard(Card.E_Rank.Queen, Card.E_Suit.Heart));
        RoyalFlush.Add(new DrawableCard(Card.E_Rank.King, Card.E_Suit.Heart));
        RoyalFlush.Add(new DrawableCard(Card.E_Rank.Ace, Card.E_Suit.Heart)); 
    }

    public void LoadContent(ContentManager Content)
    {
        foreach (DrawableCard card in TwoOfAKind)
            card.LoadContent(Content); 
        foreach (DrawableCard card in ThreeOfAKind)
            card.LoadContent(Content);
        foreach (DrawableCard card in FourOfAKind)
            card.LoadContent(Content);
        foreach (DrawableCard card in Straight)
            card.LoadContent(Content);
        foreach (DrawableCard card in Flush)
            card.LoadContent(Content);
        foreach (DrawableCard card in StraightFlush)
            card.LoadContent(Content);
        foreach (DrawableCard card in RoyalFlush)
            card.LoadContent(Content);
    }

    public void Show(SpriteBatch spritebatch)
    {
        for (int i = 0; i < TwoOfAKind.Count; i++)
        {
            Texture2D t = TwoOfAKind[i].Texture;
            DrawCard(t, i, 1, spritebatch);
        }

        for (int i = 0; i < ThreeOfAKind.Count; i++)
        {
            Texture2D t = ThreeOfAKind[i].Texture;
            DrawCard(t, i, 2, spritebatch);
        }

        for (int i = 0; i < FourOfAKind.Count; i++)
        {
            Texture2D t = FourOfAKind[i].Texture;
            DrawCard(t, i, 3, spritebatch);
        }

        for (int i = 0; i < Straight.Count; i++)
        {
            Texture2D t = Straight[i].Texture;
            DrawCard(t, i, 4, spritebatch);
        }

        for (int i = 0; i < Flush.Count; i++)
        {
            Texture2D t = Flush[i].Texture;
            DrawCard(t, i, 5, spritebatch);
        }

        for (int i = 0; i < StraightFlush.Count; i++)
        {
            Texture2D t = StraightFlush[i].Texture;
            DrawCard(t, i, 6, spritebatch);
        }

        for (int i = 0; i < RoyalFlush.Count; i++)
        {
            Texture2D t = RoyalFlush[i].Texture;
            DrawCard(t, i, 7, spritebatch); 
        }
    }

    private void DrawCard(Texture2D t, int i, int y, SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(t, new Vector2(100 + (i * t.Width / normalizedScale) + 5 * i, (50 * y) + 20),
             null, Color.White, 0f, new Vector2(t.Width / normalizedScale, t.Height / normalizedScale),
             scale, SpriteEffects.None, 1f);
    }
}