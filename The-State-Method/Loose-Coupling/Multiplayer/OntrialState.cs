using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling.Multiplayer
{
    public class OntrialState : IState
    {
        private SubscriptionManager subscriptionManager;

        public OntrialState(SubscriptionManager subscriptionManager)
        {
            this.subscriptionManager = subscriptionManager;
        }

        public void Expire()
        {
            Console.WriteLine("Tiral Expired");
            subscriptionManager.currentState = new TrialExpiredState(subscriptionManager);
        }

        public void Pay()
        {
            Console.WriteLine("Paid membership acquired");
            subscriptionManager.currentState = new PaidState(subscriptionManager);
        }
    }
}
