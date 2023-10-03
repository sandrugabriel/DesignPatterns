using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Singleton_Pattern.Ex1
{
    public sealed class WeldingArmPoolSingleton
    {
        private static WeldingArmPoolSingleton _instance;
        private int _maxSize = 10;

        private WeldingArmPoolSingleton(){ }

        public static WeldingArmPoolSingleton Instance
        {
            get
            {
                if (_instance == null) _instance = new WeldingArmPoolSingleton();
                return _instance;
            }
        }
    }

}
