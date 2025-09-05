#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
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
        }
        else if (isMouseCursor)
        {
           isMouseCursor = false;
           Mouse.SetCursor(MouseCursor.Arrow);  
        } 
        PMS = M;
        base.Update(gameTime);
    }

}