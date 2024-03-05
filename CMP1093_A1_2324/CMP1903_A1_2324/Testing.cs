using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


   namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // Method to test the Game class
        public void TestGame()
        {
            Game game = new Game();
            int total = game.RollAndReportTotal();

            // Assert that the total is between 3 and 18 (inclusive)
            Debug.Assert(total >= 3 && total <= 18, "Unexpected total value.");
        }

        // Method to test the Die class
        public void TestDie()
        {
            Die die = new Die();
            die.Roll();

            // Assert that the face value is between 1 and 6 (inclusive)
            Debug.Assert(die.FaceValue >= 1 && die.FaceValue <= 6, "Unexpected die face value.");
        }

        // Main method to run the tests
        public void RunTests()
        {
            TestGame();
            TestDie();

            Console.WriteLine("Tests completed successfully.");
        }
    }
}