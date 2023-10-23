using MilkyWayponLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling.Adapters
{
    public class WeaponAdapter : IWeapon
    {

        private ISpaceWeapon _sWeapon;

        public WeaponAdapter(ISpaceWeapon spaceWeapon) {
            _sWeapon = spaceWeapon;
        }

        public int Damage { get => _sWeapon.ImpactDamage + _sWeapon.LaserDamage; set
            {
                ISpaceWeapon spaceWeapon = _sWeapon;
            }
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= _sWeapon.Shoot();
        }
    }
}
