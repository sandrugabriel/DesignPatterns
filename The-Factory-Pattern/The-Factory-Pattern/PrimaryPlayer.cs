using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Factory_Pattern
{
    public class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instante;

        private PrimaryPlayer() { }

        static PrimaryPlayer()
        {
            _instante = new PrimaryPlayer();
        }

        public static PrimaryPlayer Instance { get { return _instante; } }

        public string Name { get; set; }
        public int Level {  get; set; }

    }
}
