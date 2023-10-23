using Built_in_ASP_IoC_Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    public class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instante;

        private PrimaryPlayer() { }

        public IWeapon Weapon { get; set; }

        static PrimaryPlayer()
        {
            _instante = new PrimaryPlayer();
        }

        public static PrimaryPlayer Instance { get { return _instante; } }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Armor {  get; set; }
        public int Health {  get; set; }

        public Card[] Cards { get; set; }
    }
}
