using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    public class EnemyFactory
    {
        private int _areaLevel;
        private Stack<Zombie> _zombiePool = new Stack<Zombie>();
        private Stack<WereWolf> _wolfPool = new Stack<WereWolf>();
        private Stack<Giant> _giantPool = new Stack<Giant>();
        private object thorw;

        private void PreLoadZombies()
        {
            int count;
            int health;
            int armor;
            int level;

            if (_areaLevel < 3)
            {
                count = 15;
            }
            else if (_areaLevel >=3 && _areaLevel < 10)
            {
                count = 50; 


            }
            else
            {
                count = 200;


            }
                (health, level, armor) = GetZombieStatus(_areaLevel);

            for (int i=0;i< count;i++)
            {
                _zombiePool.Push(new Zombie(health, armor, level));
            }
        }

        private void PreLoadWereWolf()
        {
            int count;
            int health;
            int armor;
            int level;

            if (_areaLevel < 3)
            {
                count = 15;

            }
            else if (_areaLevel >= 3 && _areaLevel < 10)
            {
                count = 50;


            }
            else
            {
                count = 200;


            }
                (health, level, armor) = GetWolfStatus(_areaLevel);

            for (int i = 0; i < count; i++)
            {
                _wolfPool.Push(new WereWolf(health, armor, level));
            }
        }

        private void PreLoadGiant()
        {
            int count;
            int health;
            int armor;
            int level;

            if (_areaLevel < 3)
            {
                count = 15; 

            }
            else if (_areaLevel >= 3 && _areaLevel < 10)
            {
                count = 50;


            }
            else
            {
                count = 200;


            }
                (health, level, armor) = GetGiantStatus(_areaLevel);

            for (int i = 0; i < count; i++)
            {
                _giantPool.Push(new Giant(health, armor, level));
            }
        }

        public int AreaLevel {  get { return _areaLevel; } set {  _areaLevel = value; } }

        private (int health,int level,int armor) GetZombieStatus(int arlvl)
        {
            int health, level, armor;
            if (arlvl < 3)
            {
                health = 66;
                armor = 15;
                level = 2;
            }
            else if (arlvl >= 3 && arlvl < 10)
            {
                health = 100;
                armor = 15;
                level = 5;

            }
            else
            {
                health = 120;
                armor = 15;
                level = 8;

            }
            return(health,level, armor);
        }

        private (int health, int level, int armor) GetGiantStatus(int arlvl)
        {
            int health, level, armor;
            if (arlvl < 3)
            {
                health = 66;
                armor = 15;
                level = 2;
            }
            else if (arlvl >= 3 && arlvl < 10)
            {
                health = 100;
                armor = 15;
                level = 5;

            }
            else
            {
                health = 120;
                armor = 15;
                level = 8;

            }
            return (health, level, armor);
        }

        private (int health, int level, int armor) GetWolfStatus(int arlvl)
        {
            int health, level, armor;
            if (arlvl < 3)
            {
                health = 66;
                armor = 15;
                level = 2;
            }
            else if (arlvl >= 3 && arlvl < 10)
            {
                health = 100;
                armor = 15;
                level = 5;

            }
            else
            {
                health = 120;
                armor = 15;
                level = 8;

            }
            return (health, level, armor);
        }

        public void ReclaimZombie(Zombie zombie)
        {
            (int health, int level, int armor) = GetZombieStatus(_areaLevel);
            zombie.Health = health;
            zombie.Armor = armor;
            _zombiePool.Push(zombie);
        }

        public EnemyFactory(int area)
        {   
            _areaLevel = area;
            PreLoadGiant();
            PreLoadWereWolf();
            PreLoadZombies();
        }

        public Zombie SpawnZombie(int areaLevel)
        {
            if (_zombiePool.Count>0)
            {
                return _zombiePool.Pop();
            }
            else
            {
                throw new Exception("Zombies pool depleted");
            }
        }

        public WereWolf SpawnWereWolf(int areaLevel)
        {
            if (areaLevel < 8)
            {
                return new WereWolf(100, 16,15);
            }
            else
            {
                return new WereWolf(100, 25,15);
            }

        }

        public Giant SpawnGiant(int areaLevel)
        {
            if (areaLevel < 12)
            {
                return new Giant(100, 16,15);
            }
            else
            {
                return new Giant(100, 25,15);
            }

        }

    }
}
