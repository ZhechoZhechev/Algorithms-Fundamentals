namespace JumpingPawns;

public class Program
{
    static string GetWinner(char[,] board)
    {
        int numRows = board.GetLength(0);
        int numCols = board.GetLength(1);
        int sum = 0;

        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                if (board[row, col] == 'X')
                {
                    sum += numRows - row + numCols - col;
                }
            }
        }

        return sum % 2 == 0 ? "Kriss" : "Elly";
    }

    public static void Main()
    {
        char[,] gameBoard = new char[,]
        {
            { '.', 'X', '.', '.' },
            { '.', '.', '.', '.' },
            { '.', '.', '.', '.' },
            { '.', '.', '.', '.' }
        };

        string winner = GetWinner(gameBoard);
        Console.WriteLine($"The winner is: {winner}");
    }
}
