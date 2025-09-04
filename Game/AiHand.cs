#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

public class AiHand : Hand
{
    public AiHand() { }

    public override void Draw(SpriteBatch spritebatch)
    {
        for (int i = 0; i < cards.Count; i++)
        {
            spritebatch.Draw(Card.BackTexture, new Vector2((50 + (240 / normalizedScale) * i + (5 * i)), 50), null, Color.White, 0f,
                new Vector2(Card.BackTexture.Width / normalizedScale, Card.BackTexture.Height / normalizedScale),
                scale / normalizedScale, SpriteEffects.None, 1f);
        }
        base.Draw(spritebatch);
    }
}