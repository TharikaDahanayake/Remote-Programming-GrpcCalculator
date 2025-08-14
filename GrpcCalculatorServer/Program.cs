using GrpcCalculatorServer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add gRPC services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Map gRPC service
app.MapGrpcService<GrpcCalculatorServer.Services.CalculatorService>();
app.MapGet("/", () => "Use a gRPC client to connect.");

app.Run();
