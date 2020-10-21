namespace StateMachine.Constants
{
    public static class StateNames
    {
        public const string Listen = "LISTEN";
        public const string SynSent = "SYN_SENT";
        public const string SynRcvd = "SYN_RCVD";
        public const string Closed = "CLOSED";
        public const string FinWaitOne = "FIN_WAIT_1";
        public const string Established = "ESTABLISHED";
        public const string CloseWait = "CLOSE_WAIT";
        public const string Closing = "CLOSING";
        public const string TimeWait = "TIME_WAIT";
        public const string FinWaitTwo = "FIN_WAIT_2";
        public const string LastAck = "LAST_ACK";
    }
}