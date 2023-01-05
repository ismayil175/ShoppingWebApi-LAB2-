
using Microsoft.EntityFrameworkCore;
using ShoppingWebApi.EfCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<EF_DataContext>(
                o => o
                .UseNpgsql(builder.Configuration.GetConnectionString("Host=nam-sur-group.postgres.database.azure.com;Database=postgres;Username=ismayil;Password=30032003xoxuisI1!"))
                .UseSnakeCaseNamingConvention());
               


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

  
    app.UseSwagger();
    app.UseSwaggerUI();
   


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

  
  
