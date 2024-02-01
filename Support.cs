using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class Support
    {
        public bool ValidateInput(int input)
        {
            bool result = true; // Default to a valid guess

            if (input < 1 || input > 9)
            {
                Console.WriteLine("Sorry, you need to pick a number 1-9");
                result = false;
            }
            else if (!int.TryParse(input.ToString(), out _))
            {
                Console.WriteLine("Sorry, the input needs to be a valid integer");
                result = false;
            }

            return result;
        }
        public void DrawBoard(char[] board)
        {
            // Console.Clear();
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }
        
       

        public bool CheckWinner(char[] board, out char winner)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2] && board[i * 3] != ' ')
                {
                    winner = board[i * 3];
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i + 3] == board[i + 6] && board[i] != ' ')
                {
                    winner = board[i];
                    return true;
                }
            }

            // Check diagonals
            if (board[0] == board[4] && board[4] == board[8] && board[0] != ' ')
            {
                winner = board[0];
                return true;
            }

            if (board[2] == board[4] && board[4] == board[6] && board[2] != ' ')
            {
                winner = board[2];
                return true;
            }

            // No winner yet
            winner = '\0';
            return false;
        }
    }
}

