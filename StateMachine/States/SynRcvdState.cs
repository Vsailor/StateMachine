using StateMachine.Constants;
using StateMachine.States.Abstracts;
using System.Collections.Generic;

namespace StateMachine.States
{
    public class SynRcvdState : State
    {
        private readonly Dictionary<string, string> _eventStatesMap = new Dictionary<string, string>
        {
            { Events.AppClose, StateNames.FinWaitOne },
            { Events.RcvAck, StateNames.Established }
        };

        protected override Dictionary<string, string> EventStatesMap => _eventStatesMap;

        public override string Name => StateNames.SynRcvd;
    }
}