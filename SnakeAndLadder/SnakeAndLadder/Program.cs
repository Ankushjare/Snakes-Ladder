using System;

namespace SnakeAndLadder
{
    class Program
    {
        // const int START_POSITION = 0;
        // public static int selectedOption = 0;
        public static int currentPosition = 1;
        const int WIN_POSITION = 100;
        //const int END_POSITION = 100;
        static Random random = new Random();

        public static int throwDice()
        {
            return random.Next(1, 7);
        }

        public static int checkForOption()
        {
            return random.Next(1, 4);
        }

        static void Main(string[] args)
        {
            int RollDiceCount = 0;
            while (currentPosition < WIN_POSITION)
            {
                int throwDices = throwDice();
                RollDiceCount++;
                int selectedOption = checkForOption();
                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("Player got ladder");
                        currentPosition += throwDices;
                        if (currentPosition > WIN_POSITION)
                        {
                            currentPosition -= throwDices;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Player got snake");
                        if ((currentPosition - throwDices) < 0)
                        {
                            currentPosition = 0;
                        }
                        else
                        {
                            currentPosition -= throwDices;
                        }
                        break;
                    case 3:
                        Console.WriteLine("player not play");
                        break;
                    default:
                        break;
                }

                if (currentPosition == WIN_POSITION)
                {
                    Console.WriteLine("Player won!");
                    Console.WriteLine("number of dice was played by player for win the game is" + RollDiceCount);
                    break;
                }
            }
        }

    }
}