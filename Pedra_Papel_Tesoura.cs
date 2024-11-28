using System;

class Program
{
    static void Main()
    {
        int playerScore = 0, computerScore = 0;

        while (playerScore < 2 && computerScore < 2)
        {
            Console.Clear();
            Console.WriteLine("Escolha: 1. Pedra  2. Papel  3. Tesoura");
            string input = Console.ReadLine();
            int playerChoice;

            // Valida a entrada do jogador
            if (!int.TryParse(input, out playerChoice) || playerChoice < 1 || playerChoice > 3)
            {
                Console.WriteLine("Escolha inválida! Tente novamente.");
                continue; // Volta para o início do loop
            }

            Random random = new Random();
            int computerChoice = random.Next(1, 4); // Gera 1, 2 ou 3

            Console.WriteLine($"Você escolheu: {playerChoice}, Computador escolheu: {computerChoice}");

            if (playerChoice == computerChoice)
            {
                Console.WriteLine("Empate!");
            }
            else if ((playerChoice == 1 && computerChoice == 3) || 
                     (playerChoice == 2 && computerChoice == 1) || 
                     (playerChoice == 3 && computerChoice == 2))
            {
                Console.WriteLine("Você ganhou esta rodada!");
                playerScore++;
            }
            else
            {
                Console.WriteLine("Computador ganhou esta rodada!");
                computerScore++;
            }

            Console.WriteLine($"Placar: Você {playerScore} - {computerScore} Computador");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        Console.Clear();
        if (playerScore == 2)
            Console.WriteLine("Você venceu o jogo!");
        else
            Console.WriteLine("Computador venceu o jogo!");
    }
}
