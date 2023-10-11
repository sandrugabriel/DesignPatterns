using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Factory_Pattern
{
    public class GameBoard
    {

        private PrimaryPlayer _player;

        public GameBoard() {

            _player = PrimaryPlayer.Instance;
        
        }

        public void PlayArea(int lvl)
        {
            if(lvl == 1)
            {
                PlayFistLevel();
            }
        }

        public void PlayFistLevel()
        {
            int lvl = 1;
            List<IEnemy> enemies = new List<IEnemy>();

            for(int i = 0; i < 10; i++)
            {
                enemies.Add(EnemyFactory.SpawnZombie(lvl));
            }

            for (int i = 0; i < 3; i++)
            {
                enemies.Add(EnemyFactory.SpawnWereWolf(lvl));
            }

            foreach(var enemy in enemies) {

                Console.WriteLine(enemy.GetType());
            }

        }
    }
}
