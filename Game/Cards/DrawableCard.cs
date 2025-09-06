#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
#endregion

public class DrawableCard : Card
{
    public const int Width = 240;
    public const int Height = 336; 
    public static Texture2D BackTexture;    
    protected Texture2D texture;
    public Texture2D Texture { get { return texture; } set { texture = value; } }
    protected float scale = 1f;
    public bool isSelected = false;
    public float normalizedScale = 3;
    public Vector2 Location = Vector2.Zero; 
    public DrawableCard(E_Rank r, E_Suit s) : base(r, s)
    {

    }
    public Rectangle Bounds() 
    {
        return new Rectangle((int)Location.X, (int)Location.Y, Width / 5, Height / 5);
    }
    public virtual void Update(GameTime gameTime)
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

    public virtual void Draw(SpriteBatch spritebatch)
    {
        Color color = isSelected ? Color.Green : Color.White;
        spritebatch.Draw(texture, Location, null, color, 0f,
        new Vector2(texture.Width / normalizedScale, texture.Height / normalizedScale),
            scale, SpriteEffects.None, 1f);
    }
}