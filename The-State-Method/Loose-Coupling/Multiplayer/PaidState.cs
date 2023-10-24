using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling.Multiplayer
{
    public class PaidState : IState
    {
        private SubscriptionManager _subscriptionManager;

        public PaidState(SubscriptionManager subscriptionManager)
        {
            _subscriptionManager = subscriptionManager;
        }

        public void Expire()
        {
            throw new InvalidOperationException("Cannot expire a paid membership");
        }

        public void Pay()
        {
            throw new InvalidOperationException("Cannot pay an already paid service");
        }
    }
}
