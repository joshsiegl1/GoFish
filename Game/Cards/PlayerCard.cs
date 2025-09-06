#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
#endregion

public class PlayerCard : DrawableCard
{
    public PlayerCard(E_Rank r, E_Suit s) : base(r, s)
    {
    }
    private bool isMouseCursor = false;
    private MouseState PMS;
    private MouseState M;
    override public void Update(GameTime gameTime)
    {
        M = Mouse.GetState();
        if (Bounds().Contains(M.Position))
        {
            isMouseCursor = true;
            Mouse.SetCursor(MouseCursor.Hand);
            isSelected = true;
        }
        else if (isMouseCursor)
        {
            isMouseCursor = false;
            Mouse.SetCursor(MouseCursor.Arrow);
            isSelected = false;
        }
        PMS = M;
        base.Update(gameTime);
    }
    
    override public void Draw(SpriteBatch spritebatch)
    {
        Color color = isSelected ? Color.Green : Color.White;
        spritebatch.Draw(Texture,
            Location, null, color, 0f,
            new Vector2(DrawableCard.Width / normalizedScale, DrawableCard.Height / normalizedScale),
            scale, SpriteEffects.None, 1f);
        base.Draw(spritebatch);
    }

}