string[] options = { "rock", "paper", "scissors" };
int score = 0;
int roundsPlayed = 0;
Random random = new Random();

while (true)
{
    Console.WriteLine("Rock, paper, or scissors?");
    string playerChoice = "";
    while (string.IsNullOrWhiteSpace(playerChoice))
    {
        playerChoice = Console.ReadLine()!;
        if (string.IsNullOrWhiteSpace(playerChoice))
        {
            Console.WriteLine("You must enter a value!");
            Console.WriteLine("Rock, paper, or scissors?");
        }
    }
    playerChoice = playerChoice.ToLower();
    string computerChoice = options[random.Next(options.Length)];

    // handle comparisons
    if (playerChoice == "rock")
    {
        if (computerChoice == "rock") Console.WriteLine("Computer chose rock. It's a tie!");
        else if (computerChoice == "paper") Console.WriteLine("Computer chose paper. You lose!");
        else { Console.WriteLine("Computer chose scissors. You win!"); score++; }
        roundsPlayed++;
    }
    else if (playerChoice == "paper")
    {
        if (computerChoice == "rock") { Console.WriteLine("Computer chose rock. You win!"); score++; }
        else if (computerChoice == "paper") Console.WriteLine("Computer chose paper. It's a tie!");
        else Console.WriteLine("Computer chose scissors. You lose!");
        roundsPlayed++;
    }
    else if (playerChoice == "scissors")
    {
        if (computerChoice == "rock") Console.WriteLine("Computer chose rock. You lose!");
        else if (computerChoice == "paper") { Console.WriteLine("Computer chose paper. You win!"); score++; }
        else Console.WriteLine("Computer chose scissors. It's a tie!");
        roundsPlayed++;
    }
    else
    {
        Console.WriteLine("That's not a valid play. Check your spelling!");
    }

    // ask to play again
    Console.WriteLine("Do you want to play again? (y/n)");
    if (!Console.ReadLine()!.Equals("y", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"You played {roundsPlayed} rounds and got {score} points!");
        break;
    }
}
