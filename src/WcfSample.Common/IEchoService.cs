using System.ServiceModel;

namespace WcfSample.Common
{
    [ServiceContract]
    public interface IEchoService
    {
        [OperationContract]
        Task<string> Echo(string text);

        [OperationContract]
        Task<string> ComplexEcho(EchoMessage text);

        [OperationContract]
        [FaultContract(typeof(EchoFault))]
        string FailEcho(string text);

    }
}