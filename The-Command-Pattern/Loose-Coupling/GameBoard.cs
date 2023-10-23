using Loose_Coupling.Adapters;
using Loose_Coupling.Facades;
using MilkyWayponLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    public class GameBoard
    {
        private GameBoardFacade _boardFacade;
        private PrimaryPlayer _player;

        public GameBoard()
        {

            _player = PrimaryPlayer.Instance;
            _player.Weapon = new Sword(12, 8);
            _boardFacade = new GameBoardFacade();
        }

        public void PlayArea(int lvl)
        {
             if (lvl == -1)
            {
                Console.WriteLine("Play special level?");
                PlaySpecialLevel();
            }
            else
            {
                _boardFacade.PlayAsync(_player,lvl);
            }
        }

        private void PlaySpecialLevel()
        {
            // _player.Weapon = new Blaster(20, 15, 15); - nu se poate
            _player.Weapon = new WeaponAdapter(new Blaster(20, 15, 15));
        }

    }
}
