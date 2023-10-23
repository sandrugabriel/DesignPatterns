using Built_in_ASP_IoC_Container;
using MilkyWayponLib;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        //TestDecorators();
        TestComposite();
    }

    private static void TestDecorators()
    {
        Card soldier = new Card("Soldier", 25, 20);
        soldier = new AttackDecorator(soldier,"Sword",15);
        soldier = new AttackDecorator(soldier, "Amulet", 5);
        soldier = new DefenceDecorator(soldier, "Helmet", 10);
        soldier = new DefenceDecorator(soldier, "Heavy Armor", 45);

        Console.WriteLine($"Final Status: {soldier.Attack} / {soldier.Defense}");
    }

    private static void TestComposite()
    {

        CardDeck deck = new CardDeck();
        CardDeck attackDeck = new CardDeck();
        CardDeck defenseDeck = new CardDeck();

        attackDeck.AddCard(new Card("Basic Infantry Unit", 12, 15));
        attackDeck.AddCard(new Card("Advanced Infantry Unit", 25, 18));
        attackDeck.AddCard(new Card("Cavarly Unit", 32, 24));

        defenseDeck.AddCard(new Card("Wooden Shield", 0, 6));
        defenseDeck.AddCard(new Card("Iron Shield", 0, 9));
        defenseDeck.AddCard(new Card("Shining Royal Armor", 0, 40));

        deck.AddCard(attackDeck);
        deck.AddCard(new Card("Small Beast", 16, 3));
        deck.AddCard(new Card("High Elf Rogue", 22, 7));
        deck.AddCard(defenseDeck);

        Console.WriteLine(deck.Display());
    }
}