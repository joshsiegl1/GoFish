#region Using Statements
using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

public class Card
{
    protected E_Rank rank;
    public E_Rank Rank { get { return rank;  } }
    protected E_Suit suit;
    public E_Suit Suit { get { return suit; } }
    public Card(E_Rank r, E_Suit s)
    {
        this.rank = r;
        this.suit = s;
    }
    public override bool Equals(object obj)
    {
        if (obj is Card other)
        {
            return this.suit == other.suit && this.rank == other.rank;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Suit, Rank);
    }
    public static bool operator ==(Card left, Card right)
    {
        if (ReferenceEquals(left, right)) return true;
        if (left is null || right is null) return false;
        return left.Equals(right);
    }
    public static bool operator !=(Card left, Card right)
    {
        return !(left == right);
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