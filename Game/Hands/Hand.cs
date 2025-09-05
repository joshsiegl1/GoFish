#region Using Statements
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

public abstract class Hand
{
    public const int LIMIT = 10;
    protected List<DrawableCard> cards = new List<DrawableCard>(LIMIT);
    public List<DrawableCard> Cards { get { return cards; } }
    protected float scale = 1f;
    protected float normalizedScale = 4f; 
    public Hand()
    {

    }

    public virtual void Update(GameTime gameTime)
    { 
        
    }

    public virtual void Draw(SpriteBatch spritebatch)
    {
    }
}