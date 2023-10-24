using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    public class IceStaff : IWeapon
    {

        private int _damage;
        public int Damage { get => _damage; set => _damage = value; }

        private int _paralyzedFor;

        public IceStaff(int damage, int paralyzed)
        {
            _paralyzedFor = paralyzed;
            _damage = damage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.Paralyzed = true;
        }

    }
}
