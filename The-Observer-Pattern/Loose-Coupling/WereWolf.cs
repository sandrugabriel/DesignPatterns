﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    public class WereWolf : IEnemy
    {
        private int _health;
        private readonly int _level;

        public int Health { get => _health; set => _health = value; }
        public int Level => _level;

        public WereWolf(int health, int level, int armor)
        {
            _level = level;
            Health = health;
            Armor = armor;
        }

        public int OvertimeDamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }
        public int Attack(PrimaryPlayer player)
        {
            Console.WriteLine("Zombie attacking " + player.Name);
            return 20;
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine("Zombie defends from " + player.Name);
        }

    }
}
