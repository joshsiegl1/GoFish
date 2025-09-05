#region Using Statements
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
#endregion

public class PlayerHand : Hand
{
    private List<PlayerCard> playerCards = new List<PlayerCard>(LIMIT);
    public List<PlayerCard> PlayerCards { get { return playerCards; } }
    public PlayerHand()
    {
    }
    public override void Update(GameTime gameTime)
    {
        foreach (PlayerCard card in PlayerCards)
        {
            card.Update(gameTime);
        }
        base.Update(gameTime);
    }
    public override void Draw(SpriteBatch spritebatch)
    {
        for (int i = 0; i < PlayerCards.Count; i++)
        {
            spritebatch.Draw(PlayerCards[i].Texture,
            new Vector2((50 + (240 / normalizedScale) * i + (5 * i)), Global.ScreenHeight - 100), null, Color.White, 0f,
                    new Vector2(DrawableCard.Width / normalizedScale, DrawableCard.Height / normalizedScale),
                    scale / normalizedScale, SpriteEffects.None, 1f);
        }
        base.Draw(spritebatch);
    }
}