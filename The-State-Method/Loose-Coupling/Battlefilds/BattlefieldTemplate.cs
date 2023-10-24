using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling.Battlefilds
{
    public abstract class BattlefieldTemplate
    {

        public string DescribeSky()
        {
            return "The Battlefield sky is blue";
        }

        public abstract string DescribeGround();

        public abstract string DescribeClimate();

        public abstract string DescribeEffects();

        public string Describe()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DescribeSky());
            sb.Append("\n");
            sb.Append(DescribeGround);
            sb.Append("\n");
            sb.Append(DescribeClimate());
            sb.Append("\n");
            sb.Append(DescribeEffects());

            return sb.ToString();
        }
    }
}
