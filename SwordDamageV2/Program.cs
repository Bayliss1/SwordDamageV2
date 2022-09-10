using System;

namespace SwordDamageV2
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            Random random = new Random();

            while (true)
            {
                Console.Write("0 for no ability, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                string userInput = Console.ReadLine();
                if (userInput != "0" && userInput != "1" && userInput != "2" && userInput != "3")
                {
                    return;
                }

                int i;
                for (i = 1; i < 4; i++)
                {
                    swordDamage.Roll = random.Next(1, 7) + swordDamage.Roll;
                }

                swordDamage.SetMagic(userInput == "1" || userInput == "3");
                swordDamage.SetFlaming(userInput == "2" || userInput == "3");

                Console.WriteLine("Rolled " + swordDamage.Roll + " for " + swordDamage.Damage + " HP\n");
            }
        }
    }
}
