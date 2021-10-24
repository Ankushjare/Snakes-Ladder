using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder1
{
    public class UC2
    {
        const int START_POISTION = 0;
        const int END_POSTION = 100;
        public static int currentPosition = 0;
        public int throwDice()
        {
            Random random = new Random();
            int number = random.Next(1, 7);
            Console.WriteLine("Current poistion is=" + number);
            return number;


        }
    }
}