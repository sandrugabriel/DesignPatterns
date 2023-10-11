using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Factory_Pattern
{
    public class EnemyFactory
    {

        public static Zombie SpawnZombie(int areaLevel)
        {
            if(areaLevel < 5)
            {
                return new Zombie(100, 12);
            }
            else
            {
                return new Zombie(100, 20);
            }
        }

        public static WereWolf SpawnWereWolf(int areaLevel)
        {
            if (areaLevel < 8)
            {
                return new WereWolf(100, 16);
            }
            else
            {
                return new WereWolf(100, 25);
            }

        }

        public static Giant SpawnGiant(int areaLevel)
        {
            if (areaLevel < 12)
            {
                return new Giant(100, 16);
            }
            else
            {
                return new Giant(100, 25);
            }

        }

    }
}
