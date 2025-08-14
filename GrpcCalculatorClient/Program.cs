using GrpcCalculatorServer; // matches csharp_namespace in calculator.proto
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("http://localhost:5020");
        var client = new Calculator.CalculatorClient(channel);

        var reply = await client.AddNumbersAsync(new AddRequest
        {
            Number1 = 10,
            Number2 = 20
        });

        Console.WriteLine($"Sum from server: {reply.Sum}");
    }
}
