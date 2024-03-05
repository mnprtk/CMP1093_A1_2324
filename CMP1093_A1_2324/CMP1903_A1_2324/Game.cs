using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private Die[] dice;

        // Constructor to create three die objects
        public Game()
        {
            dice = new Die[3];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }

        // Method to roll all dice and calculate the sum, reporting the total
        public int RollAndReportTotal()
        {
            int total = 0;
            foreach (Die die in dice)
            {
                die.Roll(); // Roll each die
                total += die.FaceValue; // Calculate the total sum
            }
            return total;
        }
    }
}