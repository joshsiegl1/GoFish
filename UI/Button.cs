#region Using Statments
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
#endregion

public class Button
{
    private Texture2D texture;
    public Texture2D Texture { get { return texture; } set { texture = value; } }
    private Vector2 position;
    public event EventHandler onClick; 
    public Button(Vector2 position)
    {
        this.position = position;
    }

    private Rectangle Bounds()
    {
        return new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height); 
    }

    private MouseState PMS;
    private MouseState M; 
    bool isMouseCursor = false; 
    public void Update(GameTime gametime)
    {
        M = Mouse.GetState();
        if (Bounds().Contains(M.Position))
        {
            Mouse.SetCursor(MouseCursor.Hand);
            isMouseCursor = true; 
            if (M.LeftButton == ButtonState.Pressed && PMS.LeftButton == ButtonState.Released)
            {
                onClick(null, null);
            }
        }
        else if (isMouseCursor)
        {
            Mouse.SetCursor(MouseCursor.Arrow);
            isMouseCursor = false; 
        }
        PMS = M;
    }
    public void Draw(SpriteBatch spritebatch)
    {
        spritebatch.Draw(texture, position, Color.White);
    }
}