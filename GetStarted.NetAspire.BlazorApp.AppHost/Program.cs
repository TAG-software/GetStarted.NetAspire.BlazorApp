var builder = DistributedApplication.CreateBuilder(args);

builder.Environment.ApplicationName = "FYI";

var apiService = builder.AddProject<Projects.GetStarted_NetAspire_BlazorApp_ApiService>("apiservice");

builder.AddProject<Projects.GetStarted_NetAspire_BlazorApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
