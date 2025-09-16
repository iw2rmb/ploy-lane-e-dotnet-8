using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/healthz", () => Results.Text("ok", "text/plain"));
app.MapGet("/", () => Results.Text("hello", "text/plain"));
app.Run();
