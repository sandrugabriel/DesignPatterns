using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling.Battlefilds
{
    public class SnowyBattleffield : BattlefieldTemplate
    {
        public override string DescribeClimate()
        {
            return "It's cold";
        }

        public override string DescribeEffects()
        {
            return "The snow makes it hard to see far away";
        }

        public override string DescribeGround()
        {
            return "The ground is covered in snow";
        }
    }
}
