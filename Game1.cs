using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Runtime.InteropServices;

namespace GoFish;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private SpriteFont font; 
    private Deck deck;

    private Main UIMain; 

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        _graphics.PreferredBackBufferWidth = Global.ScreenWidth;
        _graphics.PreferredBackBufferHeight = Global.ScreenHeight;
        _graphics.ApplyChanges();
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        deck = new Deck();
        deck.Populate();
        UIMain = new Main(); 
#if DEBUG
        int _index = 0;
        foreach (Card c in deck.Cards)
        {
            Console.Write(_index.ToString() + " ");
            c.DisplayToConsole();
            _index++; 
        }
        deck.Shuffle();
        Console.WriteLine("--- SHUFFLE ---");
        _index = 0;
        foreach (Card c in deck.Cards)
        {
            Console.Write(_index.ToString() + " ");
            c.DisplayToConsole();
            _index++; 
        }
        #endif
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        UIMain.LoadContent(Content); 
        font = Content.Load<SpriteFont>("font");
        foreach (Card c in deck.Cards)
        {
            c.LoadContent(Content); 
        } 
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        UIMain.Update(gameTime); 

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(new Color(53, 101, 77));
        _spriteBatch.Begin();
        UIMain.Draw(_spriteBatch); 
        // int i = 0;
        // foreach (Card c in deck.Cards)
        // {
        //     _spriteBatch.Draw(c.Texture, new Vector2(10 + i, 10), Color.White); 
        //     i += 50; 
        // }
        _spriteBatch.End(); 
        base.Draw(gameTime);
    }
}
