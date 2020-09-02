using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
        List<string> Taunts = new List<string>()
        {
            "Your Mother was a hamster!",
            "Your Father Smelt of elderberries!",
            "We've Already Got one!"

        };
        public string SelectTaunt()
        {
            int randomTauntInt = new Random().Next(Taunts.Count);
            // Console.WriteLine(Taunts[randomTauntInt]);
            return Taunts[randomTauntInt];
        }
    }
}