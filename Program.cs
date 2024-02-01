// Description: TicTacToe game, taking user input to play the game
// Authors: Kian Bangerter, Chrysanthe Belgique, Lorin Costley, Ryan Hafen
using Mission4;

Support s = new Support();

int input = 11;
bool win = false;
char player = ' ';
char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
bool playerXTurn = true;

Console.WriteLine("Welcome to TicTacToe!");

s.DrawBoard(board);

do
{
    if(playerXTurn == true)
    {
        player = 'X';
    }
    else if(playerXTurn == false)
    {
        player = 'O';
    }

    // Ask user where they would like to go
    Console.WriteLine("X's turn - which place would you like to go? (select numbers 1-9)");
    do
    {
        input = int.Parse(Console.ReadLine());
    }while(!s.ValidateInput(input)); // Validate the play

    // Update the array
    board[(input - 1)] = player;

    // Pass the array back to PrintBoard
    s.DrawBoard(board);

    // Check for a win
    win = s.CheckWinner(board, out player);

    if(win == false)
    {
        playerXTurn = !playerXTurn;
    }

} while (!win);

// Declare the winner
Console.WriteLine("The winner is " + player);