﻿using System.Threading.Tasks;
using edjCase.JsonRpc.Client;
using RPCRequestResponseHandlers;

namespace Nethereum.RPC.Infrastructure
{
    public class GenericRpcRequestResponseHandlerNoParam<TResponse> : RpcRequestResponseHandlerNoParam<TResponse>
    {
        public GenericRpcRequestResponseHandlerNoParam(RpcClient client, string methodName) : base(client, methodName)
        {

        }

        public new Task<TResponse> SendRequestAsync(object id = null)
        {
            return base.SendRequestAsync(id);
        }
    }
}