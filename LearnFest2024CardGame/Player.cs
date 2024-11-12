using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFest2024CardGame;

public class Player
{
    public string Name { get; set; }
    public List<Card> Hand { get; set; } = new List<Card>();

    public Player(string _name)
    {
        this.Name = _name;
    }

    public void GetCard(Card card)
    {
        Hand.Add(card);
    }

    public void PassCard(Card card)
    {
        Hand.Remove(card);
    }

    public void ClearHand() {
        Hand.Clear();
    }

    public void ShowHand()
    {
        int pos = 1;
        string cardPos = string.Empty;
        foreach (Card card in Hand)
        {
            Console.Write($"{card.ToString()}\t");
            cardPos += $"{pos++}\t";
        }
        Console.WriteLine($"\n{cardPos}");
    }
}
