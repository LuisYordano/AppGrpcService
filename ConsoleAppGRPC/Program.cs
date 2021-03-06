using Grpc.Net.Client;
using GrpcService;

using var channel = GrpcChannel.ForAddress("https://localhost:7183");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "Developers" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();