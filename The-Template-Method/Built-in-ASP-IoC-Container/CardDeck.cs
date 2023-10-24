using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Built_in_ASP_IoC_Container
{
    public class CardDeck : ICardComponent
    {
        private List<ICardComponent> _components = new List<ICardComponent>();


        public void AddCard(ICardComponent component)
        {
            _components.Add(component);
        }

        public bool RemoveCard(ICardComponent component)
        {
            return _components.Remove(component);
        }

        ICardComponent ICardComponent.Get(int index)
        {
            return _components[index];
        }

        public string Display()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var component in _components)
            {
                builder.Append(component.Display() + "\r\n");
            }
            return builder.ToString();
        }
    }
}
