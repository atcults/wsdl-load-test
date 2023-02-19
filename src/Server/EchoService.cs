using CoreWCF;
using WcfSample.Common;

namespace WcfSample.Server
{
    public class EchoService : IEchoService
    {
        public Task<string> Echo(string text)
        {
            Console.WriteLine($"Received {text} from client!");
            return Task.FromResult(text);
        }

        public Task<string> ComplexEcho(EchoMessage text)
        {
            Console.WriteLine($"Received {text.Text} from client!");
            return Task.FromResult(text.Text);
        }

        public string FailEcho(string text)
            => throw new FaultException<EchoFault>(new EchoFault() { Text = "WCF Fault OK" }, new FaultReason("FailReason"));

    }
}