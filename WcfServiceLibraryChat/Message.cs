using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibraryChat
{
    [DataContract]
    class Message
    {
        public Message(string message)
        {
            text = message;
        }

        [DataMember]
        public string text;
    }
}
