using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder1
{
    public class UC4
    {
        const int START_POSITION = 0;
        const int END_POSITION = 100;
        public static int currentPosition = 0;
        public static int selectedOption = 0;
        static Random random = new Random();
        public int throwDice()
        {
            return random.Next(1, 7);
        }

        public int checkForOption()
        {
            return random.Next(1, 4);
        }

        public int playerOption()
        {
            while (currentPosition < END_POSITION - 1)
            {
                int throwDices = throwDice();
                int selectedOption = checkForOption();
                if (selectedOption == 1)
                {
                    currentPosition += throwDices;
                    Console.WriteLine("Your position is : " + currentPosition);
                }
                else if (selectedOption == 2)
                {
                    currentPosition -= throwDices;
                    if (currentPosition < 0)
                    {
                        currentPosition = START_POSITION;
                        Console.WriteLine("Your position is : " + currentPosition);
                    }
                }
                else
                {
                    Console.WriteLine("Do nothing player stay in same position");
                }
            }
            return currentPosition;
        }
    }
}
