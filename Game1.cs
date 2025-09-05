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
    private MainUI UIMain;
    private MainGame GameMain; 
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
        UIMain = new MainUI();
        GameMain = new MainGame(); 
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        DrawableCard.BackTexture = Content.Load<Texture2D>("cardback"); 
        UIMain.LoadContent(Content);
        GameMain.LoadContent(Content); 
        font = Content.Load<SpriteFont>("font");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        UIMain.Update(gameTime);
        GameMain.Update(gameTime); 

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(new Color(53, 101, 77));
        _spriteBatch.Begin();
        GameMain.Draw(_spriteBatch); 
        UIMain.Draw(_spriteBatch);
        _spriteBatch.End(); 
        base.Draw(gameTime);
    }
}
