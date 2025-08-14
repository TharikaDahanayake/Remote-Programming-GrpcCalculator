using Grpc.Core;
using System.Threading.Tasks;

namespace GrpcCalculatorServer.Services
{
    public class CalculatorService : Calculator.CalculatorBase
    {
        public override Task<AddReply> AddNumbers(AddRequest request, ServerCallContext context)
        {
            var result = request.Number1 + request.Number2;
            return Task.FromResult(new AddReply { Sum = result });
        }
    }
}
