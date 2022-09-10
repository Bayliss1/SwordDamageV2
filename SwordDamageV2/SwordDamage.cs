using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamageV2
{
    class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        
        public int Damage { get; private set; }

        private int roll;
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        private int flaming;
        public int Flaming
        {
            get { return Flaming; }
            set
            {
                flaming = value; 
                CalculateDamage();
            }
        }

        private int magic;
        public int Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        public void CalculateDamage()
        {
            Damage = (int)(Roll * Magic) + BASE_DAMAGE + Flaming;
        }
    }
}
