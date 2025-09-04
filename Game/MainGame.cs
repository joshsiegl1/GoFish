#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
#endregion

public class MainGame
{
    private Deck deck;
    private Hand playerHand;
    private Hand aiHand;
    public MainGame()
    {
        deck = new Deck();
        deck.Populate();
        deck.Shuffle();
        playerHand = new PlayerHand();
        aiHand = new AiHand();
    }

    /// <summary>
    /// This is used to check the bounding box for card highlights on windows
    /// Probably needs to be reworked
    /// </summary>
    private void SetPlayerHandCardLocations()
    {
        for (int i = 0; i < playerHand.Cards.Count; i++)
        {
            playerHand.Cards[i].Location =
                new Vector2(50 + (240 / playerHand.Cards[i].normalizedScale) * i + (5 * i), Global.ScreenHeight - 100);
        }
    }

    public void Update(GameTime gametime)
    {
        aiHand.Update(gametime);
        playerHand.Update(gametime); 
    }

    public void LoadContent(ContentManager Content)
    {
        foreach (Card c in deck.Cards)
        {
            c.LoadContent(Content);
        }
        deck.Deal(ref playerHand, ref aiHand);
        SetPlayerHandCardLocations();  
    }

    public void Draw(SpriteBatch spritebatch)
    {
        playerHand.Draw(spritebatch); 
        aiHand.Draw(spritebatch); 
    }
}