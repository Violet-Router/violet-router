using Microsoft.AspNetCore.Components.Web;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Violet Router API", Version = "v1" });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c=> 
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Violet Router API V1");
});

app.MapControllers();

app.Run();
