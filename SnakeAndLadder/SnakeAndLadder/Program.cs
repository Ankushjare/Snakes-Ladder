using System;

namespace SnakeAndLadder
{
    class Program
    {
        const int START_POSITION = 0;
        const int END_POSITION = 100;
        public static int currentPosition = 0;
        public static int selectedOption = 0;
        static Random random = new Random();
        public static int throwDice()
        {
            return random.Next(1, 7);
        }

        public static int checkForOption()
        {
            return random.Next(1, 4);
        }

        public static int playerOption()
        {
            while (currentPosition < END_POSITION - 1)
            {
                int throwDices = throwDice();
                int selectedOption = checkForOption();
                if (selectedOption == 1)
                {
                    currentPosition += throwDices;
                }
                else if (selectedOption == 2)
                {
                    currentPosition -= throwDices;
                    if (currentPosition < 0)
                    {
                        currentPosition = START_POSITION;
                    }
                }
                else
                {
                    Console.WriteLine("Do nothing player stay in same poistion");
                }
            }
            return currentPosition;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("start postion is: " + START_POSITION);
            Console.WriteLine("end postion is: " + END_POSITION);
            Console.WriteLine("current poistion is= " + playerOption());
        }
    }
}