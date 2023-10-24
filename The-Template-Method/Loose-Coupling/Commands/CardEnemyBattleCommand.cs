using Built_in_ASP_IoC_Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling.Commands
{
    public class CardEnemyBattleCommand : ICommand
    {

        private Card _card;

        private IEnemy enemy;

        public CardEnemyBattleCommand(Card card, IEnemy enemy)
        {
            _card = card;
            this.enemy = enemy;
        }

        public void Execute()
        {
            enemy.Health -= _card.Attack;

        }
    }
}
