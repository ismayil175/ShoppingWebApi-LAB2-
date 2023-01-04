using Microsoft.EntityFrameworkCore;
using ShoppingWebApi.EfCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProductContext>(options =>
    options
        .UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL 15")
        .UseSnakeCaseNamingConvention());

builder.Services.AddScoped<ProductService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
