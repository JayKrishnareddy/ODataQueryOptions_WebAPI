using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Query.Expressions;
using ODataQueryOptions_WebAPI.DataBuilder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IStaticDataRepository, StaticDataRepository>();

builder.Services.AddControllers().AddOData(opt =>
                    opt.EnableQueryFeatures().
                    AddRouteComponents("odata", ODataModelBuilder.GetEdmModel(),
                    services =>
                    services.AddSingleton<ISearchBinder, StaticDataRepository>()));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
