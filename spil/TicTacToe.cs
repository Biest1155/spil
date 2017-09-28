using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class TicTacToe
    {
        public char[,] GameBoard { get; set; }
        public TicTacToe()
        {
            GameBoard = new char[3, 3] { {' ', ' ', ' '},
                {' ', ' ', ' '},
                { ' ', ' ', ' '} };
        }

        public string GetGameBoardView()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoard[0, 2] + "  *  " + GameBoard[1, 2] + "  *  " + GameBoard[2, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoard[0, 1] + "  *  " + GameBoard[1, 1] + "  *  " + GameBoard[2, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoard[0, 0] + "  *  " + GameBoard[1, 0] + "  *  " + GameBoard[2, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "     1     2     3    X\n";

            return resultat;
        }

        public char Validate()
        {

            char resultat = ' ';

            // for-loop [0,i] i<3; i++  (Provided af Jepser)
            // plads 1 == plads 2 && plads 2 == plads 3 && plads 3 != " "

            for (int i = 0; i < 3; i++)
            {
                if (GameBoard[i, 2] == GameBoard[i, 2] && GameBoard[i, 2] == GameBoard[i, 2] && GameBoard[i, 2] != ' ')
                {
                    char tegn = GameBoard[i, 2];
                    Console.WriteLine("WINNER is {0}",tegn);
                }

                if(GameBoard[0, i] == GameBoard[1, i] && GameBoard[1, i] == GameBoard[2, i] && GameBoard[2, i] != ' ')
                {
                    char tegn = GameBoard[1, i];
                    Console.WriteLine("WINNER is {0}",tegn);
                }

                if ((GameBoard[0, 2] == 'x') && (GameBoard[1, 1] == 'x') && (GameBoard[2, 0] == 'x'))
                {
                    Console.WriteLine("WINNER is X");
                }

                if ((GameBoard[0, 2] == 'o') && (GameBoard[1, 1] == 'o') && (GameBoard[2, 0] == 'o'))
                {
                    Console.WriteLine("WINNER is O");
                }

                if ((GameBoard[2, 2] == 'x') && (GameBoard[1, 1] == 'x') && (GameBoard[0, 0] == 'x'))
                {
                    Console.WriteLine("WINNER is X");
                }

                if ((GameBoard[2, 2] == 'o') && (GameBoard[1, 1] == 'o') && (GameBoard[0, 0] == 'o'))
                {
                    Console.WriteLine("WINNER is O");
                }
            }

           
            return resultat;
        }

        
        public void SætEnBrik(int v, int p, int player)
        {
            char tegn = ' ';

            if (player == 1)
            {
                tegn = 'x';
            }
            else if (player == 2)
            {
                tegn = 'o';
            }
                       
             
            GameBoard[v, p] = tegn;
                      

            // her kan implementeres metoder til at sætte og flytte en brik


        }

        



    }
}
