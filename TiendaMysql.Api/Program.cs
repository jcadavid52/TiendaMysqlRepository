using TiendaMysql.Application;
using TiendaMysql.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TiendaMysql API v1");
        c.RoutePrefix = string.Empty;
    });
}
app.UseHttpsRedirection();
app.MapControllers();
app.Run();

public partial class Program { }
