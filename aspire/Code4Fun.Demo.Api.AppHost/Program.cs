var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Code4Fun_Demo_Api>("demo-api");

await builder.Build().RunAsync();
