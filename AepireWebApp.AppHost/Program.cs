var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AepireWebApp_ApiService>("apiservice");

builder.AddProject<Projects.AepireWebApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
