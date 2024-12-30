using Microsoft.EntityFrameworkCore;
using Cafe.API.Data;
using Cafe.API.Repo;
using Cafe.API.Service;
using Cafe.API.Items;

var builder = WebApplication.CreateBuilder(args);

//Add dbcontext and connect it to connection string
builder.Services.AddDbContext<CafeContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Cafe")));


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Dependency Inject the proper services
builder.Services.AddScoped<IDrinkService, DrinkService>();
builder.Services.AddScoped<IFoodService, FoodService>();
builder.Services.AddScoped<ISyrupService, SyrupService>();
builder.Services.AddScoped<IOrderService, OrderService>();

//Dependency Inject the proper repositories
builder.Services.AddScoped<IDrinkRepo, DrinkRepo>();
builder.Services.AddScoped<IFoodRepo, FoodRepo>();
builder.Services.AddScoped<ISyrupRepo, SyrupRepo>();
builder.Services.AddScoped<IOrderRepo, OrderRepo>();

//Add automapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

//Add our controllers
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

