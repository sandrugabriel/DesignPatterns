using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    public class FireStaff : IWeapon
    {

        private int _damage;
        public int Damage { get => _damage; set => _damage = value; }

        private int _fireDamage;

        public FireStaff(int damage, int fire)
        {
            _fireDamage = fire;
            _damage = damage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.OvertimeDamage = _fireDamage;
        }

    }
}
