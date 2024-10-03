using System;

public class Game
{
    private Player player1;
    private Player player2;

    public Game(Player p1, Player p2)
    {
        player1 = p1;
        player2 = p2;
    }

    public void Start()
    {
        Console.WriteLine("A batalha começa!");

        while (true)
        {
            player1.TakeTurn(player2);
            if (player2.HasLost())
            {
                Console.WriteLine($"{player2.Name} perdeu! {player1.Name} venceu!");
                break;
            }

            player2.TakeTurn(player1);
            if (player1.HasLost())
            {
                Console.WriteLine($"{player1.Name} perdeu! {player2.Name} venceu!");
                break;
            }
        }
    }
}
