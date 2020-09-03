using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining players
            SmackTalkingPlayer Buba = new SmackTalkingPlayer();
            Buba.Name = "Bubba";
            Buba.Taunt = "BOOOOOO!!!!";
            SmackTalkingPlayer Bobly = new SmackTalkingPlayer();
            Bobly.Name = "Bobbily";

            UpperHalfPlayer pierre = new UpperHalfPlayer();
            pierre.Name = "Pierre Artoise";
            OneHigherPlayer lucky = new OneHigherPlayer();
            lucky.Name = "Lucky MacDucky";
            CreativeSmackTalkingPlayer Frenchie = new CreativeSmackTalkingPlayer();
            Frenchie.Name = "Hercule";
            Frenchie.Taunt = Frenchie.SelectTaunt();

            SoreLoserPlayer steve = new SoreLoserPlayer();
            steve.Name = "steve";

            SoreLoserUpperHalfPlayer stephan = new SoreLoserUpperHalfPlayer();
            stephan.Name = "stephan Artoise";

            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            Player player3 = new Player();
            player3.Name = "Wilma";

            HumanPlayer user1 = new HumanPlayer();
            Console.Write("What's your name? ");
            user1.Name = Console.ReadLine();

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            //pierre.Play(Buba);

            //lucky.Play(Buba);

            // Frenchie.Play(Buba);

            //Bobly.Play(user1);

            //stephan.Play(Bobly);

            //steve.Play(Frenchie);

            // player2.Play(player1);
            // Buba.Play(player1);

            Console.WriteLine("-------------------");

            // player3.Play(player2);

            Console.WriteLine("-------------------");

            // player1.Play(large);

            Console.WriteLine("-------------------");

            // stephan.Play(user1);

            List<Player> players = new List<Player>()
            {
                player1,
                player2,
                player3,
                Buba,
                Bobly,
                large,
                stephan,
                steve,
                Frenchie,
                pierre,
                lucky,
                user1
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}