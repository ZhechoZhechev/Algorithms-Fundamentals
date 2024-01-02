namespace TwentyOne;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добре дошли в играта 21 монети!");

        int coins = 21;

        while (coins > 0)
        {
            Console.WriteLine($"Оставащи монети: {coins}");

            int player1Move = ChoosePlayer1Move(coins);
            Console.WriteLine($"Играч 1 взима {player1Move} монети.");
            coins -= player1Move;

            if (coins == 0)
            {
                Console.WriteLine("Играч 1 печели!");
                break;
            }

            Console.WriteLine($"Оставащи монети: {coins}");

            int player2Move = ChoosePlayer2Move(coins);
            Console.WriteLine($"Играч 2 взима {player2Move} монети.");
            coins -= player2Move;

            if (coins == 0)
            {
                Console.WriteLine("Играч 2 печели!");
                break;
            }
        }
    }

    static int ChoosePlayer1Move(int remainingCoins)
    {
        return remainingCoins % 4 == 0 ? 1 : remainingCoins % 4;
    }

    static int ChoosePlayer2Move(int remainingCoins)
    {
        Random random = new Random();

        return remainingCoins >= 3 ? random.Next(1, 4) : random.Next(1, remainingCoins +1);
    }
}