#region Using Statements
using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
#endregion

public class Card
{   
    private Texture2D texture;
    public Texture2D Texture { get { return texture; } set { texture = value; }} 
    E_Rank rank;
    public E_Rank Rank { get { return rank;  } }
    E_Suit suit;
    public E_Suit Suit { get { return suit; } }
    public Card(E_Rank r, E_Suit s)
    {
        this.rank = r;
        this.suit = s;
    }

    public void DisplayToConsole()
    {
        Console.WriteLine(rank.ToString() + " of " + suit.ToString() + "s"); 
    }

    public void DisplayToDebugConsole()
    {
        System.Diagnostics.Debug.WriteLine(rank.ToString() + " of " + suit.ToString() + "s"); 
    }

    public void DisplayToString(SpriteBatch sbatch, SpriteFont font)
    {
        sbatch.DrawString(font, rank.ToString() + " of " + suit.ToString() + "s", new Vector2(10, 10), Color.White);
    }

    public void LoadContent(ContentManager Content)
    {
        string fileName = "";
        if ((int)rank < 2 || (int)rank >= 11) {
            fileName += rank.ToString()[0]; 
        }
        else {
            int rank_string = (int)rank; 
            fileName += rank_string.ToString(); 
        }

        fileName += suit.ToString()[0]; 

        texture = Content.Load<Texture2D>(fileName);
    }

    public void Draw(SpriteBatch spritebatch, Vector2 location)
    {

    }
    public enum E_Suit
    {
        Spade = 1,
        Diamond,
        Heart,
        Club
    }

    public enum E_Rank
    {
        Ace = 1, 
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12, 
        King = 13
    }
}