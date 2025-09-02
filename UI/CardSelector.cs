#region Using Statements
using System.Security.Cryptography;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
#endregion

public class CardSelector
{
    private MouseState M, PMS;
    private Deck deck;
    private int drawIndex = 0;
    public CardSelector()
    {
        deck = new Deck();
        deck.Populate();
    }

    public void Update(GameTime gametime)
    {
        M = Mouse.GetState();
        int scrollDelta = M.ScrollWheelValue - PMS.ScrollWheelValue;
        if (scrollDelta < 0)
        {
            if (drawIndex <= 0)
            {
                drawIndex = Deck.LIMIT - 1;
            }
            else drawIndex--; 
        }
        if (scrollDelta > 0)
        {
            if (drawIndex == Deck.LIMIT - 1)
            {
                drawIndex = 0;
            }
            else drawIndex++; 
        }

        PMS = M; 
    }

    public void LoadContent(ContentManager Content)
    {
        foreach (Card c in deck.Cards)
        {
            c.LoadContent(Content); 
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        Texture2D card = deck.Cards[drawIndex].Texture;
        spriteBatch.Draw(card, new Vector2(Global.ScreenWidth - card.Width - 20, 500), Color.White);
    }
}