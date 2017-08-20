using System;

class Program
{
    static void Main(string[] args)
    {
        // delcare players
        string player1, player2;
        // flag to check if the game is over
        bool Done = false;
        // delaring players guess
        int Number;

        Console.Write("Player 1 Please enter your name :  ");
        player1 = Console.ReadLine();

        Console.Write("Player 2 Please enter your name :  ");
        player2 = Console.ReadLine();

        //new class instance
        Random RandomObj = new Random();

        // random naber gerneration
        int X = RandomObj.Next(200);

        // flagg to state which player makes a move
        string player = player1;

        while (!Done)
        {
            
            player = player == player1 ? player2 : player1;

            Console.WriteLine(player + ", Your Guess!");
            // należy przekonwertować tekst na liczbę
            Number = Convert.ToInt32(Console.ReadLine());

            if (X > Number)
            {
                Console.WriteLine("Try Higher!");
            }
            else if (X < Number)
            {
                Console.WriteLine("Try Lower!");
            }
            else
            {
                Console.WriteLine("Congrats: The winner is :  " + player);
                Console.Beep();

                Done = true;
            }
        }
        Console.Read();
    }
}
