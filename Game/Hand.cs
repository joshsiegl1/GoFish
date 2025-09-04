#region Using Statements
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

public class Hand
{
    public const int LIMIT = 10;
    protected List<Card> cards = new List<Card>(LIMIT);
    public List<Card> Cards { get { return cards; } }
    float scale = 1f;
    float normalizedScale = 4f; 
    public Hand()
    {

    }

    public virtual void Update(GameTime gameTime)
    { 
        
    }

    public virtual void DrawHand(SpriteBatch spritebatch, bool face)
    {
        if (face)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                spritebatch.Draw(cards[i].Texture,
                new Vector2((50 + (240 / normalizedScale) * i + (5 * i)), Global.ScreenHeight - 100), null, Color.White, 0f,
                        new Vector2(Card.BackTexture.Width / normalizedScale, Card.BackTexture.Height / normalizedScale),
                        scale / normalizedScale, SpriteEffects.None, 1f);
            }
        }
        else
        {
            for (int i = 0; i < cards.Count; i++)
            {
                spritebatch.Draw(Card.BackTexture, new Vector2((50 + (240 / normalizedScale) * i + (5 * i)), 50), null, Color.White, 0f,
                    new Vector2(Card.BackTexture.Width / normalizedScale, Card.BackTexture.Height / normalizedScale),
                    scale / normalizedScale, SpriteEffects.None, 1f);
            }
        }
    }
}