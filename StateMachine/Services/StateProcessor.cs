using StateMachine.Constants;
using StateMachine.States;
using StateMachine.States.Abstracts;
using System.Linq;

namespace StateMachine.Services
{
    public class StateProcessor
    {
        public string Run(string[] events)
        {
            const string errorResult = "ERROR";

            if (events == null || events.Length == 0)
                return errorResult;

            State currentState;
            string firstEvent = events.First();
            switch (firstEvent)
            { 
                case Events.AppActiveOpen:
                    currentState = new SynSentState();
                    break;
                case Events.AppPassiveOpen:
                    currentState = new ListenState();
                    break;
                default:
                    return errorResult;
            }

            for (var i = 1; i < events.Length; i++)
            {
                currentState = currentState.GetNextState(events[i]);
                if (currentState == null)
                    return errorResult;
            }

            return currentState.Name;
        }
    }
}