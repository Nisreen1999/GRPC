// See https://aka.ms/new-console-template for more information
using Grpc.Net.Client;
using GrpcClient;

Console.WriteLine("press any key to cont...");
Console.ReadLine();


using var channel = GrpcChannel.ForAddress("https://localhost:7000");
var client = new Greeter.GreeterClient (channel);
var reply = await client.SayHelloAsync(
                     new HelloRequest { Name = "GreeterClient" });
Console.WriteLine($"Greetings: " + reply.Message);
Console.WriteLine("press any key to exit...");
Console.ReadLine();