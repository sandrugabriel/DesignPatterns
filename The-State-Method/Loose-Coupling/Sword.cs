using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    public class Sword : IWeapon
    {
        private int _damage;
        public int Damage {get =>_damage; set => _damage = value; }

        private int _armorDamage;
        
        public int ArmorDamage { get =>_armorDamage;}

        public Sword(int damage, int armor)
        {
            _armorDamage = armor;
            _damage = damage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.OvertimeDamage = ArmorDamage;
        }
    }
}
