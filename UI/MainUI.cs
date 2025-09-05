#region Using Statments
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
#endregion

public class MainUI
{
    Hands hands;
    Button btnShowHands;
    CardSelector cardSelector; 
    bool showHands = false;

    public MainUI()
    {
        hands = new Hands();
        cardSelector = new CardSelector(); 
        btnShowHands = new Button(new Vector2(Global.ScreenWidth - 170, 150));
        btnShowHands.onClick += onShowHands;
    }

    public void LoadContent(ContentManager Content)
    {
        btnShowHands.Texture = Content.Load<Texture2D>("showHandsButton");
        cardSelector.LoadContent(Content);
        hands.LoadContent(Content); 
    }

    public void Update(GameTime gametime)
    {
        btnShowHands.Update(gametime);
        cardSelector.Update(gametime); 
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
        cardSelector.Draw(spriteBatch); 
    }

}