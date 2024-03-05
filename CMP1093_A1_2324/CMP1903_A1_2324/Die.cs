using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CMP1903_A1_2324
{
    internal class Die
    {
        // Property to hold the current value of the die
        public int FaceValue { get; private set; }

        // Random number generator for rolling the die
        private Random random;

        // Constructor to initialize the random number generator and roll the die at the start
        public Die()
        {
            random = new Random();
            Roll();
        }

        // Method to roll the die
        public void Roll()
        {
            FaceValue = random.Next(1, 7); // Generates a random number from 1 to 6
        }
    }
}
