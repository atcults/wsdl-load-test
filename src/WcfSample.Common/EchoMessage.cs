using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace WcfSample.Common
{
    [DataContract]
    public class EchoMessage
    {
        [AllowNull]
        [DataMember]
        public string Text { get; set; }
    }
}