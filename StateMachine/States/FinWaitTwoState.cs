using StateMachine.Constants;
using StateMachine.States.Abstracts;
using System.Collections.Generic;

namespace StateMachine.States
{
    public class FinWaitTwoState : State
    {
        private readonly Dictionary<string, string> _eventStatesMap = new Dictionary<string, string>
        {
            { Events.RcvFin, StateNames.TimeWait }
        };

        protected override Dictionary<string, string> EventStatesMap => _eventStatesMap;

        public override string Name => StateNames.FinWaitTwo;
    }
}