using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling.Commands
{
    public class PlayerEnemyBattleCommand : ICommand
    {
        private PrimaryPlayer _primaryPlayer;
        private IEnemy _enemy;

        public PlayerEnemyBattleCommand(PrimaryPlayer primaryPlayer, IEnemy enemy)
        {
            _primaryPlayer = primaryPlayer;
            _enemy = enemy;
        }

        public void Execute()
        {
            PlayerAttacks();
            if(_enemy != null)
            {
                EnemyAttacks();
            }
        }

        private void PlayerAttacks()
        {
            _primaryPlayer.Weapon.Use(_enemy);
        }

        private void EnemyAttacks()
        {
            int damage = _enemy.Attack(_primaryPlayer);
            _primaryPlayer.Hit(damage);
        }

    }
}
