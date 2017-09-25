using System;

namespace spil
{
    public class TicTacToeMenu
    {
        TicTacToe ticTacToe {get; set;}
        public void Show()
        {
            int menuChoice = 0;
            string input = "";
            do
            {
                Console.Clear();
                Console.WriteLine("tic tac toe");
                Console.WriteLine();
                Console.WriteLine("1. Oret nyt spil");

                Console.WriteLine("0. exit");

                Console.Write("Indtast dit valg: ");
                input = Console.ReadLine();
                int.TryParse(input,out menuChoice);

                switch (menuChoice)
                {
                    case 0:
                        break;
                    case 1:
                        ExecuteMenuChoice1();
                        break;
                    case 2:
                        ExecuteMenuChoice1();
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        Console.ReadLine();
                        break;
                }

            } while (menuChoice > 0);

        }

        private void ExecuteMenuChoice1()
        {
            Console.WriteLine("skriv koden til at opret nyt spil");
            Console.ReadLine();
        }
    }
}