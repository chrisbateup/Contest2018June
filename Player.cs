using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Survive the wrath of Kutulu
 * Coded fearlessly by JohnnyYuge & nmahoude (ok we might have been a bit scared by the old god...but don't say anything)
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        for (int i = 0; i < height; i++)
        {
            string line = Console.ReadLine();
        }
        inputs = Console.ReadLine().Split(' ');
        int sanityLossLonely = int.Parse(inputs[0]); // how much sanity you lose every turn when alone, always 3 until wood 1
        int sanityLossGroup = int.Parse(inputs[1]); // how much sanity you lose every turn when near another player, always 1 until wood 1
        int wandererSpawnTime = int.Parse(inputs[2]); // how many turns the wanderer take to spawn, always 3 until wood 1
        int wandererLifeTime = int.Parse(inputs[3]); // how many turns the wanderer is on map after spawning, always 40 until wood 1

        // game loop
        while (true)
        {
            int entityCount = int.Parse(Console.ReadLine()); // the first given entity corresponds to your explorer
            for (int i = 0; i < entityCount; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                string entityType = inputs[0];
                int id = int.Parse(inputs[1]);
                int x = int.Parse(inputs[2]);
                int y = int.Parse(inputs[3]);
                int param0 = int.Parse(inputs[4]);
                int param1 = int.Parse(inputs[5]);
                int param2 = int.Parse(inputs[6]);
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine("WAIT"); // MOVE <x> <y> | WAIT
        }
    }
}