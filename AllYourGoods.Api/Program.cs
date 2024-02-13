using AllYourGoods.Application;
using AllYourGoods.Presentation;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

var presentationAssembly = typeof(AssemblyReference).Assembly;

builder.Services.AddPresentationServices();
builder.Services.AddControllers()
    .AddApplicationPart(presentationAssembly);

builder.Services.AddApplicationServices();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "SportSyncApi", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

#if !DEBUG
    app.UseHttpsRedirection();
#endif

app.MapControllers();

app.Run();
