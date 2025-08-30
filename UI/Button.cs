#region Using Statments
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

public class Button
{
    private Texture2D texture;
    private Vector2 position;
    public event EventHandler onClick; 
    public Button(Vector2 position)
    {
        this.position = position;
    }

    public void Draw(SpriteBatch spritebatch)
    { 

    }
}