﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    public class Giant : IEnemy
    {

        private int _health;
        private readonly int _level;

        public int Health { get => _health; set => _health = value; }
        public int Level => _level;

        public int OvertimeDamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }
        public Giant(int health, int level, int armor)
        {
            _level = level;
            Health = health;
            Armor = armor;
        }

        public int Attack(PrimaryPlayer player)
        {
            Console.WriteLine("Giant attacking " + player.Name);
            return 50;
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine("Giant defends from " + player.Name);
        }

    }
}
