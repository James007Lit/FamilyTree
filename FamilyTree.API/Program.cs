using FamilyTree.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

// Add after builder.Services.AddControllers();
builder.Services.AddDbContext<FamilyTreeContext>(options =>
    options.UseSqlite("Data Source=familytree.db"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<FamilyTreeContext>();
    context.Database.EnsureCreated();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.Run();
