using StateMachine.Services;
using System.Collections.Generic;

namespace StateMachine.States.Abstracts
{
    public abstract class State
    {
        protected abstract Dictionary<string, string> EventStatesMap { get; }

        public abstract string Name { get; }

        public virtual State GetNextState(string eventName)
        {
            if (!EventStatesMap.TryGetValue(eventName, out string state))
                return null;

            return StateFactory.GetState(state);
        }
    }
}