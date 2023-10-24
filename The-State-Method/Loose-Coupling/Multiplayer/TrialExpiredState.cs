using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling.Multiplayer
{
    public class TrialExpiredState : IState
    {
        private SubscriptionManager _subscriptionManager;

        public TrialExpiredState(SubscriptionManager subscriptionManager) {
            _subscriptionManager = subscriptionManager;
        }

        public void Expire()
        {
            throw new InvalidOperationException("Cannot expire an expired subscription");
        }

        public void Pay()
        {
            Console.WriteLine("Paid Membership");
            _subscriptionManager.currentState = new PaidState(_subscriptionManager);
        }
    }
}
