using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling.Multiplayer
{
    public class SubscriptionManager
    {
        public IState currentState;

        public SubscriptionManager()
        {
            this.currentState = new OntrialState(this);
        }

        public void Expire()
        {
            currentState.Expire();
        }

        public void Pay() {
        
        currentState.Pay();
        }


    }
}
