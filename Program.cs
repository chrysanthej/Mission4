using Mission4;

Support s = new Support();

int input = 11;
bool win = false;
char player = ' ';
char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
bool playerXTurn = true;

Console.WriteLine("Welcome to TicTacToe!");


do
{
    // Display the current state of the board
    s.DrawBoard(board);

    if (playerXTurn)
    {
        player = 'X';
    }
    else
    {
        player = 'O';
    }

    // Ask user where they would like to go
    Console.WriteLine(player + "'s turn - which place would you like to go? (select numbers 1-9)");
    string userInput;

    // Get a valid input before entering the loop
    while (true)
    {
        userInput = Console.ReadLine();

        if (!int.TryParse(userInput, out input) || !s.ValidateInput(input, board))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        else
        {
            break;
        }
    }

    // Update the array
    board[(input - 1)] = player;

    // Check for a win
    win = s.CheckWinner(board, out player);

    if (!win)
    {
        playerXTurn = !playerXTurn;
    }

} while (!win);

// Display the final state of the board
s.DrawBoard(board);

// Declare the winner or tie
if (player != '\0')
{
    if (player == 'T')
    {
        Console.WriteLine("The game is a tie!");
    }
    else
    {
        Console.WriteLine("The winner is " + player);
    }
}




