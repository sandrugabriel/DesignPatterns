﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    public class GameBoard
    {

        private PrimaryPlayer _player;

        public GameBoard()
        {

            _player = PrimaryPlayer.Instance;
            _player.Weapon = new Sword(12, 8);
        }

        public void PlayArea(int lvl)
        {
            if (lvl == 1)
            {
                PlayFistLevel();
            }
        }

        public void PlayFistLevel()
        {
            int lvl = 1;
            EnemyFactory factory = new EnemyFactory(lvl);
            List<IEnemy> enemies = new List<IEnemy>();

            for (int i = 0; i < 10; i++)
            {
                enemies.Add(factory.SpawnZombie(lvl));
            }

            for (int i = 0; i < 3; i++)
            {
                enemies.Add(factory.SpawnWereWolf(lvl));
            }

            foreach (var enemy in enemies)
            {

                while(enemy.Health > 0 || _player.Health > 0)
                {
                    _player.Weapon.Use(enemy);
                    enemy.Attack(_player);
                }
            }

        }
    }
}
