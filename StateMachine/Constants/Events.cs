namespace StateMachine.Constants
{
    public static class Events
    {
        public const string AppPassiveOpen = "APP_PASSIVE_OPEN";
        public const string AppActiveOpen = "APP_ACTIVE_OPEN";
        public const string RcvSyn = "RCV_SYN";
        public const string AppSend = "APP_SEND";
        public const string AppClose = "APP_CLOSE";
        public const string RcvAck = "RCV_ACK";
        public const string RcvSynAck = "RCV_SYN_ACK";
        public const string RcvFin = "RCV_FIN";
        public const string RcvFinAck = "RCV_FIN_ACK";
        public const string AppTimeout = "APP_TIMEOUT";
    }
}