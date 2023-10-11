using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Factory_Pattern
{
    public class Zombie : IEnemy
    {

        private int _health;
        private readonly int _level;

        public int Health { get => _health; set => _health = value; }
        public int Level => _level;

        public Zombie(int health, int level)
        {
            _level = level;
            Health = health;
        }

        public void Attack(PrimaryPlayer player)
        {
            Console.WriteLine("Zombie attacking " + player.Name);
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine("Zombie defends from " + player.Name);
        }
    }
}
