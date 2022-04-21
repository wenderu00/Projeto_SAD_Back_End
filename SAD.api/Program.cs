using SAD.Domain.Commands;
using SAD.Domain.Entities;
using SAD.Domain.Handlers;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.UseCors(c => 
{
    c.AllowAnyHeaders();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
}
);

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
