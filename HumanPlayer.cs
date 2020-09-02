using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Your Turn!");
            Console.Write($"Enter a number between 1 and {DiceSize}: ");
            string strInput = Console.ReadLine();
            int Input = Int32.Parse(strInput);
            // Return a random number between 1 and DiceSize
            return Input;
        }
    }
}