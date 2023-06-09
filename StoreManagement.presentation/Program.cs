using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using StoreManagement.Presentation.WebApi.Middleware;
using StoreManagement.Repository.DatabaseContext;
using StoreManagement.Repository.Repositories.RepositoryManager;
using StoreManagement.Service.Services.ServiceManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ExceptionHanlingMiddleware, ExceptionHanlingMiddleware>();
builder.Services.AddScoped<IServiceManager, ServiceManager>();
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddDbContext<StoreDbContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("StoreDbConnectionString");
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware< ExceptionHanlingMiddleware>();
app.UseAuthorization();
app.MapControllers();

app.Run();
