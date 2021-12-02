using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Vuture.Persistence;
using Vuture.Persistence.Repositories;
using Vuture.Persistence.Repositories.Interfaces;
using Vuture.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "Vuture Contacts Api", Version = "v1" }); });
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<ContactDbContext>(opt => opt.UseInMemoryDatabase("ContactDb"));
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IContactService, ContactService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Vuture v1"));
    Console.WriteLine("SwaggerUI has been configured");
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Seeding db
InitialData.PopulateDb(app);
app.Run();