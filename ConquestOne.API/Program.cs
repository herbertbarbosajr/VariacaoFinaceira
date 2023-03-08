using ConquestOne.Application;
using ConquestOne.Application.Interfaces;
using ConquestOne.Domain.Entities;
using ConquestOne.InfraStructure.Queries;
using ConquestOne.InfraStructure.Repositories;
using ConquestOne.InfraStructure.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<SQLQuery>();
builder.Services.AddTransient<IFinanceRepository, FinanceRepository>();
builder.Services.AddTransient<IFinanceVariationService, FinanceVariationService>();
builder.Services.AddTransient<InsertRequest>();


var app = builder.Build();

app.MapGet("Finance/Variacao/GetDatas/", ([FromServices] IFinanceRepository repository) =>
{
    return repository.Get();
});

app.MapPost("/Finance/Variacao/Insert/", ([FromServices] InsertRequest request, [FromBody] List<VariacaoEntity> dto) =>
{
    return request.Action(dto);
});

app.MapGet("/Finance/Variacao/Last30Days/", ([FromServices] IFinanceRepository repository) =>
{
    return repository.Get30Days();
});

app.Run();
