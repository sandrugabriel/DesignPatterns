using Built_in_ASP_IoC_Container;
using Loose_Coupling.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    public class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;

        private int _health;
        private PrimaryPlayer() { }

        public IWeapon Weapon { get; set; }

        public Card[] Cards { get; set; }

        private event EventHandler<HealthChangedEventArgs> HealthChanged;

        public void RegisterObserver(EventHandler<HealthChangedEventArgs> handler)
        {
            HealthChanged += handler;
        }

        public void UnregisterObserver(EventHandler<HealthChangedEventArgs> eventHandler)
        {
            HealthChanged -= eventHandler;
        }

        static PrimaryPlayer()
        {
            _instance = new PrimaryPlayer()
            {
                Name = "Raptor",
                Level = 1,
                Armor = 25,
                Health = 100
            };
        }

        public static PrimaryPlayer Instance
        {
            get
            {
                return _instance;
            }
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Armor { get; set; }
        public int Health
        {
            get { return _health; }

            set
            {
                _health = Health;
                if (HealthChanged != null)
                {
                    HealthChanged(this, new HealthChangedEventArgs(Health));
                }
            }
        }

        public void Hit(int damage)
        {
            Health -= damage;
        }
    }
}
