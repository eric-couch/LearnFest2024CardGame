using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFest2024CardGame;

public class Deck
{
    public List<Card> Cards { get; set; } = new List<Card>();

    public Deck() {
        // create all the Cards for List<Card> Cards
        Reset();
    }

    public void Reset()
    {
        Cards.Clear();
        List<string> suits = new List<string>() { "♥", "♦", "♣", "♠" };
        List<string> ranks = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        List<int> values = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                Card card = new Card(suit, values[ranks.IndexOf(rank)], rank);
                Cards.Add(card);
            }
        }
    }

    public Card DealCard()
    {
        // return card from deck
        Random rnd = new Random();
        int indexOfCardToDeal = rnd.Next(Cards.Count);
        Card cardToDeal = Cards[indexOfCardToDeal]; 
        // also remove that card from the deck
        Cards.RemoveAt(indexOfCardToDeal);
        return cardToDeal;
    }
    
}
