using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling.Battlefilds
{
    public class VocanoBattlefield : BattlefieldTemplate
    {
        public override string DescribeClimate()
        {
            return "There' s fog and dust everywhere. The haet melts the armor";
        }

        public override string DescribeEffects()
        {
            return "There are flames jumping from underneath";
        }

        public override string DescribeGround()
        {
            return "THe ground is is rocky";
        }
    }
}
