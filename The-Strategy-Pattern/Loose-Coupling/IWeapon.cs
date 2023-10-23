using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    public interface IWeapon
    {
        int Damage {  get; set; }
        void Use(IEnemy enemy);

    }
}
