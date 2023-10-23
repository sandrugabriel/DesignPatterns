using Built_in_ASP_IoC_Container;
using MilkyWayponLib;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
       TestDecorators();
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
}