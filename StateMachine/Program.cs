using StateMachine.Services;
using System;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var stateProcessor = new StateProcessor();
            var result = stateProcessor.Run(new[] { "APP_PASSIVE_OPEN", "APP_SEND", "RCV_SYN_ACK" });
            Console.WriteLine(result);

            result = stateProcessor.Run(new[] { "APP_ACTIVE_OPEN" });
            Console.WriteLine(result);

            result = stateProcessor.Run(new[] { "APP_ACTIVE_OPEN", "RCV_SYN_ACK", "APP_CLOSE", "RCV_FIN_ACK", "RCV_ACK" });
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}