using System;
using System.Collections.Generic;
using System.Text;
using PROJEKT.Classes;

namespace PROJEKT.Interfaces
{
    public interface IMessage
    {
        IMessage ProcessRequest(StateObject a_oObject = null);
        IMessage ProcessResponse(StateObject a_oObject = null);
        NetworkData AsNetworkData(int a_iDataSize = NetworkService.BUFFER_SIZE);
    }
}
