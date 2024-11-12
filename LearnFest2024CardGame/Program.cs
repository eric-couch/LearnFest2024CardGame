using LearnFest2024CardGame;

Deck myDeck = new Deck();

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Enter Player One name: ");
Player playerOne = new Player(Console.ReadLine()!);

for (int i = 0; i < 5; i++)
{
    playerOne.Hand.Add(myDeck.DealCard());
}

playerOne.ShowHand();
