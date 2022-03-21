using MeteringApplication.Data;
using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string ConnectionSqlStr = builder.Configuration.GetConnectionString("MeteringAppConnection");

// Add services to the container.

builder.Services.AddDbContext<MeteringAppContext>(opt => opt.UseMySql
    (ConnectionSqlStr, ServerVersion.AutoDetect(ConnectionSqlStr)));

//builder.Services.AddDbContext<MeteringAppContext>(opt => opt.UseSqlServer
    //(builder.Configuration.GetConnectionString("MeteringAppConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICommanderRepo, SqlCommandsRepo>();

//builder.Services.AddScoped<ICommanderRepo, MockCommandsRepo>();

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

app.Run();
