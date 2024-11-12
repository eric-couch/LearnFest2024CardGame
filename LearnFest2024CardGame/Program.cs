using LearnFest2024CardGame;

Deck myDeck = new Deck();
List<Card> hand = new List<Card>();

Console.OutputEncoding = System.Text.Encoding.UTF8;

for (int i = 0; i < 5; i++)
{
    hand.Add(myDeck.DealCard());
}

foreach (Card card in hand)
{
    Console.Write($"{card.ToString()}\t");
}
Console.WriteLine();
