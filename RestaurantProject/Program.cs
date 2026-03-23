using Microsoft.EntityFrameworkCore;
using RestaurantProject.Data;
using RestaurantProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddOpenApi();
builder.Services.AddDbContext<RestaurantDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RestaurantDbContext") ?? throw new InvalidOperationException(" RestaurantDbContext’ does not exist.")));

builder.Services.AddScoped<IBasketService, BasketService>(  );
builder.Services.AddScoped<ICategoryService, CategorieService>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


Task task = app.RunAsync();