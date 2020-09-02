using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; } = "You are not good at most things, including this";

        public override int Roll()
        {
            Console.Write($"{Name} sayeth: {Taunt}");
            Console.WriteLine();
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}