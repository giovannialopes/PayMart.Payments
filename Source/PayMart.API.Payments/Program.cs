using PayMart.Infrastructure.Payments.Injection;
using PayMart.Infrastructure.Payments.Migrations;
using PayMart.Domain.Payments.Services.AInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await MigrateDB();

app.Run();

async Task MigrateDB()
{
    await using var scope = app.Services.CreateAsyncScope();
    await DataBaseMigration.MigrateDataBase(scope.ServiceProvider);
}
