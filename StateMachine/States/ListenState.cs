using StateMachine.Constants;
using StateMachine.States.Abstracts;
using System.Collections.Generic;

namespace StateMachine.States
{
    public class ListenState : State
    {
        private readonly Dictionary<string, string> _eventStatesMap = new Dictionary<string, string>
        {
            { Events.RcvSyn, StateNames.SynRcvd },
            { Events.AppSend, StateNames.SynSent },
            { Events.AppClose, StateNames.Closed }
        };

        protected override Dictionary<string, string> EventStatesMap => _eventStatesMap;

        public override string Name => StateNames.Listen;
    }
}