using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/TimeoutTest", async () =>
{
    await Task.Delay(TimeSpan.FromSeconds(90));

    return Results.Ok("Success after delay");
});

app.Run();
