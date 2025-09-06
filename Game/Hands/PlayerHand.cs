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
        scale = 0.25f; 
    }
    public override void Update(GameTime gameTime)
    {
        foreach (PlayerCard card in PlayerCards)
        {
            card.Update(gameTime);
        }
        base.Update(gameTime);
    }

    /// <summary>
    /// This is wrong, drawing should be handled by the card itself
    /// </summary>
    /// <param name="spritebatch"></param>
    public override void Draw(SpriteBatch spritebatch)
    {
        for (int i = 0; i < PlayerCards.Count; i++)
        {
            Color color = PlayerCards[i].isSelected ? Color.Green : Color.White;
            spritebatch.Draw(PlayerCards[i].Texture,
            new Vector2((50 + (240 / normalizedScale) * i + (5 * i)), Global.ScreenHeight - 100), null, color, 0f,
                    new Vector2(DrawableCard.Width / normalizedScale, DrawableCard.Height / normalizedScale),
                    scale, SpriteEffects.None, 1f);
        }
        base.Draw(spritebatch);
    }
}