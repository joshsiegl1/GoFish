#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
#endregion

public class DrawableCard : Card
{
    protected Texture2D texture;
    public Texture2D Texture { get { return texture; } set { texture = value; } }
    private float scale = 1f;
    public float normalizedScale = 3;
    public DrawableCard(E_Rank r, E_Suit s) : base(r, s)
    {

    }
    public void LoadContent(ContentManager Content)
    {
        string fileName = "";
        if ((int)rank < 2 || (int)rank >= 11)
        {
            fileName += rank.ToString()[0];
        }
        else
        {
            int rank_string = (int)rank;
            fileName += rank_string.ToString();
        }

        fileName += suit.ToString()[0];

        texture = Content.Load<Texture2D>(fileName);
    }
    
    public virtual void Draw(SpriteBatch spritebatch, Vector2 location)
    {
        spritebatch.Draw(texture, location, null, Color.White, 0f,
        new Vector2(texture.Width / normalizedScale, texture.Height / normalizedScale),
             scale, SpriteEffects.None, 1f);
    }
}