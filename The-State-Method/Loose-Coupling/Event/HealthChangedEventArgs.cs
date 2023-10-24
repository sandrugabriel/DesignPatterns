using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling.Event
{
    public class HealthChangedEventArgs : EventArgs
    {
        public int Health { get; set; }

        public int Damage { get; set; }

        public HealthChangedEventArgs(int health)
        {
            Health = health;
        }


    }
}
