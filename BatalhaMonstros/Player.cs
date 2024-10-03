using System;

public class Player
{
    public string Name { get; private set; }
    public Monster Monster { get; private set; }

    public Player(string name, Monster monster)
    {
        Name = name;
        Monster = monster;
    }

    public void TakeTurn(Player opponent)
    {
        Console.WriteLine($"{Name}, é sua vez. Escolha uma ação:");
        Console.WriteLine("1. Atacar");
        Console.WriteLine("2. Defender");
        Console.WriteLine("3. Usar habilidade especial");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Monster.Attack(opponent.Monster);
                break;
            case "2":
                Monster.Defend();
                break;
            case "3":
                Monster.UseSpecialAbility(opponent.Monster);
                break;
            default:
                Console.WriteLine("Opção inválida. Perdeu a vez.");
                break;
        }
    }

    public bool HasLost()
    {
        return Monster.IsDefeated();
    }
}
