using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFest2024CardGame;

public class Card
{
    public string suit { get; set; }  // ♥, ♦, ♣, ♠

    public int value { get; set; } // 2, 3, 4... 10, 11, 12, 13, 14
    public string rank { get; set; }  // 2, 3, 4... 10, J, Q, K, A
    public string color { get; set; } // red, black

    public Card(string suit, int value, string rank)
    {
        this.suit = suit;
        this.value = value;
        this.rank = rank;
    }

    public override string? ToString()
    {
        return $"{rank}{suit}";
    }
}
