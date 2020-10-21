using StateMachine.Constants;
using StateMachine.States;
using StateMachine.States.Abstracts;

namespace StateMachine.Services
{
    public static class StateFactory
    {
        public static State GetState(string name)
        {
            switch (name)
            {
                case StateNames.Closed:
                    return new ClosedState();
                case StateNames.CloseWait:
                    return new CloseWaitState();
                case StateNames.Closing:
                    return new ClosingState();
                case StateNames.Established:
                    return new EstablishedState();
                case StateNames.FinWaitOne:
                    return new FinWaitOneState();
                case StateNames.FinWaitTwo:
                    return new FinWaitTwoState();
                case StateNames.LastAck:
                    return new LastAckState();
                case StateNames.Listen:
                    return new ListenState();
                case StateNames.SynRcvd:
                    return new SynRcvdState();
                case StateNames.SynSent:
                    return new SynSentState();
                case StateNames.TimeWait:
                    return new TimeWaitState();
                default:
                    return null;
            }
        }
    }
}