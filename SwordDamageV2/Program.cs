using System;

namespace SwordDamageV2
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice());

            while (true)
            {
                Console.Write("0 for no ability, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                string userInput = Console.ReadLine();
                if (userInput != "0" && userInput != "1" && userInput != "2" && userInput != "3")
                {
                    return;
                }

                swordDamage.Roll = RollDice();
                swordDamage.Magic = (userInput == "1" || userInput == "3");
                swordDamage.Flaming = (userInput == "2" || userInput == "3");

                Console.WriteLine($"Rolled {swordDamage.Roll} for {swordDamage.Damage} HP\n");
            }
        }

        /// <summary>
        /// Simulated 3d6 dice roll.
        /// </summary>
        /// <returns>Combination of three random numbers (each 1-7)</returns>
        private static int RollDice()
        {
            return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
        }
    }
}
