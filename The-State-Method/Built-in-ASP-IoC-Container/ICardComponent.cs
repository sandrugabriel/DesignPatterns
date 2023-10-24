using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_in_ASP_IoC_Container
{
    public interface ICardComponent
    {

        void AddCard(ICardComponent component);
        ICardComponent Get(int index);
        bool RemoveCard(ICardComponent component);
        string Display();
    }
}
