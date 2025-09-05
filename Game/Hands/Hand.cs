#region Using Statements
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

public abstract class Hand
{
    public const int LIMIT = 10;
    protected List<Card> cards = new List<Card>(LIMIT);
    public List<Card> Cards { get { return cards; } }
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