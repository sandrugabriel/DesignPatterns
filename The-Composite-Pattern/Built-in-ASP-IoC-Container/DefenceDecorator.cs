using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_in_ASP_IoC_Container
{
    public class DefenceDecorator : CardDecorator
    {
        public DefenceDecorator(Card card, string name, int defense) : base(card, name, 0,defense)
        {
        }
    }
}
