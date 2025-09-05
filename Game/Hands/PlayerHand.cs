#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
#endregion

public class PlayerHand : Hand
{
    public PlayerHand() { }
    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }
    public override void Draw(SpriteBatch spritebatch)
    {
        for (int i = 0; i < cards.Count; i++)
        {
            spritebatch.Draw(cards[i].Texture,
            new Vector2((50 + (240 / normalizedScale) * i + (5 * i)), Global.ScreenHeight - 100), null, Color.White, 0f,
                    new Vector2(DrawableCard.Width / normalizedScale, DrawableCard.Height / normalizedScale),
                    scale / normalizedScale, SpriteEffects.None, 1f);
        }
        base.Draw(spritebatch);
    }
}