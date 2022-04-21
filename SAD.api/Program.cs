using SAD.Domain.Commands;
using SAD.Domain.Entities;
using SAD.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*");
                      });
});
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();
app.MapControllers();


app.MapPost("/", (ComandoDeRanqueamento comando) =>
{
    var resultado = ManipuladorDeRanqueamento.Handle(comando);
    return resultado;
});
app.MapPost("/invertido", (ComandoDeRanqueamento comando) =>
{
    var resultado = ManipuladorDeRanqueamento.HandleInvertido(comando);
    return resultado;
});



app.Run();
