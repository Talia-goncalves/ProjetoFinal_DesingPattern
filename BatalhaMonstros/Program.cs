using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando os monstros
        Monster dragon = new Monster("Dragão", 100, 3, 15, 5, "Sopro de Fogo");
        Monster goblin = new Monster("Goblin", 60, 2, 10, 3, "Golpe Esmagador");
        Monster titan = new Monster("Titã", 120, 4, 18, 6, "Pisada Sísmica");

        // Seleção de monstros pelos jogadores
        Console.WriteLine("Jogador 1, escolha seu monstro:");
        Console.WriteLine("1. Dragão");
        Console.WriteLine("2. Goblin");
        Console.WriteLine("3. Titã");
        string choice1 = Console.ReadLine();
        Monster chosenMonster1 = choice1 switch
        {
            "1" => dragon,
            "2" => goblin,
            "3" => titan,
            _ => dragon // Escolha padrão se a entrada for inválida
        };

        Console.WriteLine("Jogador 2, escolha seu monstro:");
        Console.WriteLine("1. Dragão");
        Console.WriteLine("2. Goblin");
        Console.WriteLine("3. Titã");
        string choice2 = Console.ReadLine();
        Monster chosenMonster2 = choice2 switch
        {
            "1" => dragon,
            "2" => goblin,
            "3" => titan,
            _ => dragon // Escolha padrão se a entrada for inválida
        };

        // Criando os jogadores
        Player player1 = new Player("Jogador 1", chosenMonster1);
        Player player2 = new Player("Jogador 2", chosenMonster2);

        // Inicializando o jogo
        Game game = new Game(player1, player2);
        game.Start();

        Console.WriteLine("Fim de jogo.");
    }
}
