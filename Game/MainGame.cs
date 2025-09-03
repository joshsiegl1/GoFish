#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
#endregion

public class MainGame
{
    private Deck deck;
    private Hand playerHand;
    private Hand aiHand;
    public MainGame()
    {
        deck = new Deck();
        deck.Populate();
        deck.Shuffle();
        playerHand = new Hand();
        aiHand = new Hand();
    }

    public void Update(GameTime gametime)
    { 

    }

    public void LoadContent(ContentManager Content)
    {
        foreach (Card c in deck.Cards)
        {
            c.LoadContent(Content);
        }
        deck.Deal(ref playerHand, ref aiHand); 
    }

    public void Draw(SpriteBatch spritebatch)
    {
        playerHand.DrawHand(spritebatch, true); 
        aiHand.DrawHand(spritebatch, false); 
    }
}