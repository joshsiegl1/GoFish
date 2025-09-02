#region Using Statements
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

public class Hand
{
    public const int LIMIT = 10;
    List<Card> cards = new List<Card>(LIMIT);
    public List<Card> Cards { get { return cards; } }
    public Hand()
    {

    }

    public void DrawHand(SpriteBatch spritebatch)
    { 
        
    }
}