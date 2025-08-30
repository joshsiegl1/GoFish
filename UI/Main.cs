#region Using Statments
using System;
using Microsoft.Xna.Framework;
#endregion

public class Main
{
    Hands hands;
    Button btnShowHands;
    bool showHands = false;

    public Main()
    {
        btnShowHands.onClick += onShowHands; 
    }

    public void onShowHands(object sender, EventArgs e)
    {
        showHands = !showHands; 
    }

}