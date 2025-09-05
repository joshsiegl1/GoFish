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
    private DrawableDeck deck;
    private int drawIndex = 0;
    float scale = 1f;
    float normalizedScale = 2f;
    bool isMouseCursor = false;

    Vector2 location = Vector2.Zero;
    public CardSelector()
    {
        deck = new DrawableDeck();
        deck.Populate();
        location = new Vector2(Global.ScreenWidth - Card.Width / 2, 350); 
    }
    private Rectangle bounds()
    {
        return new Rectangle((int)location.X - Card.Width / 4, (int)location.Y - Card.Height / 4, Card.Width / 2, Card.Height / 2); 
    }
    public void Update(GameTime gametime)
    {
        M = Mouse.GetState();
        if (bounds().Contains(M.Position))
        {
            Mouse.SetCursor(MouseCursor.Hand);
            isMouseCursor = true;
        }
        else if (isMouseCursor)
        {
            Mouse.SetCursor(MouseCursor.Arrow);
            isMouseCursor = false; 
        }
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
        deck.LoadContent(Content); 
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        Texture2D card = deck.Cards[drawIndex].Texture;
        spriteBatch.Draw(card, location, null, Color.White, 0f,
        new Vector2(card.Width / normalizedScale, card.Height / normalizedScale),
             scale / normalizedScale, SpriteEffects.None, 1f);
    }
}