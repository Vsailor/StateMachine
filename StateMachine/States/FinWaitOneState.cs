﻿using StateMachine.Constants;
using StateMachine.States.Abstracts;
using System.Collections.Generic;

namespace StateMachine.States
{
    public class FinWaitOneState : State
    {
        private readonly Dictionary<string, string> _eventStatesMap = new Dictionary<string, string>
        {
            { Events.RcvFin, StateNames.Closing },
            { Events.RcvFinAck, StateNames.TimeWait },
            { Events.RcvAck, StateNames.FinWaitTwo }
        };

        protected override Dictionary<string, string> EventStatesMap => _eventStatesMap;

        public override string Name => StateNames.FinWaitOne;
    }
}