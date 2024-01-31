// Description: TicTacToe game, taking user input to play the game
// Authors: Kian Bangerter, Chrysanthe Belgique, Lorin Costley, Ryan Hafen
using Mission4;

Support s = new Support();

char position = ' ';
string input = "";
bool winner = false;
char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

Console.WriteLine("Welcome to TicTacToe!");

s.DrawBoard(board);

do
{
    // Ask user where they would like to go
    Console.WriteLine("x's turn - which place would you like to go? (select numbers 1-9");
    input = Console.ReadLine();

    // Validate the play
    

    // Update the array
    board[position] = 'x';

    // Pass the array back to PrintBoard

    // Check for a win

} while (!winner);

