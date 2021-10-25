using Grpc.Core;
using MagicGrpc.Shared;
using MagicOnion.Client;
using System;



var channel = new Channel("127.0.0.1", 5500, ChannelCredentials.Insecure);
var client = MagicOnionClient.Create<IHealthService>(channel.CreateCallInvoker());

while (true)
{
    var res = await client.GetServerTime();
    Console.WriteLine(res);
}

//Console.ReadLine();