using System;

namespace spil
{
    public class TicTacToeMenu
    {
        TicTacToe ticTacToe {get; set; }
        public void Show()
        {
            bool running = true;            
            string choice = "";
            do
            {
                ShowMenu();
                choice = GetUserChoice();
                switch (choice)
                {
                    case "1": DoActionFor1(); break;
                    case "2": DoActionFor2(); break;
                    case "3": DoActionFor3(); break;
                    case "0": running = false; break;
                    default : ShowMenuSelectionError(); break;
                }
            } while (running);
        }

        private void ShowMenu()
        {
            Console.Clear();
            if (ticTacToe != null)
            {
                
                Console.WriteLine(ticTacToe.GetGameBoardView());
            }
            
            Console.WriteLine("Tic Tac Toe");
            Console.WriteLine();
            Console.WriteLine("1. Opret nyt spil");
            Console.WriteLine("2. Sæt en brik");
            Console.WriteLine("3. Flyt en brik");
            Console.WriteLine();
            Console.WriteLine("0. Exit");
            
        }

        private string GetUserChoice()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }

        private void ShowMenuSelectionError()
        {
            Console.WriteLine("Ugyldigt valg.");
            Console.ReadLine();
        }

        private void DoActionFor1() //Opret nyt spil og slet det gamle.
        {
            ticTacToe = new TicTacToe();
            

            
        }
        private void DoActionFor2()
        {
           
            Console.WriteLine("Indtast hvilken spiller der skal tage sit træk");
            string players = Console.ReadLine();
            int player = Convert.ToInt32(players);

            Console.WriteLine("Indstast nummer på x-akslen");

            string vr = Console.ReadLine();
            int v = Convert.ToInt32(vr);
            v = v - 1;


            Console.WriteLine("Indstast nummer på y-akslen");

            string pr = Console.ReadLine();
            int p = Convert.ToInt32(pr);
            p = p - 1;
            ticTacToe.SætEnBrik(v, p, player);

            

            //Console.WriteLine(ticTacToe.Validate());
                    
        }
        private void DoActionFor3()
        {
            
            Console.WriteLine("skriv koden til at få spillerens input til at flytte en brik");
            Console.ReadLine();
        }
    }
}