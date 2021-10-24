using System;

namespace SnakeAndLadder
{
    class Program
    {
        const int START_POISTION = 0;
        const int END_POSTION = 100;
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
            int throwDices = throwDice();
            int selectedOption = checkForOption();
            if (selectedOption == 1)
            {
                currentPosition += throwDices;
            }
            else if (selectedOption == 2)
            {
                currentPosition -= throwDices;

            }
            else
            {
                Console.WriteLine("Do nothing player stay in same position");
            }
            return currentPosition;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome message");
            currentPosition += throwDice();
            Console.WriteLine("start position is: " + START_POISTION);
            Console.WriteLine("end position is: " + END_POSTION);
            Console.WriteLine("current position is= " + playerOption());
        }

    }
}