#region Using Statments
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
#endregion

public class Main
{
    Hands hands;
    Button btnShowHands;
    bool showHands = false;

    public Main()
    {
        hands = new Hands(); 
        btnShowHands = new Button(new Vector2(Global.ScreenWidth - 120, 10));
        btnShowHands.onClick += onShowHands;
    }

    public void LoadContent(ContentManager Content)
    {
        btnShowHands.Texture = Content.Load<Texture2D>("showHandsButton");
        foreach (Card c in hands.TwoOfAKind)
        {
            c.LoadContent(Content); 
        }
    }

    public void Update(GameTime gametime)
    {
        btnShowHands.Update(gametime); 
    }

    public void onShowHands(object sender, EventArgs e)
    {
        showHands = !showHands;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        btnShowHands.Draw(spriteBatch);
        if (showHands)
        {
            hands.Show(spriteBatch); 
        }
    }

}