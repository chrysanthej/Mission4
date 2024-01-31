using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4
{
    internal class Support
    {

        public void DrawBoard(char[] board)
        {
            // Console.Clear();
            Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
            Console.WriteLine("-----------");
            Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
        }
        
        public void CheckWinner(char[] board)
        {

        }
    }
}
